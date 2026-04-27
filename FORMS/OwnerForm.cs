using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    // ══════════════════════════════════════════════════════════
    //  OwnerForm — Full system access, superset of ManagerForm
    //  Owner-exclusive extras:
    //    • Can add/edit/delete Manager accounts
    //    • Bypasses PIN prompt when editing orders
    //    • Can reset Manager PIN without knowing old PIN
    //    • Owner Controls tab: role promotion / system overview
    // ══════════════════════════════════════════════════════════
    public partial class OwnerForm : Form
    {
        private MenuItemRepository     _menuRepo     = new MenuItemRepository();
        private OrderRepository        _orderRepo    = new OrderRepository();
        private UserRepository         _userRepo     = new UserRepository();
        private SettingsRepository     _settingsRepo = new SettingsRepository();
        private AnalyticsRepository    _analytics    = new AnalyticsRepository();

        private string _ownerUsername = "Owner";
        private AnalyticsForm _analyticsForm = null;

        public OwnerForm(string username = "Owner")
        {
            _ownerUsername = username;
            InitializeComponent();
            // Show owner name in title bar
            this.Text = $"👑  Owner Dashboard  —  {username}";
            LoadAll();
        }

        private void LoadAll()
        {
            RefreshMenuGrid();
            RefreshUsers();
            LoadOwnerStats();
            string pin = _settingsRepo.GetSetting("ManagerPIN");
            txtCurrentPIN.Text = pin ?? "";
        }


        // ── Logout ───────────────────────────────────────────
        private void btnLogout_Click(object sender, EventArgs e) => this.Close();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirm = MessageBox.Show("Are you sure you want to log out?",
                    "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) { e.Cancel = true; return; }
            }
            base.OnFormClosing(e);
        }

        private void OpenAnalytics()
        {
            if (_analyticsForm == null || _analyticsForm.IsDisposed)
            {
                _analyticsForm = new AnalyticsForm();
                _analyticsForm.Show();
            }
            else
            {
                _analyticsForm.BringToFront();
                _analyticsForm.Focus();
            }
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
            => OpenAnalytics();

        private void btnOwnerAnalytics_Click(object sender, EventArgs e)
            => OpenAnalytics();

        private void btnInventory_Click(object sender, EventArgs e)
            => new InventoryForm(_ownerUsername).ShowDialog();

        // ════════════════════════════════════════════════════
        //  TAB 1 — MENU MANAGEMENT (same as manager)
        // ════════════════════════════════════════════════════
        private bool ValidateMenuForm()
        {
            txtName.BackColor  = Color.White;
            txtPrice.BackColor = Color.White;
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            { txtName.BackColor = Color.FromArgb(255,220,220); valid = false; }
            else if (txtName.Text.Trim().Length < 2)
            {
                txtName.BackColor = Color.FromArgb(255,220,220);
                MessageBox.Show("Name must be at least 2 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            { txtPrice.BackColor = Color.FromArgb(255,220,220); valid = false; }
            else if (!double.TryParse(txtPrice.Text, out double p) || p <= 0 || p > 99999)
            {
                txtPrice.BackColor = Color.FromArgb(255,220,220);
                MessageBox.Show("Price must be a valid number between 0 and 99999.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus(); return false;
            }

            if (!valid)
            { MessageBox.Show("Please fill all required fields.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateMenuForm()) return;
            var item = new MenuItem {
                Name     = txtName.Text.Trim(),
                Price    = double.Parse(txtPrice.Text),
                Category = cboCategory.SelectedItem.ToString()
            };
            foreach (DataRow r in _menuRepo.GetAll().Rows)
                if (r["name"].ToString().ToLower() == item.Name.ToLower())
                {
                    txtName.BackColor = Color.FromArgb(255,220,220);
                    MessageBox.Show($"'{item.Name}' already exists.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus(); return;
                }
            if (_menuRepo.Add(item))
            { MessageBox.Show($"'{item.Name}' added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              ClearMenuForm(); RefreshMenuGrid(); }
        }


        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            { MessageBox.Show("Select an item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!ValidateMenuForm()) return;
            var item = new MenuItem {
                ItemID   = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["itemID"].Value),
                Name     = txtName.Text.Trim(),
                Price    = double.Parse(txtPrice.Text),
                Category = cboCategory.SelectedItem.ToString()
            };
            if (_menuRepo.Update(item))
            { MessageBox.Show($"'{item.Name}' updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              ClearMenuForm(); RefreshMenuGrid(); }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            { MessageBox.Show("Select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            string name = dgvMenu.SelectedRows[0].Cells["name"].Value?.ToString();
            int id = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["itemID"].Value);
            if (MessageBox.Show($"Delete '{name}'?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (_menuRepo.Delete(id))
                { MessageBox.Show($"'{name}' deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  ClearMenuForm(); RefreshMenuGrid(); }
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e) { ClearMenuForm(); RefreshMenuGrid(); }
        private void RefreshMenuGrid() => dgvMenu.DataSource = _menuRepo.GetAll();
        private void ClearMenuForm()
        {
            txtName.Text = ""; txtPrice.Text = "";
            txtName.BackColor = Color.White; txtPrice.BackColor = Color.White;
            cboCategory.SelectedIndex = 0;
        }
        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0) return;
            txtName.Text     = dgvMenu.SelectedRows[0].Cells["name"].Value?.ToString();
            txtPrice.Text    = dgvMenu.SelectedRows[0].Cells["price"].Value?.ToString();
            cboCategory.Text = dgvMenu.SelectedRows[0].Cells["category"].Value?.ToString();
            txtName.BackColor = txtPrice.BackColor = Color.White;
        }
        private void txtName_TextChanged(object sender, EventArgs e)  => txtName.BackColor  = Color.White;
        private void txtPrice_TextChanged(object sender, EventArgs e) => txtPrice.BackColor = Color.White;
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && txtPrice.Text.Contains('.')) e.Handled = true;
        }


        // ════════════════════════════════════════════════════
        //  TAB 2 — REPORTS (Owner skips PIN prompt entirely)
        // ════════════════════════════════════════════════════
        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = _orderRepo.GetAllOrders();
            foreach (DataGridViewColumn c in dgvReports.Columns) c.Visible = true;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvReports.SelectedRows.Count > 0
                ? dgvReports.SelectedRows[0] : dgvReports.CurrentRow;
            if (row == null)
            { MessageBox.Show("Select an order to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int    orderID = Convert.ToInt32(row.Cells["orderID"].Value);
            string status  = row.Cells["status"].Value?.ToString();
            // ── OWNER PRIVILEGE: no PIN prompt ──────────────
            var editForm = new EditOrderForm(orderID, status);
            if (editForm.ShowDialog() == DialogResult.OK)
                dgvReports.DataSource = _orderRepo.GetAllOrders();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvReports.SelectedRows.Count > 0
                ? dgvReports.SelectedRows[0] : dgvReports.CurrentRow;
            if (row == null)
            { MessageBox.Show("Select an order to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string status = row.Cells["status"].Value?.ToString();
            if (status == "Cancelled")
            { MessageBox.Show("This order is already cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (status == "Completed")
            { MessageBox.Show("Completed orders cannot be cancelled.", "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int orderID = Convert.ToInt32(row.Cells["orderID"].Value);
            if (MessageBox.Show($"Cancel Order #{orderID}?\nThis cannot be undone.",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            if (_orderRepo.UpdateStatus(orderID, "Cancelled"))
            {
                SessionManager.NotifyOrderChanged();
                MessageBox.Show($"Order #{orderID} has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReports.DataSource = _orderRepo.GetAllOrders();
            }
        }

        // ════════════════════════════════════════════════════
        //  TAB 3 — USERS  (Owner can manage Manager accounts)
        // ════════════════════════════════════════════════════
        private void RefreshUsers()
        {
            dgvUsers.DataSource = _userRepo.GetAllUsers();
            // Colour-code roles
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                string role = row.Cells["role"].Value?.ToString().ToLower() ?? "";
                row.DefaultCellStyle.ForeColor = role switch {
                    "owner"    => Color.FromArgb(183, 110, 0),
                    "manager"  => Color.FromArgb(13, 71, 161),
                    "cashier"  => Color.FromArgb(39, 174, 96),
                    "cook"     => Color.FromArgb(156, 39, 176),
                    _          => Color.FromArgb(50, 50, 50)
                };
                row.DefaultCellStyle.Font = role == "owner"
                    ? new Font("Segoe UI", 9F, FontStyle.Bold)
                    : new Font("Segoe UI", 9F);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            if (reg.ShowDialog() == DialogResult.OK)
            { RefreshUsers(); MessageBox.Show("User added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.SelectedRows.Count > 0 ? dgvUsers.SelectedRows[0] : dgvUsers.CurrentRow;
            if (row == null)
            { MessageBox.Show("Select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int    userID   = Convert.ToInt32(row.Cells["userID"].Value);
            string username = row.Cells["username"].Value?.ToString();
            string role     = row.Cells["role"].Value?.ToString();
            var editForm = new EditUserForm(new User { UserID = userID, Username = username, Role = role });
            if (editForm.ShowDialog() == DialogResult.OK) RefreshUsers();
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e) => RefreshUsers();


        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.SelectedRows.Count > 0 ? dgvUsers.SelectedRows[0] : dgvUsers.CurrentRow;
            if (row == null)
            { MessageBox.Show("Select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            string role     = row.Cells["role"].Value?.ToString().ToLower();
            string username = row.Cells["username"].Value?.ToString();
            int    id       = Convert.ToInt32(row.Cells["userID"].Value);

            // ── OWNER PRIVILEGE: Owner account can never be deleted ──
            if (role == "owner")
            { MessageBox.Show("The Owner account cannot be deleted.", "Not Allowed",
                MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (MessageBox.Show($"Delete user '{username}' ({role})?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (_userRepo.DeleteUser(id))
                { MessageBox.Show($"'{username}' deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  RefreshUsers(); }
        }

        // ════════════════════════════════════════════════════
        //  TAB 4 — SETTINGS  (Owner can reset PIN freely)
        // ════════════════════════════════════════════════════
        private void btnShowPIN_Click(object sender, EventArgs e)
        {
            txtCurrentPIN.Text = _settingsRepo.GetSetting("ManagerPIN") ?? "";
            txtCurrentPIN.UseSystemPasswordChar = !txtCurrentPIN.UseSystemPasswordChar;
            btnShowPIN.Text = txtCurrentPIN.UseSystemPasswordChar ? "Show PIN" : "Hide PIN";
            btnShowPIN.BackColor = txtCurrentPIN.UseSystemPasswordChar
                ? Color.FromArgb(33, 150, 243) : Color.FromArgb(13, 71, 161);
        }

        private void btnSavePIN_Click(object sender, EventArgs e)
        {
            txtNewPIN.BackColor = txtConfirmPIN.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNewPIN.Text))
            { txtNewPIN.BackColor = Color.FromArgb(255,220,220);
              MessageBox.Show("Enter a new PIN.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtNewPIN.Focus(); return; }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNewPIN.Text, @"^\d{4}$"))
            { txtNewPIN.BackColor = Color.FromArgb(255,220,220);
              MessageBox.Show("PIN must be exactly 4 digits.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtNewPIN.Focus(); return; }
            if (txtNewPIN.Text != txtConfirmPIN.Text)
            { txtConfirmPIN.BackColor = Color.FromArgb(255,220,220);
              MessageBox.Show("PINs do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtConfirmPIN.Focus(); return; }
            if (_settingsRepo.UpdateSetting("ManagerPIN", txtNewPIN.Text))
            { MessageBox.Show("Manager PIN updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txtCurrentPIN.Text = txtNewPIN.Text;
              txtNewPIN.Text = txtConfirmPIN.Text = ""; }
        }

        private void txtNewPIN_TextChanged(object sender, EventArgs e)     => txtNewPIN.BackColor     = Color.White;
        private void txtConfirmPIN_TextChanged(object sender, EventArgs e)  => txtConfirmPIN.BackColor = Color.White;
        private void txtNewPIN_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void txtConfirmPIN_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }


        // ════════════════════════════════════════════════════
        //  TAB 5 — OWNER CONTROLS (exclusive tab)
        // ════════════════════════════════════════════════════
        private void LoadOwnerStats()
        {
            try
            {
                // Quick summary cards on Owner Controls tab
                lblStatTotalSales.Text   = $"₱{_analytics.GetTotalSalesThisMonth():N2}";
                lblStatTotalOrders.Text  = _analytics.GetTotalOrdersToday().ToString();
                lblStatAvgOrder.Text     = $"₱{_analytics.GetAverageOrderValue():N2}";
                lblStatCustomers.Text    = _analytics.GetTotalCustomers().ToString();

                // All-time top items in the owner grid
                dgvOwnerTopItems.DataSource = _analytics.GetTopSellingItems(10);
                if (dgvOwnerTopItems.Columns.Count > 0)
                {
                    dgvOwnerTopItems.Columns["name"].HeaderText        = "Item";
                    dgvOwnerTopItems.Columns["category"].HeaderText    = "Category";
                    dgvOwnerTopItems.Columns["totalQty"].HeaderText    = "Total Sold";
                    dgvOwnerTopItems.Columns["totalRevenue"].HeaderText = "Revenue";
                }

                // All-time orders grid
                dgvAllOrders.DataSource = _orderRepo.GetAllOrdersWithStatus();
            }
            catch { /* swallow on fresh DB */ }
        }

        private void btnOwnerRefresh_Click(object sender, EventArgs e) => LoadOwnerStats();

        private void btnOwnerEditOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAllOrders.SelectedRows.Count > 0
                ? dgvAllOrders.SelectedRows[0] : dgvAllOrders.CurrentRow;
            if (row == null)
            { MessageBox.Show("Select an order.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int    orderID = Convert.ToInt32(row.Cells["orderID"].Value);
            string status  = row.Cells["status"].Value?.ToString();
            // Owner always bypasses PIN
            var editForm = new EditOrderForm(orderID, status);
            if (editForm.ShowDialog() == DialogResult.OK) LoadOwnerStats();
        }
    }
}
