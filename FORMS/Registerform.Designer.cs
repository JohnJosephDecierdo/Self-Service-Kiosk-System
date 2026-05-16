namespace OOP_FINAL_PROJECT
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblStrengthLabel = new System.Windows.Forms.Label();
            this.pnlStrengthBg = new System.Windows.Forms.Panel();
            this.pnlStrengthBar = new System.Windows.Forms.Panel();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlStrengthBg.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSubtitle });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Create Account";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Fill in the details below to register a new account";

            // ── Username ──────────────────────────────────────
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(30, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.Text = "Username *";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(30, 112);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 26);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);

            this.lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblUsernameHint.Location = new System.Drawing.Point(30, 141);
            this.lblUsernameHint.Name = "lblUsernameHint";
            this.lblUsernameHint.Size = new System.Drawing.Size(380, 18);
            this.lblUsernameHint.Text = "Min 3 characters. Letters, numbers and underscores only.";

            // ── Password ──────────────────────────────────────
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(30, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.Text = "Password *";

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(30, 192);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 26);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblPasswordHint.Location = new System.Drawing.Point(30, 221);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(380, 18);
            this.lblPasswordHint.Text = "Min 6 characters.";

            // ── Strength bar ──────────────────────────────────
            this.lblStrengthLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStrengthLabel.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblStrengthLabel.Location = new System.Drawing.Point(30, 242);
            this.lblStrengthLabel.Name = "lblStrengthLabel";
            this.lblStrengthLabel.Size = new System.Drawing.Size(80, 16);
            this.lblStrengthLabel.Text = "Strength:";

            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStrength.Location = new System.Drawing.Point(340, 242);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Text = "";

            this.pnlStrengthBg.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlStrengthBg.Controls.Add(this.pnlStrengthBar);
            this.pnlStrengthBg.Location = new System.Drawing.Point(30, 260);
            this.pnlStrengthBg.Name = "pnlStrengthBg";
            this.pnlStrengthBg.Size = new System.Drawing.Size(380, 8);

            this.pnlStrengthBar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlStrengthBar.Location = new System.Drawing.Point(0, 0);
            this.pnlStrengthBar.Name = "pnlStrengthBar";
            this.pnlStrengthBar.Size = new System.Drawing.Size(0, 8);

            // ── Confirm Password ──────────────────────────────
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 280);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(150, 20);
            this.lblConfirmPassword.Text = "Confirm Password *";

            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 302);
            this.txtConfirmPassword.MaxLength = 100;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 26);
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);

            // ── Show password checkbox ────────────────────────
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.chkShowPassword.Location = new System.Drawing.Point(30, 336);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // ── Role ──────────────────────────────────────────
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(30, 368);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(50, 20);
            this.lblRole.Text = "Role *";

            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.Items.AddRange(new object[] { "Customer", "Cashier", "Cook", "Manager" });
            this.cboRole.Location = new System.Drawing.Point(30, 390);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(380, 26);
            this.cboRole.SelectedIndex = 0;

            // ── Buttons ───────────────────────────────────────
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(30, 438);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(380, 44);
            this.btnRegister.Text = "Create Account";
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.Location = new System.Drawing.Point(30, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(380, 32);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ── RegisterForm ──────────────────────────────────
            this.ClientSize = new System.Drawing.Size(440, 545);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader,
                this.lblUsername, this.txtUsername, this.lblUsernameHint,
                this.lblPassword, this.txtPassword, this.lblPasswordHint,
                this.lblStrengthLabel, this.lblStrength, this.pnlStrengthBg,
                this.lblConfirmPassword, this.txtConfirmPassword,
                this.chkShowPassword,
                this.lblRole, this.cboRole,
                this.btnRegister, this.btnCancel
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStrengthBg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblStrengthLabel;
        private System.Windows.Forms.Panel pnlStrengthBg;
        private System.Windows.Forms.Panel pnlStrengthBar;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}