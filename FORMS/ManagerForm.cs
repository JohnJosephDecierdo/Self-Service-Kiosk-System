using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class ManagerForm : Form
    {
        private MenuItemRepository _menuRepo = new MenuItemRepository();
        private OrderRepository _orderRepo = new OrderRepository();
        private UserRepository _userRepo = new UserRepository();
        private SettingsRepository _settingsRepo = new SettingsRepository();
        private string _currentManagerUsername = "Manager";

        public ManagerForm(string username = "Manager")
        {
            _currentManagerUsername = username;
            InitializeComponent();
            RefreshMenuGrid();
            dgvUsers.DataSource = _userRepo.GetAllUsers();
            // Load current PIN into Settings tab on open
            string currentPIN = _settingsRepo.GetSetting("ManagerPIN");
            txtCurrentPIN.Text = currentPIN ?? "";
        }

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
        private void btnLogout_Click(object sender, EventArgs e) => this.Close();

        private void btnAnalytics_Click(object sender, EventArgs e)
            => new AnalyticsForm().Show();

        private void btnInventory_Click(object sender, EventArgs e)
            => new InventoryForm(_currentManagerUsername).ShowDialog();

        // ── Menu Validation ─────────────────────────────────
        private bool ValidateMenuForm()
        {
            bool valid = true;
            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }
            else if (txtName.Text.Trim().Length < 2)
            {
                txtName.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Item name must be at least 2 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                txtPrice.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }
            else if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            {
                txtPrice.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Price must be a valid number greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            else if (price > 99999)
            {
                txtPrice.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Price seems too high. Please check.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!valid)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateMenuForm()) return;

            double price = double.Parse(txtPrice.Text);
            var item = new MenuItem
            {
                Name = txtName.Text.Trim(),
                Price = price,
                Category = cboCategory.SelectedItem.ToString()
            };

            // Check for duplicate name
            DataTable existing = _menuRepo.GetAll();
            foreach (DataRow row in existing.Rows)
            {
                if (row["name"].ToString().ToLower() == item.Name.ToLower())
                {
                    txtName.BackColor = Color.FromArgb(255, 220, 220);
                    MessageBox.Show($"'{item.Name}' already exists in the menu.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }
            }

            if (_menuRepo.Add(item))
            {
                MessageBox.Show($"'{item.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMenuForm();
                RefreshMenuGrid();
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateMenuForm()) return;

            double price = double.Parse(txtPrice.Text);
            var item = new MenuItem
            {
                ItemID = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["itemID"].Value),
                Name = txtName.Text.Trim(),
                Price = price,
                Category = cboCategory.SelectedItem.ToString()
            };

            if (_menuRepo.Update(item))
            {
                MessageBox.Show($"'{item.Name}' updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMenuForm();
                RefreshMenuGrid();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = dgvMenu.SelectedRows[0].Cells["name"].Value?.ToString();
            int id = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["itemID"].Value);

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete '{itemName}'?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (_menuRepo.Delete(id))
                {
                    MessageBox.Show($"'{itemName}' deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMenuForm();
                    RefreshMenuGrid();
                }
            }
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            ClearMenuForm();
            RefreshMenuGrid();
        }

        // ── Reports ──────────────────────────────────────────
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            if (dgvReports.SelectedRows.Count > 0)
                row = dgvReports.SelectedRows[0];
            else if (dgvReports.CurrentRow != null)
                row = dgvReports.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Please select an order to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Manager is already authenticated — no PIN needed
            int orderID = Convert.ToInt32(row.Cells["orderID"].Value);
            string status = row.Cells["status"].Value?.ToString();

            var editForm = new EditOrderForm(orderID, status);
            if (editForm.ShowDialog() == DialogResult.OK)
                dgvReports.DataSource = _orderRepo.GetAllOrders();
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = _orderRepo.GetAllOrders();
            // Show all columns for manager — they have full access
            if (dgvReports.Columns.Count > 0)
            {
                foreach (System.Windows.Forms.DataGridViewColumn col in dgvReports.Columns)
                    col.Visible = true;
            }
            if (dgvReports.Rows.Count == 0)
                MessageBox.Show("No orders found.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // ── Users ────────────────────────────────────────────
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.SelectedRows.Count > 0
                ? dgvUsers.SelectedRows[0] : dgvUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = Convert.ToInt32(row.Cells["userID"].Value);
            string username = row.Cells["username"].Value?.ToString();
            string role = row.Cells["role"].Value?.ToString();

            if (role?.ToLower() == "owner")
            {
                MessageBox.Show("Cannot edit the Owner account.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User { UserID = userID, Username = username, Role = role };
            var editForm = new EditUserForm(user);
            if (editForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                dgvUsers.DataSource = _userRepo.GetAllUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            if (regForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvUsers.DataSource = _userRepo.GetAllUsers();
                MessageBox.Show("New user added successfully!", "Success",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _userRepo.GetAllUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.SelectedRows.Count > 0
                ? dgvUsers.SelectedRows[0] : dgvUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = row.Cells["username"].Value?.ToString();
            int id = Convert.ToInt32(row.Cells["userID"].Value);
            string role = row.Cells["role"].Value?.ToString().ToLower();

            if (role == "owner")
            {
                MessageBox.Show("Cannot delete the Owner account.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete user '{username}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
                if (_userRepo.DeleteUser(id))
                {
                    MessageBox.Show($"User '{username}' deleted.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsers.DataSource = _userRepo.GetAllUsers();
                }
        }

        // ── Helpers ──────────────────────────────────────────
        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0) return;
            txtName.Text = dgvMenu.SelectedRows[0].Cells["name"].Value?.ToString();
            txtPrice.Text = dgvMenu.SelectedRows[0].Cells["price"].Value?.ToString();
            cboCategory.Text = dgvMenu.SelectedRows[0].Cells["category"].Value?.ToString();
            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
        }

        private void txtName_TextChanged(object sender, EventArgs e) => txtName.BackColor = Color.White;
        private void txtPrice_TextChanged(object sender, EventArgs e) => txtPrice.BackColor = Color.White;

        // Only allow numbers and decimal point in price field
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && txtPrice.Text.Contains('.'))
                e.Handled = true;
        }

        private void ClearMenuForm()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
            cboCategory.SelectedIndex = 0;
        }

        // ── Settings ─────────────────────────────────────────
        private void btnShowPIN_Click(object sender, EventArgs e)
        {
            string current = _settingsRepo.GetSetting("ManagerPIN");
            txtCurrentPIN.Text = current ?? "";

            // Toggle show/hide
            if (txtCurrentPIN.UseSystemPasswordChar)
            {
                txtCurrentPIN.UseSystemPasswordChar = false;
                btnShowPIN.Text = "Hide PIN";
                btnShowPIN.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            }
            else
            {
                txtCurrentPIN.UseSystemPasswordChar = true;
                btnShowPIN.Text = "Show PIN";
                btnShowPIN.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            }
        }

        private void btnSavePIN_Click(object sender, EventArgs e)
        {
            txtNewPIN.BackColor = System.Drawing.Color.White;
            txtConfirmPIN.BackColor = System.Drawing.Color.White;

            if (string.IsNullOrWhiteSpace(txtNewPIN.Text))
            {
                txtNewPIN.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                MessageBox.Show("Please enter a new PIN.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPIN.Focus(); return;
            }
            if (txtNewPIN.Text.Length != 4 || !System.Text.RegularExpressions.Regex.IsMatch(txtNewPIN.Text, @"^\d{4}$"))
            {
                txtNewPIN.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                MessageBox.Show("PIN must be exactly 4 digits.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPIN.Focus(); return;
            }
            if (txtNewPIN.Text != txtConfirmPIN.Text)
            {
                txtConfirmPIN.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                MessageBox.Show("PINs do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPIN.Focus(); return;
            }

            if (_settingsRepo.UpdateSetting("ManagerPIN", txtNewPIN.Text))
            {
                MessageBox.Show("Manager PIN updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPIN.Text = "";
                txtConfirmPIN.Text = "";
                txtCurrentPIN.Text = txtNewPIN.Text;
            }
        }

        private void txtNewPIN_TextChanged(object sender, EventArgs e) => txtNewPIN.BackColor = System.Drawing.Color.White;
        private void txtConfirmPIN_TextChanged(object sender, EventArgs e) => txtConfirmPIN.BackColor = System.Drawing.Color.White;

        private void txtNewPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void txtConfirmPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void RefreshMenuGrid() => dgvMenu.DataSource = _menuRepo.GetAll();
    }
}