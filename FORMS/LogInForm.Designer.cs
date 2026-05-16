namespace OOP_FINAL_PROJECT
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblTagline = new Label();
            pnlForm = new Panel();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblHint = new Label();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(13, 71, 161);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(400, 97);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(0, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(262, 41);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "DECIERDO KIOSK";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 9F);
            lblTagline.ForeColor = Color.FromArgb(144, 202, 249);
            lblTagline.Location = new Point(12, 59);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(159, 15);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Self-Service Ordering System";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(lblHint);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(40, 20, 40, 20);
            pnlForm.Size = new Size(400, 380);
            pnlForm.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(13, 71, 161);
            lblTitle.Location = new Point(40, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign In";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(33, 33, 33);
            lblUsername.Location = new Point(37, 122);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(37, 157);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(33, 33, 33);
            lblPassword.Location = new Point(37, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(37, 221);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 111, 0);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(37, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 8F);
            lblHint.ForeColor = Color.FromArgb(117, 117, 117);
            lblHint.Location = new Point(37, 324);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(320, 18);
            lblHint.TabIndex = 6;
            lblHint.Text = "Press Enter to sign in";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 380);
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Decierdo Kiosk — Sign In";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHint;
    }
}