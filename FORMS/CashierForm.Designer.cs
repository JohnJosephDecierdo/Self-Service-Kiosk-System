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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            // Tab 1
            this.tabActive = new System.Windows.Forms.TabPage();
            this.lblOrders = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.lblPayTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            // Tab 2
            this.tabCompleted = new System.Windows.Forms.TabPage();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.dgvCompleted = new System.Windows.Forms.DataGridView();
            this.btnViewReceipt = new System.Windows.Forms.Button();
            this.btnRefreshCompleted = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabActive.SuspendLayout();
            this.tabCompleted.SuspendLayout();
            this.pnlPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblLive, this.btnLogout
            });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "CASHIER DASHBOARD";

            this.lblLive.AutoSize = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblLive.Location = new System.Drawing.Point(310, 15);
            this.lblLive.Name = "lblLive";
            this.lblLive.Text = "● LIVE";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(840, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ── tabControl ────────────────────────────────────
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabActive, this.tabCompleted
            });
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(5, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(930, 610);

            // ── Tab 1: Active Orders ──────────────────────────
            this.tabActive.BackColor = System.Drawing.Color.White;
            this.tabActive.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOrders, this.dgvOrders, this.btnRefresh, this.btnEditOrder,
                this.lblDetails, this.dgvDetails, this.pnlPay
            });
            this.tabActive.Name = "tabActive";
            this.tabActive.Text = "💳  Active Orders";

            // dgvOrders
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblOrders.Location = new System.Drawing.Point(5, 8);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(300, 20);
            this.lblOrders.Text = "Pending & Ready Orders";

            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.Location = new System.Drawing.Point(5, 30);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(395, 460);
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            StyleGrid(this.dgvOrders);

            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.Location = new System.Drawing.Point(5, 497);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 32);
            this.btnRefresh.Text = "↺ Refresh";
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(205, 497);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(195, 32);
            this.btnEditOrder.Text = "Edit Order (Manager PIN)";
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);

            // dgvDetails
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblDetails.Location = new System.Drawing.Point(410, 8);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(100, 20);
            this.lblDetails.Text = "Order Items";

            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.Location = new System.Drawing.Point(410, 30);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.Size = new System.Drawing.Size(500, 185);
            StyleGrid(this.dgvDetails);

            // pnlPay
            this.pnlPay.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPay.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPayTitle, this.lblTotal, this.lblMethod, this.cboMethod,
                this.lblAmt, this.txtAmountPaid, this.lblChange, this.btnPay, this.btnComplete
            });
            this.pnlPay.Location = new System.Drawing.Point(410, 225);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(500, 304);

            this.lblPayTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPayTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblPayTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPayTitle.Location = new System.Drawing.Point(10, 12);
            this.lblPayTitle.Name = "lblPayTitle";
            this.lblPayTitle.Size = new System.Drawing.Size(478, 26);
            this.lblPayTitle.Text = "PAYMENT";
            this.lblPayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(10, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(478, 30);
            this.lblTotal.Text = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMethod.Location = new System.Drawing.Point(10, 88);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(80, 23);
            this.lblMethod.Text = "Method:";

            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card" });
            this.cboMethod.Location = new System.Drawing.Point(100, 85);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(140, 26);
            this.cboMethod.SelectedIndex = 0;

            this.lblAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmt.Location = new System.Drawing.Point(10, 130);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(80, 23);
            this.lblAmt.Text = "Paid: ₱";

            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountPaid.Location = new System.Drawing.Point(100, 127);
            this.txtAmountPaid.MaxLength = 10;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(140, 26);
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);

            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Location = new System.Drawing.Point(10, 165);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(478, 28);
            this.lblChange.Text = "Change: ₱0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnPay.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(10, 206);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(480, 48);
            this.btnPay.Text = "CONFIRM PAYMENT";
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);

            this.btnComplete.BackColor = System.Drawing.Color.White;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComplete.ForeColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.btnComplete.Location = new System.Drawing.Point(10, 262);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(480, 32);
            this.btnComplete.Text = "MARK COMPLETED  (Ready orders)";
            this.btnComplete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.btnComplete.FlatAppearance.BorderSize = 1;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);

            // ── Tab 2: Completed Orders ───────────────────────
            this.tabCompleted.BackColor = System.Drawing.Color.White;
            this.tabCompleted.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCompletedCount, this.dgvCompleted,
                this.btnViewReceipt, this.btnRefreshCompleted
            });
            this.tabCompleted.Name = "tabCompleted";
            this.tabCompleted.Text = "✅  Completed Orders";

            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompletedCount.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblCompletedCount.Location = new System.Drawing.Point(5, 8);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(400, 20);
            this.lblCompletedCount.Text = "Total completed: 0 orders";

            this.dgvCompleted.AllowUserToAddRows = false;
            this.dgvCompleted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompleted.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompleted.Location = new System.Drawing.Point(5, 30);
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.ReadOnly = true;
            this.dgvCompleted.RowHeadersVisible = false;
            this.dgvCompleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompleted.Size = new System.Drawing.Size(905, 496);
            StyleGrid(this.dgvCompleted);

            this.btnViewReceipt.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnViewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewReceipt.ForeColor = System.Drawing.Color.White;
            this.btnViewReceipt.Location = new System.Drawing.Point(5, 534);
            this.btnViewReceipt.Name = "btnViewReceipt";
            this.btnViewReceipt.Size = new System.Drawing.Size(445, 40);
            this.btnViewReceipt.Text = "🧾  View / Reprint Receipt";
            this.btnViewReceipt.FlatAppearance.BorderSize = 0;
            this.btnViewReceipt.Click += new System.EventHandler(this.btnViewReceipt_Click);

            this.btnRefreshCompleted.BackColor = System.Drawing.Color.White;
            this.btnRefreshCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCompleted.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefreshCompleted.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshCompleted.Location = new System.Drawing.Point(460, 534);
            this.btnRefreshCompleted.Name = "btnRefreshCompleted";
            this.btnRefreshCompleted.Size = new System.Drawing.Size(450, 40);
            this.btnRefreshCompleted.Text = "↺ Refresh";
            this.btnRefreshCompleted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshCompleted.Click += new System.EventHandler(this.btnRefreshCompleted_Click);

            // ── CashierForm ───────────────────────────────────
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 680);
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cashier — Process Payment";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlHeader, this.tabControl });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabActive.ResumeLayout(false);
            this.tabCompleted.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            this.ResumeLayout(false);
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabActive;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Label lblPayTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TabPage tabCompleted;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.Button btnRefreshCompleted;
    }
}