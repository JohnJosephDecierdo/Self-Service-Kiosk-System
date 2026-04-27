using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class CookForm : Form
    {
        private OrderRepository    _orderRepo = new OrderRepository();
        private MenuItemRepository _menuRepo  = new MenuItemRepository();
        private System.Windows.Forms.Timer _refreshTimer;

        public CookForm()
        {
            InitializeComponent();
            LoadOrders();
            LoadMenuAvailability();
            StartAutoRefresh();
            SessionManager.OrderChanged += OnOrderChanged;
        }

        private void OnOrderChanged()
        {
            if (!IsDisposed) Invoke((Action)LoadOrders);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes) this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadOrders();
        private void btnPreparing_Click(object sender, EventArgs e) => UpdateStatus("Preparing");
        private void btnReady_Click(object sender, EventArgs e)     => UpdateStatus("Ready");

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0) return;
            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            dgvDetails.DataSource = _orderRepo.GetOrderDetails(orderID);
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = _orderRepo.GetOrdersByStatuses(new[] { "Paid", "Preparing" });
            if (dgvOrders.Columns["totalAmount"] != null)
                dgvOrders.Columns["totalAmount"].Visible = false;
            if (dgvOrders.Columns["userID"] != null)
                dgvOrders.Columns["userID"].Visible = false;
        }

        private void UpdateStatus(string status)
        {
            if (dgvOrders.SelectedRows.Count == 0) { MessageBox.Show("Select an order first."); return; }
            string cur = dgvOrders.SelectedRows[0].Cells["status"].Value?.ToString();
            if (status == "Preparing" && cur != "Paid")      { MessageBox.Show("Only Paid orders can be marked Preparing."); return; }
            if (status == "Ready"     && cur != "Preparing") { MessageBox.Show("Only Preparing orders can be marked Ready."); return; }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            _orderRepo.UpdateStatus(orderID, status);
            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{orderID} marked as {status}!");
            LoadOrders();
        }

        // ════════════════════════════════════════════════════
        //  MENU AVAILABILITY TAB
        // ════════════════════════════════════════════════════
        private void LoadMenuAvailability()
        {
            dgvMenu.DataSource = _menuRepo.GetAll();
            StyleAvailabilityGrid();

            // Allow clicking the checkbox cell to toggle directly
            dgvMenu.CellContentClick -= dgvMenu_CellContentClick;
            dgvMenu.CellContentClick += dgvMenu_CellContentClick;
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvMenu.Columns[e.ColumnIndex]?.Name != "isAvailable") return;

            var row     = dgvMenu.Rows[e.RowIndex];
            int  itemID = Convert.ToInt32(row.Cells["itemID"].Value);

            // CellContentClick fires BEFORE the value changes, so toggle the current value
            bool currentValue = Convert.ToBoolean(row.Cells["isAvailable"].Value);
            bool newValue     = !currentValue;

            if (_menuRepo.SetAvailability(itemID, newValue))
            {
                LoadMenuAvailability();
                SessionManager.NotifyMenuChanged();
            }
        }

        private void StyleAvailabilityGrid()
        {
            if (dgvMenu.Columns.Count == 0) return;
            foreach (DataGridViewColumn col in dgvMenu.Columns)
                col.Visible = false;
            if (dgvMenu.Columns["itemID"]      != null) { dgvMenu.Columns["itemID"].Visible      = true; dgvMenu.Columns["itemID"].HeaderText      = "ID"; }
            if (dgvMenu.Columns["name"]        != null) { dgvMenu.Columns["name"].Visible        = true; dgvMenu.Columns["name"].HeaderText        = "Item Name"; }
            if (dgvMenu.Columns["category"]    != null) { dgvMenu.Columns["category"].Visible    = true; dgvMenu.Columns["category"].HeaderText    = "Category"; }
            if (dgvMenu.Columns["price"]       != null) { dgvMenu.Columns["price"].Visible       = true; dgvMenu.Columns["price"].HeaderText       = "Price"; }
            if (dgvMenu.Columns["isAvailable"] != null) { dgvMenu.Columns["isAvailable"].Visible = true; dgvMenu.Columns["isAvailable"].HeaderText = "Available?"; }

            // Color rows: unavailable = red tint
            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                if (row.Cells["isAvailable"]?.Value is bool avail)
                {
                    row.DefaultCellStyle.BackColor = avail
                        ? Color.White
                        : Color.FromArgb(255, 220, 220);
                    row.DefaultCellStyle.ForeColor = avail
                        ? Color.FromArgb(30, 30, 30)
                        : Color.FromArgb(180, 0, 0);
                }
            }
        }

        private void btnMarkUnavailable_Click(object sender, EventArgs e)
            => ToggleAvailability(false);

        private void btnMarkAvailable_Click(object sender, EventArgs e)
            => ToggleAvailability(true);

        private void btnRefreshMenu_Click(object sender, EventArgs e)
            => LoadMenuAvailability();

        private void ToggleAvailability(bool available)
        {
            DataGridViewRow row = dgvMenu.SelectedRows.Count > 0
                ? dgvMenu.SelectedRows[0] : dgvMenu.CurrentRow;
            if (row == null) { MessageBox.Show("Select a menu item first."); return; }

            int    itemID = Convert.ToInt32(row.Cells["itemID"].Value);
            string name   = row.Cells["name"].Value?.ToString();
            string action = available ? "AVAILABLE" : "UNAVAILABLE (Sold Out)";

            var confirm = MessageBox.Show(
                $"Mark '{name}' as {action}?\n\n" +
                (available ? "Customers will be able to order this item again."
                           : "Customers will NOT be able to order this item."),
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_menuRepo.SetAvailability(itemID, available))
            {
                MessageBox.Show($"'{name}' marked as {action}.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuAvailability();
                SessionManager.NotifyMenuChanged(); // notify CustomerForm instantly
            }
        }

        private void StartAutoRefresh()
        {
            _refreshTimer = new System.Windows.Forms.Timer { Interval = 8000 };
            _refreshTimer.Tick += (s, e) => LoadOrders();
            _refreshTimer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirm = MessageBox.Show("Are you sure you want to log out?",
                    "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) { e.Cancel = true; return; }
            }
            _refreshTimer?.Stop();
            SessionManager.OrderChanged -= OnOrderChanged;
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e) => base.OnFormClosed(e);
    }
}
