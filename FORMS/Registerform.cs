using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class RegisterForm : Form
    {
        private UserRepository _userRepo = new UserRepository();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Check duplicate username
            if (_userRepo.UsernameExists(txtUsername.Text.Trim()))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username already exists. Please choose another.", txtUsername);
                return;
            }

            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cboRole.SelectedItem.ToString()
            };

            if (_userRepo.AddUser(user))
            {
                MessageBox.Show(
                    $"Account created successfully!\n\nUsername: {user.Username}\nRole: {user.Role}",
                    "Registration Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again.",
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
            // Clear all highlights
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            txtConfirmPassword.BackColor = Color.White;

            bool valid = true;

            // Username checks
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }
            else if (txtUsername.Text.Trim().Length < 3)
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username must be at least 3 characters.", txtUsername);
                return false;
            }
            else if (txtUsername.Text.Trim().Length > 50)
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username cannot exceed 50 characters.", txtUsername);
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text.Trim(), @"^[a-zA-Z0-9_]+$"))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username can only contain letters, numbers, and underscores.", txtUsername);
                return false;
            }

            // Password checks
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }
            else if (txtPassword.Text.Length < 6)
            {
                txtPassword.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Password must be at least 6 characters.", txtPassword);
                return false;
            }

            // Confirm password check
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtPassword.BackColor = Color.FromArgb(255, 220, 220);
                txtConfirmPassword.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Passwords do not match.", txtConfirmPassword);
                return false;
            }

            if (!valid)
            {
                ShowError("Please fill in all required fields.", txtUsername);
                return false;
            }

            return true;
        }

        // Password strength indicator
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            string pwd = txtPassword.Text;

            if (pwd.Length == 0)
            {
                lblStrength.Text = "";
                pnlStrengthBar.Width = 0;
                return;
            }

            int strength = 0;
            if (pwd.Length >= 6) strength++;
            if (pwd.Length >= 10) strength++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, @"[A-Z]")) strength++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, @"[0-9]")) strength++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, @"[^a-zA-Z0-9]")) strength++;

            switch (strength)
            {
                case 1:
                    lblStrength.Text = "Weak";
                    lblStrength.ForeColor = Color.FromArgb(231, 76, 60);
                    pnlStrengthBar.Width = 80;
                    pnlStrengthBar.BackColor = Color.FromArgb(231, 76, 60);
                    break;
                case 2:
                case 3:
                    lblStrength.Text = "Fair";
                    lblStrength.ForeColor = Color.FromArgb(243, 156, 18);
                    pnlStrengthBar.Width = 160;
                    pnlStrengthBar.BackColor = Color.FromArgb(243, 156, 18);
                    break;
                case 4:
                    lblStrength.Text = "Good";
                    lblStrength.ForeColor = Color.FromArgb(52, 152, 219);
                    pnlStrengthBar.Width = 240;
                    pnlStrengthBar.BackColor = Color.FromArgb(52, 152, 219);
                    break;
                case 5:
                    lblStrength.Text = "Strong";
                    lblStrength.ForeColor = Color.FromArgb(39, 174, 96);
                    pnlStrengthBar.Width = 320;
                    pnlStrengthBar.BackColor = Color.FromArgb(39, 174, 96);
                    break;
                default:
                    lblStrength.Text = "";
                    pnlStrengthBar.Width = 0;
                    break;
            }
        }

        // Clear highlights on typing
        private void txtUsername_TextChanged(object sender, EventArgs e) => txtUsername.BackColor = Color.White;
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) => txtConfirmPassword.BackColor = Color.White;

        // Show/hide password toggle
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Enter key on last field triggers register
        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRegister_Click(sender, e);
        }

        private void ShowError(string message, Control focusControl)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl.Focus();
        }
    }
}