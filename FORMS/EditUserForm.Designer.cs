namespace OOP_FINAL_PROJECT
{
    partial class EditUserForm
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
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblPasswordSection = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle
            });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Edit User";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Update username, role, or password";

            // ── lblCurrentUser ────────────────────────────────
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(235, 245, 255);
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblCurrentUser.Location = new System.Drawing.Point(0, 70);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(440, 28);
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentUser.Text = "Editing: ...";

            // ── Username ──────────────────────────────────────
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(30, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.Text = "Username *";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(30, 134);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 26);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);

            this.lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblUsernameHint.Location = new System.Drawing.Point(30, 163);
            this.lblUsernameHint.Name = "lblUsernameHint";
            this.lblUsernameHint.Size = new System.Drawing.Size(380, 18);
            this.lblUsernameHint.Text = "Min 3 characters. Letters, numbers and underscores only.";

            // ── Role ──────────────────────────────────────────
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(30, 192);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(50, 20);
            this.lblRole.Text = "Role *";

            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.Items.AddRange(new object[] { "Customer", "Cashier", "Cook", "Manager", "Owner" });
            this.cboRole.Location = new System.Drawing.Point(30, 214);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(380, 26);
            this.cboRole.SelectedIndex = 0;

            // ── Divider ───────────────────────────────────────
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlDivider.Location = new System.Drawing.Point(30, 258);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(380, 1);

            // ── Password section ──────────────────────────────
            this.lblPasswordSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordSection.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPasswordSection.Location = new System.Drawing.Point(30, 272);
            this.lblPasswordSection.Name = "lblPasswordSection";
            this.lblPasswordSection.Size = new System.Drawing.Size(200, 20);
            this.lblPasswordSection.Text = "Change Password";

            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblPasswordHint.Location = new System.Drawing.Point(30, 293);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(380, 18);
            this.lblPasswordHint.Text = "Leave blank to keep current password.";

            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.Location = new System.Drawing.Point(30, 322);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(120, 20);
            this.lblNewPassword.Text = "New Password";

            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(30, 344);
            this.txtNewPassword.MaxLength = 100;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(380, 26);
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);

            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 382);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(150, 20);
            this.lblConfirmPassword.Text = "Confirm Password";

            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 404);
            this.txtConfirmPassword.MaxLength = 100;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 26);
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);

            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.chkShowPassword.Location = new System.Drawing.Point(30, 438);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // ── Buttons ───────────────────────────────────────
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(380, 44);
            this.btnSave.Text = "Save Changes";
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.Location = new System.Drawing.Point(30, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(380, 32);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ── EditUserForm ──────────────────────────────────
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.lblCurrentUser,
                this.lblUsername, this.txtUsername, this.lblUsernameHint,
                this.lblRole, this.cboRole,
                this.pnlDivider,
                this.lblPasswordSection, this.lblPasswordHint,
                this.lblNewPassword, this.txtNewPassword,
                this.lblConfirmPassword, this.txtConfirmPassword,
                this.chkShowPassword,
                this.btnSave, this.btnCancel
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblPasswordSection;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}