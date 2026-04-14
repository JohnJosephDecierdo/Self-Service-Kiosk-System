namespace OOP_FINAL_PROJECT
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.pnlAccentLine = new System.Windows.Forms.Panel();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnCook = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnKDS = new System.Windows.Forms.Button();
            this.lblSessionsTitle = new System.Windows.Forms.Label();
            this.pnlSessions = new System.Windows.Forms.Panel();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.lblCashierStatus = new System.Windows.Forms.Label();
            this.lblCookStatus = new System.Windows.Forms.Label();
            this.lblManagerStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTag1 = new System.Windows.Forms.Label();
            this.lblTag2 = new System.Windows.Forms.Label();
            this.lblTag3 = new System.Windows.Forms.Label();
            this.lblTag4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlSessions.SuspendLayout();
            this.SuspendLayout();

            // pnlLeft — Dark Blue
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlLeft.Controls.AddRange(new System.Windows.Forms.Control[] { this.picLogo, this.lblBrandName, this.lblTagline });
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(400, 660);

            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(50, 100);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 300);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Location = new System.Drawing.Point(0, 430);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(400, 45);
            this.lblBrandName.Text = "DECIERDO KIOSK";
            this.lblBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Location = new System.Drawing.Point(0, 478);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(400, 28);
            this.lblTagline.Text = "SELF-SERVICE ORDERING SYSTEM";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlRight — White
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlTopBar, this.lblMain, this.pnlAccentLine, this.lblSub,
                this.lblRoles, this.btnCustomer, this.btnCashier, this.btnCook, this.btnManager,
                this.btnKDS, this.lblSessionsTitle, this.pnlSessions,
                this.btnStart, this.lblTag1, this.lblTag2, this.lblTag3, this.lblTag4, this.lblVersion
            });
            this.pnlRight.Location = new System.Drawing.Point(400, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(580, 660);

            // pnlTopBar — Blue
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.pnlTopBar.Controls.Add(this.lblWelcome);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 48;
            this.pnlTopBar.Name = "pnlTopBar";

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(30, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome! Place your order below.";

            // lblMain
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Location = new System.Drawing.Point(30, 62);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(520, 95);
            this.lblMain.Text = "Order Your\nMeal Here";

            // pnlAccentLine — Orange
            this.pnlAccentLine.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.pnlAccentLine.Location = new System.Drawing.Point(30, 162);
            this.pnlAccentLine.Name = "pnlAccentLine";
            this.pnlAccentLine.Size = new System.Drawing.Size(60, 4);

            // lblSub
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Location = new System.Drawing.Point(30, 178);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(520, 36);
            this.lblSub.Text = "Fast, easy and contactless ordering for a better dining experience.";

            // lblRoles
            this.lblRoles.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoles.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblRoles.BackColor = System.Drawing.Color.Transparent;
            this.lblRoles.Location = new System.Drawing.Point(30, 228);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.AutoSize = true;
            this.lblRoles.Text = "OPEN ROLE WINDOW";

            // Role buttons — Blue outline style
            SetupRoleBtn(this.btnCustomer, "Customer", 30, 248, new System.EventHandler(this.btnCustomer_Click)); this.btnCustomer.Text = "👤 Customer";
            SetupRoleBtn(this.btnCashier, "Cashier", 170, 248, new System.EventHandler(this.btnCashier_Click)); this.btnCashier.Text = "💳 Cashier";
            SetupRoleBtn(this.btnCook, "Cook", 310, 248, new System.EventHandler(this.btnCook_Click)); this.btnCook.Text = "👨‍🍳 Cook";
            SetupRoleBtn(this.btnManager, "Manager", 450, 248, new System.EventHandler(this.btnManager_Click)); this.btnManager.Text = "⚙ Manager";

            // btnKDS — Orange outline
            this.btnKDS.BackColor = System.Drawing.Color.White;
            this.btnKDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKDS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKDS.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnKDS.Location = new System.Drawing.Point(30, 308);
            this.btnKDS.Name = "btnKDS";
            this.btnKDS.Size = new System.Drawing.Size(520, 36);
            this.btnKDS.Text = "Order Status Board (KDS)";
            this.btnKDS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnKDS.FlatAppearance.BorderSize = 2;
            this.btnKDS.Click += new System.EventHandler(this.btnKDS_Click);

            // pnlSessions — Light Blue background
            this.lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblSessionsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSessionsTitle.Location = new System.Drawing.Point(30, 358);
            this.lblSessionsTitle.Name = "lblSessionsTitle";
            this.lblSessionsTitle.AutoSize = true;
            this.lblSessionsTitle.Text = "ACTIVE SESSIONS";

            this.pnlSessions.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlSessions.Location = new System.Drawing.Point(30, 378);
            this.pnlSessions.Name = "pnlSessions";
            this.pnlSessions.Size = new System.Drawing.Size(520, 102);
            this.pnlSessions.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCustomerStatus, this.lblCashierStatus, this.lblCookStatus, this.lblManagerStatus
            });

            SetupSessionLbl(this.lblCustomerStatus, "● Customer  —  Not active", 8);
            SetupSessionLbl(this.lblCashierStatus, "● Cashier   —  Not active", 30);
            SetupSessionLbl(this.lblCookStatus, "● Cook      —  Not active", 52);
            SetupSessionLbl(this.lblManagerStatus, "● Manager   —  Not active", 74);

            // btnStart — Orange filled CTA
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(30, 494);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(520, 52);
            this.btnStart.Text = "START ORDER  →";
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // Feature tags
            SetupTag(this.lblTag1, "⚡ Real-time", 30, 562);
            SetupTag(this.lblTag2, "🔗 Multi-window", 155, 562);
            SetupTag(this.lblTag3, "🔒 Role-based", 300, 562);
            SetupTag(this.lblTag4, "📋 Live tracking", 420, 562);

            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.lblVersion.Location = new System.Drawing.Point(510, 638);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "v2.0";

            // HomeForm
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decierdo Kiosk";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlLeft, this.pnlRight });

            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlSessions.ResumeLayout(false);
            this.pnlSessions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupRoleBtn(System.Windows.Forms.Button btn, string text, int left, int top, System.EventHandler handler)
        {
            btn.BackColor = System.Drawing.Color.White;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            btn.Location = new System.Drawing.Point(left, top);
            btn.Name = "btn" + text;
            btn.Size = new System.Drawing.Size(128, 48);
            btn.Text = text;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btn.FlatAppearance.BorderSize = 2;
            btn.Click += handler;
        }

        private void SetupSessionLbl(System.Windows.Forms.Label lbl, string text, int top)
        {
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            lbl.Location = new System.Drawing.Point(10, top);
            lbl.Size = new System.Drawing.Size(500, 20);
            lbl.Text = text;
        }

        private void SetupTag(System.Windows.Forms.Label lbl, string text, int left, int top)
        {
            lbl.AutoSize = true;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Text = text;
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel pnlAccentLine;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnCook;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnKDS;
        private System.Windows.Forms.Label lblSessionsTitle;
        private System.Windows.Forms.Panel pnlSessions;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblCashierStatus;
        private System.Windows.Forms.Label lblCookStatus;
        private System.Windows.Forms.Label lblManagerStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTag1;
        private System.Windows.Forms.Label lblTag2;
        private System.Windows.Forms.Label lblTag3;
        private System.Windows.Forms.Label lblTag4;
        private System.Windows.Forms.Label lblVersion;
    }
}