namespace OOP_FINAL_PROJECT
{
    partial class AnalyticsForm
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
            this.lblLastRefresh = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterMode = new System.Windows.Forms.Label();
            this.cmbFilterMode = new System.Windows.Forms.ComboBox();
            this.lblFilterMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblFilterYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblFilterRange = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyRange = new System.Windows.Forms.Button();
            this.pnlTodaySales = new System.Windows.Forms.Panel();
            this.lblTodaySalesLbl = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.pnlTodayOrders = new System.Windows.Forms.Panel();
            this.lblTodayOrdersLbl = new System.Windows.Forms.Label();
            this.lblTodayOrders = new System.Windows.Forms.Label();
            this.pnlRangeSales = new System.Windows.Forms.Panel();
            this.lblRangeSalesLbl = new System.Windows.Forms.Label();
            this.lblRangeSales = new System.Windows.Forms.Label();
            this.pnlRangeOrders = new System.Windows.Forms.Panel();
            this.lblRangeOrdersLbl = new System.Windows.Forms.Label();
            this.lblRangeOrders = new System.Windows.Forms.Label();
            this.pnlAvgOrder = new System.Windows.Forms.Panel();
            this.lblAvgOrderLbl = new System.Windows.Forms.Label();
            this.lblAvgOrder = new System.Windows.Forms.Label();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.lblCustomersLbl = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblStatusChartTitle = new System.Windows.Forms.Label();
            this.pnlStatusChart = new System.Windows.Forms.Panel();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.lblCategoryChartTitle = new System.Windows.Forms.Label();
            this.pnlCategoryChart = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lblTopItemsTitle = new System.Windows.Forms.Label();
            this.dgvTopItems = new System.Windows.Forms.DataGridView();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            // ── Header ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblLastRefresh, this.btnRefresh, this.btnClose
            });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Analytics Dashboard";

            this.lblLastRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lblLastRefresh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLastRefresh.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblLastRefresh.Location = new System.Drawing.Point(280, 20);
            this.lblLastRefresh.Name = "lblLastRefresh";
            this.lblLastRefresh.Size = new System.Drawing.Size(280, 18);
            this.lblLastRefresh.Text = "Last refreshed: --";

            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(920, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "↺ Refresh";
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1020, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.Text = "Close";
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── Filter Bar ────────────────────────────────────
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlFilter.Location = new System.Drawing.Point(0, 55);
            this.pnlFilter.Size = new System.Drawing.Size(1110, 42);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFilterMode, this.cmbFilterMode,
                this.lblFilterMonth, this.cmbMonth,
                this.lblFilterYear,  this.cmbYear,
                this.lblFilterRange,
                this.lblFrom, this.dtpFrom,
                this.lblTo,   this.dtpTo,
                this.btnApplyRange
            });

            this.lblFilterMode.AutoSize = true;
            this.lblFilterMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterMode.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblFilterMode.Location = new System.Drawing.Point(10, 12);
            this.lblFilterMode.Text = "View by:";

            this.cmbFilterMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterMode.Location = new System.Drawing.Point(70, 8);
            this.cmbFilterMode.Size = new System.Drawing.Size(100, 24);
            this.cmbFilterMode.Name = "cmbFilterMode";
            this.cmbFilterMode.Items.AddRange(new object[] { "Monthly", "Yearly", "Custom Range" });
            this.cmbFilterMode.SelectedIndex = 0;
            this.cmbFilterMode.SelectedIndexChanged += new System.EventHandler(this.cmbFilterMode_SelectedIndexChanged);

            this.lblFilterMonth.AutoSize = true;
            this.lblFilterMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterMonth.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblFilterMonth.Location = new System.Drawing.Point(182, 12);
            this.lblFilterMonth.Text = "Month:";

            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMonth.Location = new System.Drawing.Point(232, 8);
            this.cmbMonth.Size = new System.Drawing.Size(110, 24);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Items.AddRange(new object[] {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            });
            this.cmbMonth.SelectedIndex = System.DateTime.Today.Month - 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);

            this.lblFilterYear.AutoSize = true;
            this.lblFilterYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterYear.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblFilterYear.Location = new System.Drawing.Point(354, 12);
            this.lblFilterYear.Text = "Year:";

            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbYear.Location = new System.Drawing.Point(394, 8);
            this.cmbYear.Size = new System.Drawing.Size(80, 24);
            this.cmbYear.Name = "cmbYear";
            int currentYear = System.DateTime.Today.Year;
            this.cmbYear.Items.Add(currentYear - 4);
            this.cmbYear.Items.Add(currentYear - 3);
            this.cmbYear.Items.Add(currentYear - 2);
            this.cmbYear.Items.Add(currentYear - 1);
            this.cmbYear.Items.Add(currentYear);
            this.cmbYear.SelectedItem = currentYear;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);

            this.lblFilterRange.AutoSize = true;
            this.lblFilterRange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterRange.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblFilterRange.Location = new System.Drawing.Point(490, 12);
            this.lblFilterRange.Name = "lblFilterRange";
            this.lblFilterRange.Text = "Showing: --";

            // ── Custom date range controls (hidden by default) ─
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblFrom.Location = new System.Drawing.Point(182, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Text = "From:";
            this.lblFrom.Visible = false;

            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Location = new System.Drawing.Point(222, 8);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 24);
            this.dtpFrom.Value = new System.DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);
            this.dtpFrom.Visible = false;

            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblTo.Location = new System.Drawing.Point(342, 12);
            this.lblTo.Name = "lblTo";
            this.lblTo.Text = "To:";
            this.lblTo.Visible = false;

            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Location = new System.Drawing.Point(368, 8);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 24);
            this.dtpTo.Value = System.DateTime.Today;
            this.dtpTo.Visible = false;

            this.btnApplyRange.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnApplyRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyRange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyRange.ForeColor = System.Drawing.Color.White;
            this.btnApplyRange.Location = new System.Drawing.Point(488, 6);
            this.btnApplyRange.Name = "btnApplyRange";
            this.btnApplyRange.Size = new System.Drawing.Size(90, 28);
            this.btnApplyRange.Text = "Apply";
            this.btnApplyRange.Visible = false;
            this.btnApplyRange.FlatAppearance.BorderSize = 0;
            this.btnApplyRange.Click += new System.EventHandler(this.btnApplyRange_Click);

            // ── Summary Cards ─────────────────────────────────
            int cardY = 105; int cardH = 80;
            MakeCard(this.pnlTodaySales, this.lblTodaySalesLbl, this.lblTodaySales,
                "Today's Sales", "₱0.00", 10, cardY, 170, cardH, System.Drawing.Color.FromArgb(13, 71, 161));
            MakeCard(this.pnlTodayOrders, this.lblTodayOrdersLbl, this.lblTodayOrders,
                "Orders Today", "0", 190, cardY, 170, cardH, System.Drawing.Color.FromArgb(255, 111, 0));
            MakeCard(this.pnlRangeSales, this.lblRangeSalesLbl, this.lblRangeSales,
                "Period Sales", "₱0.00", 370, cardY, 170, cardH, System.Drawing.Color.FromArgb(13, 71, 161));
            MakeCard(this.pnlRangeOrders, this.lblRangeOrdersLbl, this.lblRangeOrders,
                "Period Orders", "0", 550, cardY, 170, cardH, System.Drawing.Color.FromArgb(255, 111, 0));
            MakeCard(this.pnlAvgOrder, this.lblAvgOrderLbl, this.lblAvgOrder,
                "Avg Order", "₱0.00", 730, cardY, 170, cardH, System.Drawing.Color.FromArgb(13, 71, 161));
            MakeCard(this.pnlCustomers, this.lblCustomersLbl, this.lblCustomers,
                "Customers", "0", 910, cardY, 180, cardH, System.Drawing.Color.FromArgb(255, 111, 0));

            // ── Status Chart ──────────────────────────────────
            this.lblStatusChartTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusChartTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblStatusChartTitle.Location = new System.Drawing.Point(10, 198);
            this.lblStatusChartTitle.Name = "lblStatusChartTitle";
            this.lblStatusChartTitle.Size = new System.Drawing.Size(300, 22);
            this.lblStatusChartTitle.Text = "Orders by Status";

            this.pnlStatusChart.BackColor = System.Drawing.Color.White;
            this.pnlStatusChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatusChart.Location = new System.Drawing.Point(10, 222);
            this.pnlStatusChart.Name = "pnlStatusChart";
            this.pnlStatusChart.Size = new System.Drawing.Size(380, 160);
            this.pnlStatusChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatusChart_Paint);

            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatus.Location = new System.Drawing.Point(400, 222);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Size = new System.Drawing.Size(240, 160);
            SetGridStyle(this.dgvStatus);

            // ── Category Chart ────────────────────────────────
            this.lblCategoryChartTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoryChartTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblCategoryChartTitle.Location = new System.Drawing.Point(655, 198);
            this.lblCategoryChartTitle.Name = "lblCategoryChartTitle";
            this.lblCategoryChartTitle.Size = new System.Drawing.Size(250, 22);
            this.lblCategoryChartTitle.Text = "Revenue by Category";

            this.pnlCategoryChart.BackColor = System.Drawing.Color.White;
            this.pnlCategoryChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryChart.Location = new System.Drawing.Point(655, 222);
            this.pnlCategoryChart.Name = "pnlCategoryChart";
            this.pnlCategoryChart.Size = new System.Drawing.Size(370, 160);
            this.pnlCategoryChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategoryChart_Paint);

            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.Location = new System.Drawing.Point(1035, 222);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(255, 160);
            SetGridStyle(this.dgvCategory);

            // ── Top Items ─────────────────────────────────────
            this.lblTopItemsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTopItemsTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblTopItemsTitle.Location = new System.Drawing.Point(10, 396);
            this.lblTopItemsTitle.Name = "lblTopItemsTitle";
            this.lblTopItemsTitle.Size = new System.Drawing.Size(300, 22);
            this.lblTopItemsTitle.Text = "Top 5 Best Selling Items";

            this.dgvTopItems.AllowUserToAddRows = false;
            this.dgvTopItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopItems.Location = new System.Drawing.Point(10, 420);
            this.dgvTopItems.Name = "dgvTopItems";
            this.dgvTopItems.ReadOnly = true;
            this.dgvTopItems.Size = new System.Drawing.Size(630, 200);
            SetGridStyle(this.dgvTopItems);

            // ── Recent Orders ─────────────────────────────────
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblRecentTitle.Location = new System.Drawing.Point(655, 396);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(250, 22);
            this.lblRecentTitle.Text = "Recent Orders";

            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.Location = new System.Drawing.Point(655, 420);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.Size = new System.Drawing.Size(635, 200);
            SetGridStyle(this.dgvRecent);

            // ── AnalyticsForm ─────────────────────────────────
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1110, 640);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(1110, 640);
            this.Name = "AnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics Dashboard";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.pnlFilter,
                this.pnlTodaySales, this.pnlTodayOrders,
                this.pnlRangeSales, this.pnlRangeOrders,
                this.pnlAvgOrder, this.pnlCustomers,
                this.lblStatusChartTitle, this.pnlStatusChart, this.dgvStatus,
                this.lblCategoryChartTitle, this.pnlCategoryChart, this.dgvCategory,
                this.lblTopItemsTitle, this.dgvTopItems,
                this.lblRecentTitle, this.dgvRecent
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
        }

        private void MakeCard(
            System.Windows.Forms.Panel pnl, System.Windows.Forms.Label lblLabel,
            System.Windows.Forms.Label lblValue, string labelText, string valueText,
            int x, int y, int w, int h, System.Drawing.Color color)
        {
            pnl.BackColor = color;
            pnl.Location = new System.Drawing.Point(x, y);
            pnl.Size = new System.Drawing.Size(w, h);
            pnl.Controls.AddRange(new System.Windows.Forms.Control[] { lblLabel, lblValue });

            lblLabel.AutoSize = true;
            lblLabel.BackColor = System.Drawing.Color.Transparent;
            lblLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblLabel.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            lblLabel.Location = new System.Drawing.Point(12, 10);
            lblLabel.Text = labelText;

            lblValue.AutoSize = true;
            lblValue.BackColor = System.Drawing.Color.Transparent;
            lblValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.White;
            lblValue.Location = new System.Drawing.Point(10, 32);
            lblValue.Text = valueText;
        }

        private void SetGridStyle(System.Windows.Forms.DataGridView dgv)
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
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterMode;
        private System.Windows.Forms.ComboBox cmbFilterMode;
        private System.Windows.Forms.Label lblFilterMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblFilterYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblFilterRange;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnApplyRange;
        private System.Windows.Forms.Panel pnlTodaySales;
        private System.Windows.Forms.Label lblTodaySalesLbl;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Panel pnlTodayOrders;
        private System.Windows.Forms.Label lblTodayOrdersLbl;
        private System.Windows.Forms.Label lblTodayOrders;
        private System.Windows.Forms.Panel pnlRangeSales;
        private System.Windows.Forms.Label lblRangeSalesLbl;
        private System.Windows.Forms.Label lblRangeSales;
        private System.Windows.Forms.Panel pnlRangeOrders;
        private System.Windows.Forms.Label lblRangeOrdersLbl;
        private System.Windows.Forms.Label lblRangeOrders;
        private System.Windows.Forms.Panel pnlAvgOrder;
        private System.Windows.Forms.Label lblAvgOrderLbl;
        private System.Windows.Forms.Label lblAvgOrder;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Label lblCustomersLbl;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblStatusChartTitle;
        private System.Windows.Forms.Panel pnlStatusChart;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Label lblCategoryChartTitle;
        private System.Windows.Forms.Panel pnlCategoryChart;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label lblTopItemsTitle;
        private System.Windows.Forms.DataGridView dgvTopItems;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}