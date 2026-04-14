using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class LoginForm : Form
    {
        private UserRepository _userRepo = new UserRepository();
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Clear previous error highlights
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = Color.FromArgb(255, 220, 220);
                valid = false;
            }

            if (!valid)
            {
                ShowError("Please fill in all fields.", txtUsername);
                return;
            }

            if (txtUsername.Text.Trim().Length < 3)
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Username must be at least 3 characters.", txtUsername);
                return;
            }

            User user = _userRepo.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (user == null)
            {
                txtUsername.BackColor = Color.FromArgb(255, 220, 220);
                txtPassword.BackColor = Color.FromArgb(255, 220, 220);
                ShowError("Invalid username or password.", txtUsername);
                return;
            }

            LoggedInUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Clear highlight when user starts typing
        private void txtUsername_TextChanged(object sender, EventArgs e) => txtUsername.BackColor = Color.White;
        private void txtPassword_TextChanged(object sender, EventArgs e) => txtPassword.BackColor = Color.White;

        // Allow pressing Enter to login
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }


        private void ShowError(string message, Control focusControl)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl.Focus();
        }
    }
}