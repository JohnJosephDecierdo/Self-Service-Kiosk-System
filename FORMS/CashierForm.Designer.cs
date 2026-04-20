namespace OOP_FINAL_PROJECT
{
    partial class CashierForm
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

            // Tab 1 — Active
            this.tabActive          = new System.Windows.Forms.TabPage();

            // LEFT: Pending orders
            this.lblPendingHeader   = new System.Windows.Forms.Label();
            this.lblPendingHint     = new System.Windows.Forms.Label();
            this.dgvOrders          = new System.Windows.Forms.DataGridView();
            this.btnEditOrder       = new System.Windows.Forms.Button();
            this.btnRefresh         = new System.Windows.Forms.Button();

            // RIGHT TOP: Ready orders
            this.lblReadyHeader     = new System.Windows.Forms.Label();
            this.lblReadyHint       = new System.Windows.Forms.Label();
            this.dgvReady           = new System.Windows.Forms.DataGridView();
            this.btnComplete        = new System.Windows.Forms.Button();

            // RIGHT MIDDLE: Order items
            this.lblDetails         = new System.Windows.Forms.Label();
            this.dgvDetails         = new System.Windows.Forms.DataGridView();

            // RIGHT BOTTOM: Payment panel
            this.pnlPay             = new System.Windows.Forms.Panel();
            this.lblPayTitle        = new System.Windows.Forms.Label();
            this.lblTotal           = new System.Windows.Forms.Label();
            this.lblMethod          = new System.Windows.Forms.Label();
            this.cboMethod          = new System.Windows.Forms.ComboBox();
            this.lblAmt             = new System.Windows.Forms.Label();
            this.txtAmountPaid      = new System.Windows.Forms.TextBox();
            this.lblChange          = new System.Windows.Forms.Label();
            this.btnPay             = new System.Windows.Forms.Button();

            // Tab 2 — Completed
            this.tabCompleted       = new System.Windows.Forms.TabPage();
            this.lblCompletedCount  = new System.Windows.Forms.Label();
            this.dgvCompleted       = new System.Windows.Forms.DataGridView();
            this.btnViewReceipt     = new System.Windows.Forms.Button();
            this.btnRefreshCompleted= new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabActive.SuspendLayout();
            this.tabCompleted.SuspendLayout();
            this.pnlPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            this.SuspendLayout();


            // ── HEADER ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblLive, this.btnLogout });
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;

            this.lblTitle.AutoSize  = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(16, 13);
            this.lblTitle.Text      = "CASHIER DASHBOARD";

            this.lblLive.AutoSize  = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblLive.Location  = new System.Drawing.Point(310, 15);
            this.lblLive.Text      = "● LIVE";

            this.btnLogout.BackColor           = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor           = System.Drawing.Color.White;
            this.btnLogout.Location            = new System.Drawing.Point(1080, 10);
            this.btnLogout.Size                = new System.Drawing.Size(75, 28);
            this.btnLogout.Text                = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click              += new System.EventHandler(this.btnLogout_Click);

            // ── TAB CONTROL ───────────────────────────────────
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabActive, this.tabCompleted });
            this.tabControl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(5, 55);
            this.tabControl.Size     = new System.Drawing.Size(1165, 660);

            // ── TAB 1: ACTIVE ORDERS ──────────────────────────
            this.tabActive.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.tabActive.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPendingHeader, this.lblPendingHint, this.dgvOrders,
                this.btnEditOrder, this.btnRefresh,
                this.lblReadyHeader, this.lblReadyHint, this.dgvReady, this.btnComplete,
                this.lblDetails, this.dgvDetails, this.pnlPay
            });
            this.tabActive.Text = "💳  Active Orders";

            // ════════════════════════════════════
            //  LEFT COLUMN — PENDING (Pay here)
            //  X=5, Width=370
            // ════════════════════════════════════
            this.lblPendingHeader.AutoSize  = false;
            this.lblPendingHeader.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblPendingHeader.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingHeader.ForeColor = System.Drawing.Color.White;
            this.lblPendingHeader.Location  = new System.Drawing.Point(5, 5);
            this.lblPendingHeader.Size      = new System.Drawing.Size(370, 32);
            this.lblPendingHeader.Text      = "💳  PENDING  —  Collect Payment";
            this.lblPendingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPendingHint.AutoSize  = true;
            this.lblPendingHint.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPendingHint.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblPendingHint.Location  = new System.Drawing.Point(5, 40);
            this.lblPendingHint.Text      = "Select order → enter amount paid → Confirm Payment";

            this.dgvOrders.AllowUserToAddRows    = false;
            this.dgvOrders.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor       = System.Drawing.Color.White;
            this.dgvOrders.Location              = new System.Drawing.Point(5, 60);
            this.dgvOrders.ReadOnly              = true;
            this.dgvOrders.RowHeadersVisible     = false;
            this.dgvOrders.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size                  = new System.Drawing.Size(370, 490);
            this.dgvOrders.SelectionChanged     += new System.EventHandler(this.dgvOrders_SelectionChanged);
            StyleGrid(this.dgvOrders);

            this.btnRefresh.BackColor            = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font                 = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor            = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.Location             = new System.Drawing.Point(5, 557);
            this.btnRefresh.Size                 = new System.Drawing.Size(178, 32);
            this.btnRefresh.Text                 = "↺ Refresh";
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.Click               += new System.EventHandler(this.btnRefresh_Click);

            this.btnEditOrder.BackColor          = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnEditOrder.FlatStyle          = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font               = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.ForeColor          = System.Drawing.Color.White;
            this.btnEditOrder.Location           = new System.Drawing.Point(191, 557);
            this.btnEditOrder.Size               = new System.Drawing.Size(184, 32);
            this.btnEditOrder.Text               = "✎ Edit Order (PIN)";
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.Click             += new System.EventHandler(this.btnEditOrder_Click);


            // ════════════════════════════════════
            //  MIDDLE COLUMN — READY (Collect)
            //  X=385, Width=340
            // ════════════════════════════════════
            this.lblReadyHeader.AutoSize  = false;
            this.lblReadyHeader.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblReadyHeader.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReadyHeader.ForeColor = System.Drawing.Color.White;
            this.lblReadyHeader.Location  = new System.Drawing.Point(385, 5);
            this.lblReadyHeader.Size      = new System.Drawing.Size(340, 32);
            this.lblReadyHeader.Text      = "✔  READY  —  Customer Collects";
            this.lblReadyHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblReadyHint.AutoSize  = true;
            this.lblReadyHint.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReadyHint.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblReadyHint.Location  = new System.Drawing.Point(385, 40);
            this.lblReadyHint.Text      = "Select order → Mark Completed after customer collects";

            this.dgvReady.AllowUserToAddRows    = false;
            this.dgvReady.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReady.BackgroundColor       = System.Drawing.Color.FromArgb(240, 255, 244);
            this.dgvReady.Location              = new System.Drawing.Point(385, 60);
            this.dgvReady.ReadOnly              = true;
            this.dgvReady.RowHeadersVisible     = false;
            this.dgvReady.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReady.Size                  = new System.Drawing.Size(340, 490);
            this.dgvReady.SelectionChanged     += new System.EventHandler(this.dgvReady_SelectionChanged);
            StyleGrid(this.dgvReady);
            this.dgvReady.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvReady.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            this.btnComplete.BackColor           = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnComplete.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font                = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor           = System.Drawing.Color.White;
            this.btnComplete.Location            = new System.Drawing.Point(385, 557);
            this.btnComplete.Size                = new System.Drawing.Size(340, 32);
            this.btnComplete.Text                = "✔  Mark Completed";
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.Click              += new System.EventHandler(this.btnComplete_Click);

            // ════════════════════════════════════
            //  RIGHT COLUMN — Order Items + Payment
            //  X=735, Width=415
            // ════════════════════════════════════
            this.lblDetails.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblDetails.Location  = new System.Drawing.Point(735, 8);
            this.lblDetails.Size      = new System.Drawing.Size(415, 20);
            this.lblDetails.Text      = "Order Items";

            this.dgvDetails.AllowUserToAddRows    = false;
            this.dgvDetails.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor       = System.Drawing.Color.White;
            this.dgvDetails.Location              = new System.Drawing.Point(735, 30);
            this.dgvDetails.ReadOnly              = true;
            this.dgvDetails.RowHeadersVisible     = false;
            this.dgvDetails.Size                  = new System.Drawing.Size(415, 180);
            StyleGrid(this.dgvDetails);

            // ── Payment Panel ─────────────────────────────────
            this.pnlPay.BackColor   = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPay.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPayTitle, this.lblTotal,
                this.lblMethod, this.cboMethod,
                this.lblAmt, this.txtAmountPaid,
                this.lblChange, this.btnPay
            });
            this.pnlPay.Location = new System.Drawing.Point(735, 220);
            this.pnlPay.Size     = new System.Drawing.Size(415, 370);

            this.lblPayTitle.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPayTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblPayTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPayTitle.Location  = new System.Drawing.Point(10, 12);
            this.lblPayTitle.Size      = new System.Drawing.Size(393, 26);
            this.lblPayTitle.Text      = "PAYMENT";
            this.lblPayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location  = new System.Drawing.Point(10, 46);
            this.lblTotal.Size      = new System.Drawing.Size(393, 30);
            this.lblTotal.Text      = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblMethod.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMethod.Location  = new System.Drawing.Point(10, 92);
            this.lblMethod.Size      = new System.Drawing.Size(80, 23);
            this.lblMethod.Text      = "Method:";

            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card" });
            this.cboMethod.Location      = new System.Drawing.Point(100, 89);
            this.cboMethod.Size          = new System.Drawing.Size(140, 26);
            this.cboMethod.SelectedIndex = 0;

            this.lblAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblAmt.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmt.Location  = new System.Drawing.Point(10, 134);
            this.lblAmt.Size      = new System.Drawing.Size(80, 23);
            this.lblAmt.Text      = "Paid: ₱";

            this.txtAmountPaid.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountPaid.Location  = new System.Drawing.Point(100, 131);
            this.txtAmountPaid.MaxLength = 10;
            this.txtAmountPaid.Size      = new System.Drawing.Size(140, 26);
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            this.txtAmountPaid.KeyPress   += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);

            this.lblChange.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Location  = new System.Drawing.Point(10, 172);
            this.lblChange.Size      = new System.Drawing.Size(393, 28);
            this.lblChange.Text      = "Change: ₱0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnPay.BackColor          = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPay.FlatStyle          = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font               = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor          = System.Drawing.Color.White;
            this.btnPay.Location           = new System.Drawing.Point(10, 215);
            this.btnPay.Size               = new System.Drawing.Size(393, 52);
            this.btnPay.Text               = "CONFIRM PAYMENT";
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.Click             += new System.EventHandler(this.btnPay_Click);


            // ── TAB 2: COMPLETED ORDERS ───────────────────────
            this.tabCompleted.BackColor = System.Drawing.Color.White;
            this.tabCompleted.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCompletedCount, this.dgvCompleted,
                this.btnViewReceipt, this.btnRefreshCompleted });
            this.tabCompleted.Text = "✅  Completed Orders";

            this.lblCompletedCount.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompletedCount.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblCompletedCount.Location  = new System.Drawing.Point(5, 8);
            this.lblCompletedCount.Size      = new System.Drawing.Size(400, 20);
            this.lblCompletedCount.Text      = "Total completed: 0 orders";

            this.dgvCompleted.AllowUserToAddRows    = false;
            this.dgvCompleted.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompleted.BackgroundColor       = System.Drawing.Color.White;
            this.dgvCompleted.Location              = new System.Drawing.Point(5, 30);
            this.dgvCompleted.ReadOnly              = true;
            this.dgvCompleted.RowHeadersVisible     = false;
            this.dgvCompleted.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompleted.Size                  = new System.Drawing.Size(1145, 560);
            StyleGrid(this.dgvCompleted);

            this.btnViewReceipt.BackColor           = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnViewReceipt.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReceipt.Font                = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewReceipt.ForeColor           = System.Drawing.Color.White;
            this.btnViewReceipt.Location            = new System.Drawing.Point(5, 598);
            this.btnViewReceipt.Size                = new System.Drawing.Size(565, 40);
            this.btnViewReceipt.Text                = "🧾  View / Reprint Receipt";
            this.btnViewReceipt.FlatAppearance.BorderSize = 0;
            this.btnViewReceipt.Click              += new System.EventHandler(this.btnViewReceipt_Click);

            this.btnRefreshCompleted.BackColor      = System.Drawing.Color.White;
            this.btnRefreshCompleted.FlatStyle      = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCompleted.Font           = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefreshCompleted.ForeColor      = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshCompleted.Location       = new System.Drawing.Point(580, 598);
            this.btnRefreshCompleted.Size           = new System.Drawing.Size(570, 40);
            this.btnRefreshCompleted.Text           = "↺ Refresh";
            this.btnRefreshCompleted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshCompleted.Click         += new System.EventHandler(this.btnRefreshCompleted_Click);

            // ── FORM ──────────────────────────────────────────
            this.BackColor     = System.Drawing.Color.White;
            this.ClientSize    = new System.Drawing.Size(1175, 730);
            this.MinimumSize   = new System.Drawing.Size(1175, 730);
            this.Name          = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text          = "Cashier — Process Payment";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.tabControl });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabActive.ResumeLayout(false);
            this.tabCompleted.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            this.ResumeLayout(false);
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor  = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.DefaultCellStyle.SelectionForeColor  = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor     = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        // ── Declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Label    lblLive;
        private System.Windows.Forms.Button   btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage  tabActive;
        private System.Windows.Forms.Label    lblPendingHeader;
        private System.Windows.Forms.Label    lblPendingHint;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button   btnRefresh;
        private System.Windows.Forms.Button   btnEditOrder;
        private System.Windows.Forms.Label    lblReadyHeader;
        private System.Windows.Forms.Label    lblReadyHint;
        private System.Windows.Forms.DataGridView dgvReady;
        private System.Windows.Forms.Button   btnComplete;
        private System.Windows.Forms.Label    lblDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel    pnlPay;
        private System.Windows.Forms.Label    lblPayTitle;
        private System.Windows.Forms.Label    lblTotal;
        private System.Windows.Forms.Label    lblMethod;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label    lblAmt;
        private System.Windows.Forms.TextBox  txtAmountPaid;
        private System.Windows.Forms.Label    lblChange;
        private System.Windows.Forms.Button   btnPay;
        private System.Windows.Forms.TabPage  tabCompleted;
        private System.Windows.Forms.Label    lblCompletedCount;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Button   btnViewReceipt;
        private System.Windows.Forms.Button   btnRefreshCompleted;
    }
}
