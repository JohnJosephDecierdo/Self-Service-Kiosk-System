using System;
using System.Data;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class CookForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private System.Windows.Forms.Timer _refreshTimer;

        public CookForm()
        {
            InitializeComponent();
            LoadOrders();
            StartAutoRefresh();
            SessionManager.OrderChanged += OnOrderChanged;
        }

        private void OnOrderChanged()
        {
            if (!IsDisposed) Invoke((Action)LoadOrders);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e) => LoadOrders();
        private void btnPreparing_Click(object sender, EventArgs e) => UpdateStatus("Preparing");
        private void btnReady_Click(object sender, EventArgs e) => UpdateStatus("Ready");

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0) return;
            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            dgvDetails.DataSource = _orderRepo.GetOrderDetails(orderID);
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = _orderRepo.GetOrdersByStatuses(new[] { "Paid", "Preparing" });
            // Cook doesn't need to see prices — hide financial columns
            if (dgvOrders.Columns["totalAmount"] != null)
                dgvOrders.Columns["totalAmount"].Visible = false;
            if (dgvOrders.Columns["userID"] != null)
                dgvOrders.Columns["userID"].Visible = false;
        }

        private void UpdateStatus(string status)
        {
            if (dgvOrders.SelectedRows.Count == 0) { MessageBox.Show("Select an order first."); return; }
            string cur = dgvOrders.SelectedRows[0].Cells["status"].Value?.ToString();
            if (status == "Preparing" && cur != "Paid") { MessageBox.Show("Only Paid orders can be marked Preparing."); return; }
            if (status == "Ready" && cur != "Preparing") { MessageBox.Show("Only Preparing orders can be marked Ready."); return; }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            _orderRepo.UpdateStatus(orderID, status);
            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{orderID} marked as {status}!");
            LoadOrders();
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}