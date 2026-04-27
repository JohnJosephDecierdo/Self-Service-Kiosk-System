using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class EditUserForm : Form
    {
        private UserRepository _userRepo = new UserRepository();
        private User _originalUser;

        public EditUserForm(User user)
        {
            _originalUser = user;
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            txtUsername.Text = _originalUser.Username;
            cboRole.SelectedItem = _originalUser.Role;
            // Leave password blank — only update if user types a new one
            lblCurrentUser.Text = $"Editing: {_originalUser.Username} (ID: {_originalUser.UserID})";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Check duplicate username (only if username was changed)
            if (txtUsername.Text.Trim().ToLower() != _originalUser.Username.ToLower())
            {
                if (_userRepo.UsernameExists(txtUsername.Text.Trim()))
                {
                    txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                    ShowError("Username already exists. Please choose another.", txtUsername);
                    return;
                }
            }

            // Prevent changing Owner role
            if (_originalUser.Role.ToLower() == "owner" && cboRole.SelectedItem.ToString() != "Owner")
            {
                ShowError("Cannot change the role of the Owner account.", cboRole);
                return;
            }

            string newPassword = string.IsNullOrWhiteSpace(txtNewPassword.Text)
                ? null  // null means don't change password
                : txtNewPassword.Text.Trim();

            bool success = _userRepo.UpdateUser(
                _originalUser.UserID,
                txtUsername.Text.Trim(),
                newPassword,
                cboRole.SelectedItem.ToString()
            );

            if (success)
            {
                MessageBox.Show(
                    $"User '{txtUsername.Text.Trim()}' updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update user. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            txtUsername.BackColor = Color.White;
            txtNewPassword.BackColor = Color.White;
            txtConfirmPassword.BackColor = Color.White;

            // Username validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username cannot be empty.", txtUsername);
                return false;
            }

            if (txtUsername.Text.Trim().Length < 3)
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username must be at least 3 characters.", txtUsername);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text.Trim(), @"^[a-zA-Z0-9_]+$"))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username can only contain letters, numbers, and underscores.", txtUsername);
                return false;
            }

            // Password validation — only if user typed something
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                if (txtNewPassword.Text.Length < 6)
                {
                    txtNewPassword.BackColor = Color.FromArgb(255, 220, 220);
                    ShowError("New password must be at least 6 characters.", txtNewPassword);
                    return false;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    txtNewPassword.BackColor = Color.FromArgb(255, 220, 220);
                    txtConfirmPassword.BackColor = Color.FromArgb(255, 220, 220);
                    ShowError("Passwords do not match.", txtConfirmPassword);
                    return false;
                }
            }

            return true;
        }

        // Clear highlights on typing
        private void txtUsername_TextChanged(object sender, EventArgs e) => txtUsername.BackColor = Color.White;
        private void txtNewPassword_TextChanged(object sender, EventArgs e) => txtNewPassword.BackColor = Color.White;
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) => txtConfirmPassword.BackColor = Color.White;

        // Show/hide password toggle
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void ShowError(string message, Control focusControl)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl.Focus();
        }
    }
}