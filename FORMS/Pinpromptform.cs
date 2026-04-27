using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class PINPromptForm : Form
    {
        private SettingsRepository _settingsRepo = new SettingsRepository();
        private int _attemptsLeft = 3;

        public PINPromptForm()
        {
            InitializeComponent();
            // Prevent txtPIN from stealing focus when clicked
            txtPIN.GotFocus += (s, e) => this.ActiveControl = null;
            txtPIN.Click += (s, e) => this.ActiveControl = null;
        }

        private void btnPIN_Click(object sender, EventArgs e)
        {
            string digit = ((Button)sender).Text;
            if (txtPIN.Text.Length < 4)
                txtPIN.Text += digit;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            txtPIN.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            lblAttempts.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPIN.Text))
            {
                MessageBox.Show("Please enter the PIN.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_settingsRepo.ValidatePIN(txtPIN.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _attemptsLeft--;
                txtPIN.Text = "";
                txtPIN.BackColor = Color.FromArgb(255, 220, 220);
                lblAttempts.Text = $"Incorrect PIN. {_attemptsLeft} attempt{(_attemptsLeft != 1 ? "s" : "")} remaining.";
                lblAttempts.Visible = true;

                if (_attemptsLeft <= 0)
                {
                    MessageBox.Show("Too many incorrect attempts. Access denied.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length > 0)
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1);
            txtPIN.BackColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Allow keyboard input too
        private void PINPromptForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txtPIN.Text.Length < 4)
                txtPIN.Text += e.KeyChar;
            else if (e.KeyChar == (char)Keys.Back)
                btnBackspace_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Enter)
                btnConfirm_Click(sender, e);
        }
    }
}