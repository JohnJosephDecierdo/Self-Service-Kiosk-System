namespace OOP_FINAL_PROJECT
{
    partial class CookForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.lblTitle           = new System.Windows.Forms.Label();
            this.lblLive            = new System.Windows.Forms.Label();
            this.btnLogout          = new System.Windows.Forms.Button();
            this.tabControl         = new System.Windows.Forms.TabControl();

            // Tab 1 — Orders
            this.tabOrders          = new System.Windows.Forms.TabPage();
            this.lblSub             = new System.Windows.Forms.Label();
            this.dgvOrders          = new System.Windows.Forms.DataGridView();
            this.lblItems           = new System.Windows.Forms.Label();
            this.dgvDetails         = new System.Windows.Forms.DataGridView();
            this.btnPreparing       = new System.Windows.Forms.Button();
            this.btnReady           = new System.Windows.Forms.Button();
            this.btnRefresh         = new System.Windows.Forms.Button();

            // Tab 2 — Menu Availability
            this.tabAvailability    = new System.Windows.Forms.TabPage();
            this.pnlAvailTop        = new System.Windows.Forms.Panel();
            this.lblAvailTitle      = new System.Windows.Forms.Label();
            this.lblAvailHint       = new System.Windows.Forms.Label();
            this.btnMarkUnavailable = new System.Windows.Forms.Button();
            this.btnMarkAvailable   = new System.Windows.Forms.Button();
            this.btnRefreshMenu     = new System.Windows.Forms.Button();
            this.dgvMenu            = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabAvailability.SuspendLayout();
            this.pnlAvailTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();

            // ── HEADER ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblLive, this.btnLogout });
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;

            this.lblTitle.AutoSize  = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(16, 12);
            this.lblTitle.Text      = "KITCHEN ORDER QUEUE";

            this.lblLive.AutoSize  = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblLive.Location  = new System.Drawing.Point(300, 15);
            this.lblLive.Text      = "● LIVE";

            this.btnLogout.BackColor           = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor           = System.Drawing.Color.White;
            this.btnLogout.Location            = new System.Drawing.Point(790, 10);
            this.btnLogout.Size                = new System.Drawing.Size(75, 28);
            this.btnLogout.Text                = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click              += new System.EventHandler(this.btnLogout_Click);

            // ── TAB CONTROL ───────────────────────────────────
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabOrders, this.tabAvailability });
            this.tabControl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 48);
            this.tabControl.Size     = new System.Drawing.Size(880, 620);

            // ── TAB 1: ORDERS ─────────────────────────────────
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.tabOrders.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSub, this.dgvOrders, this.lblItems, this.dgvDetails,
                this.btnPreparing, this.btnReady, this.btnRefresh });
            this.tabOrders.Text = "  🍳  Kitchen Queue  ";

            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.lblSub.Location  = new System.Drawing.Point(10, 10);
            this.lblSub.Size      = new System.Drawing.Size(858, 20);
            this.lblSub.Text      = "Showing: Paid & Preparing orders";

            this.dgvOrders.AllowUserToAddRows  = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.Location            = new System.Drawing.Point(10, 34);
            this.dgvOrders.ReadOnly            = true;
            this.dgvOrders.RowHeadersVisible   = false;
            this.dgvOrders.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size                = new System.Drawing.Size(858, 230);
            this.dgvOrders.SelectionChanged   += new System.EventHandler(this.dgvOrders_SelectionChanged);

            this.lblItems.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblItems.Location  = new System.Drawing.Point(10, 274);
            this.lblItems.Size      = new System.Drawing.Size(200, 20);
            this.lblItems.Text      = "Order Items";

            this.dgvDetails.AllowUserToAddRows  = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.Location            = new System.Drawing.Point(10, 296);
            this.dgvDetails.ReadOnly            = true;
            this.dgvDetails.RowHeadersVisible   = false;
            this.dgvDetails.Size                = new System.Drawing.Size(858, 180);

            this.btnPreparing.BackColor           = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPreparing.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparing.Font                = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPreparing.ForeColor           = System.Drawing.Color.White;
            this.btnPreparing.Location            = new System.Drawing.Point(10, 490);
            this.btnPreparing.Size                = new System.Drawing.Size(270, 52);
            this.btnPreparing.Text                = "Mark: PREPARING";
            this.btnPreparing.FlatAppearance.BorderSize = 0;
            this.btnPreparing.Click              += new System.EventHandler(this.btnPreparing_Click);

            this.btnReady.BackColor           = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnReady.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font                = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReady.ForeColor           = System.Drawing.Color.White;
            this.btnReady.Location            = new System.Drawing.Point(295, 490);
            this.btnReady.Size                = new System.Drawing.Size(270, 52);
            this.btnReady.Text                = "Mark: READY";
            this.btnReady.FlatAppearance.BorderSize = 0;
            this.btnReady.Click              += new System.EventHandler(this.btnReady_Click);

            this.btnRefresh.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor  = System.Drawing.Color.FromArgb(100, 100, 120);
            this.btnRefresh.Location   = new System.Drawing.Point(580, 490);
            this.btnRefresh.Size       = new System.Drawing.Size(288, 52);
            this.btnRefresh.Text       = "↺  Refresh Orders";
            this.btnRefresh.Click     += new System.EventHandler(this.btnRefresh_Click);

            // ── TAB 2: MENU AVAILABILITY ──────────────────────
            this.tabAvailability.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabAvailability.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlAvailTop, this.dgvMenu });
            this.tabAvailability.Text = "  🔴  Menu Availability  ";

            this.pnlAvailTop.BackColor   = System.Drawing.Color.White;
            this.pnlAvailTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAvailTitle, this.lblAvailHint,
                this.btnMarkUnavailable, this.btnMarkAvailable, this.btnRefreshMenu });
            this.pnlAvailTop.Location = new System.Drawing.Point(10, 10);
            this.pnlAvailTop.Size     = new System.Drawing.Size(858, 70);

            this.lblAvailTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblAvailTitle.Location  = new System.Drawing.Point(12, 8);
            this.lblAvailTitle.AutoSize  = true;
            this.lblAvailTitle.Text      = "Menu Availability  —  Mark items as Sold Out or Available";

            this.lblAvailHint.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblAvailHint.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblAvailHint.Location  = new System.Drawing.Point(12, 32);
            this.lblAvailHint.AutoSize  = true;
            this.lblAvailHint.Text      = "Red rows = currently unavailable. Customer menu will reflect changes instantly.";

            this.btnMarkUnavailable.BackColor           = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnMarkUnavailable.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkUnavailable.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkUnavailable.ForeColor           = System.Drawing.Color.White;
            this.btnMarkUnavailable.Location            = new System.Drawing.Point(490, 18);
            this.btnMarkUnavailable.Size                = new System.Drawing.Size(150, 32);
            this.btnMarkUnavailable.Text                = "🔴  Mark Sold Out";
            this.btnMarkUnavailable.FlatAppearance.BorderSize = 0;
            this.btnMarkUnavailable.Click              += new System.EventHandler(this.btnMarkUnavailable_Click);

            this.btnMarkAvailable.BackColor           = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnMarkAvailable.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAvailable.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkAvailable.ForeColor           = System.Drawing.Color.White;
            this.btnMarkAvailable.Location            = new System.Drawing.Point(650, 18);
            this.btnMarkAvailable.Size                = new System.Drawing.Size(150, 32);
            this.btnMarkAvailable.Text                = "🟢  Mark Available";
            this.btnMarkAvailable.FlatAppearance.BorderSize = 0;
            this.btnMarkAvailable.Click              += new System.EventHandler(this.btnMarkAvailable_Click);

            this.btnRefreshMenu.BackColor           = System.Drawing.Color.White;
            this.btnRefreshMenu.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshMenu.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshMenu.ForeColor           = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshMenu.Location            = new System.Drawing.Point(808, 18);
            this.btnRefreshMenu.Size                = new System.Drawing.Size(40, 32);
            this.btnRefreshMenu.Text                = "↺";
            this.btnRefreshMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshMenu.Click              += new System.EventHandler(this.btnRefreshMenu_Click);

            this.dgvMenu.AllowUserToAddRows  = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor     = System.Drawing.Color.White;
            this.dgvMenu.Location            = new System.Drawing.Point(10, 88);
            this.dgvMenu.ReadOnly            = true;
            this.dgvMenu.RowHeadersVisible   = false;
            this.dgvMenu.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.MultiSelect         = false;
            this.dgvMenu.Size                = new System.Drawing.Size(858, 510);
            this.dgvMenu.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.dgvMenu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.dgvMenu.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMenu.EnableHeadersVisualStyles = false;

            // ── FORM ──────────────────────────────────────────
            this.BackColor     = System.Drawing.Color.White;
            this.ClientSize    = new System.Drawing.Size(880, 680);
            this.MinimumSize   = new System.Drawing.Size(880, 680);
            this.Name          = "CookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text          = "Cook — Kitchen Queue";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlHeader, this.tabControl });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabAvailability.ResumeLayout(false);
            this.pnlAvailTop.ResumeLayout(false);
            this.pnlAvailTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel         pnlHeader;
        private System.Windows.Forms.Label         lblTitle;
        private System.Windows.Forms.Label         lblLive;
        private System.Windows.Forms.Button        btnLogout;
        private System.Windows.Forms.TabControl    tabControl;
        private System.Windows.Forms.TabPage       tabOrders;
        private System.Windows.Forms.Label         lblSub;
        private System.Windows.Forms.DataGridView  dgvOrders;
        private System.Windows.Forms.Label         lblItems;
        private System.Windows.Forms.DataGridView  dgvDetails;
        private System.Windows.Forms.Button        btnPreparing;
        private System.Windows.Forms.Button        btnReady;
        private System.Windows.Forms.Button        btnRefresh;
        private System.Windows.Forms.TabPage       tabAvailability;
        private System.Windows.Forms.Panel         pnlAvailTop;
        private System.Windows.Forms.Label         lblAvailTitle;
        private System.Windows.Forms.Label         lblAvailHint;
        private System.Windows.Forms.Button        btnMarkUnavailable;
        private System.Windows.Forms.Button        btnMarkAvailable;
        private System.Windows.Forms.Button        btnRefreshMenu;
        private System.Windows.Forms.DataGridView  dgvMenu;
    }
}
