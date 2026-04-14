using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class AnalyticsForm : Form
    {
        private AnalyticsRepository _analytics = new AnalyticsRepository();
        private System.Windows.Forms.Timer _refreshTimer;

        // ── Active date range ─────────────────────────────────
        private DateTime _rangeFrom;
        private DateTime _rangeTo;

        public AnalyticsForm()
        {
            InitializeComponent();
            // Default: current month
            ApplyMonthFilter(DateTime.Today.Year, DateTime.Today.Month);
            StartAutoRefresh();
        }

        // ── Button handlers ───────────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e) => LoadAnalytics();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        // ── Filter mode toggle ────────────────────────────────
        private void cmbFilterMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isMonthly = cmbFilterMode.SelectedIndex == 0;
            cmbMonth.Visible = isMonthly;
            cmbYear.Visible = true; // always visible

            if (isMonthly)
                ApplyMonthFilter((int)cmbYear.SelectedItem, cmbMonth.SelectedIndex + 1);
            else
                ApplyYearFilter((int)cmbYear.SelectedItem);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterMode.SelectedIndex == 0)
                ApplyMonthFilter((int)cmbYear.SelectedItem, cmbMonth.SelectedIndex + 1);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterMode.SelectedIndex == 0)
                ApplyMonthFilter((int)cmbYear.SelectedItem, cmbMonth.SelectedIndex + 1);
            else
                ApplyYearFilter((int)cmbYear.SelectedItem);
        }

        // ── Range helpers ─────────────────────────────────────
        private void ApplyMonthFilter(int year, int month)
        {
            _rangeFrom = new DateTime(year, month, 1);
            _rangeTo = _rangeFrom.AddMonths(1);
            UpdateFilterLabel($"Showing: {_rangeFrom:MMMM yyyy}");
            LoadAnalytics();
        }

        private void ApplyYearFilter(int year)
        {
            _rangeFrom = new DateTime(year, 1, 1);
            _rangeTo = new DateTime(year + 1, 1, 1);
            UpdateFilterLabel($"Showing: Year {year}");
            LoadAnalytics();
        }

        private void UpdateFilterLabel(string text)
        {
            lblFilterRange.Text = text;
        }

        // ── Load all data ─────────────────────────────────────
        private void LoadAnalytics()
        {
            try
            {
                LoadSummaryCards();
                LoadTopItems();
                LoadOrdersByStatus();
                LoadSalesByCategory();
                LoadRecentOrders();
                pnlCategoryChart.Invalidate();
                lblLastRefresh.Text = $"Last refreshed: {DateTime.Now:hh:mm:ss tt}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading analytics: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSummaryCards()
        {
            // Fixed "Today" card always shows today regardless of filter
            double today = _analytics.GetTotalSalesToday();
            lblTodaySales.Text = $"₱{today:N2}";
            int ordersToday = _analytics.GetTotalOrdersToday();
            lblTodayOrders.Text = ordersToday.ToString();

            // Filtered range cards
            double rangeSales = _analytics.GetTotalSalesInRange(_rangeFrom, _rangeTo);
            lblRangeSales.Text = $"₱{rangeSales:N2}";

            int rangeOrders = _analytics.GetTotalOrdersInRange(_rangeFrom, _rangeTo);
            lblRangeOrders.Text = rangeOrders.ToString();

            double avg = _analytics.GetAverageOrderValueInRange(_rangeFrom, _rangeTo);
            lblAvgOrder.Text = $"₱{avg:N2}";

            int customers = _analytics.GetTotalCustomersInRange(_rangeFrom, _rangeTo);
            lblCustomers.Text = customers.ToString();
        }

        private void LoadTopItems()
        {
            DataTable dt = _analytics.GetTopSellingItemsInRange(_rangeFrom, _rangeTo, 5);
            dgvTopItems.DataSource = dt;
            if (dgvTopItems.Columns.Count > 0)
            {
                dgvTopItems.Columns["name"].HeaderText = "Item";
                dgvTopItems.Columns["category"].HeaderText = "Category";
                dgvTopItems.Columns["totalQty"].HeaderText = "Qty Sold";
                dgvTopItems.Columns["totalRevenue"].HeaderText = "Revenue";
            }
        }

        private void LoadOrdersByStatus()
        {
            DataTable dt = _analytics.GetOrderCountByStatusInRange(_rangeFrom, _rangeTo);
            dgvStatus.DataSource = dt;
            if (dgvStatus.Columns.Count > 0)
            {
                dgvStatus.Columns["status"].HeaderText = "Status";
                dgvStatus.Columns["orderCount"].HeaderText = "Count";
            }
            pnlStatusChart.Tag = dt;
            pnlStatusChart.Invalidate();
        }

        private void LoadSalesByCategory()
        {
            DataTable dt = _analytics.GetSalesByCategoryInRange(_rangeFrom, _rangeTo);
            dgvCategory.DataSource = dt;
            if (dgvCategory.Columns.Count > 0)
            {
                dgvCategory.Columns["category"].HeaderText = "Category";
                dgvCategory.Columns["totalQty"].HeaderText = "Qty Sold";
                dgvCategory.Columns["totalRevenue"].HeaderText = "Revenue";
            }
            pnlCategoryChart.Tag = dt;
            pnlCategoryChart.Invalidate();
        }

        private void LoadRecentOrders()
        {
            dgvRecent.DataSource = _analytics.GetRecentOrdersInRange(_rangeFrom, _rangeTo, 10);
        }

        // ── Status Bar Chart Paint ────────────────────────────
        private void pnlStatusChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            var dt = pnlStatusChart.Tag as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                using (var f = new Font("Segoe UI", 9))
                using (var b = new SolidBrush(Color.FromArgb(189, 189, 189)))
                    g.DrawString("No data yet", f, b, 10, 40);
                return;
            }

            Color[] colors = {
                Color.FromArgb(33, 150, 243),
                Color.FromArgb(255, 111, 0),
                Color.FromArgb(67, 160, 71),
                Color.FromArgb(229, 57, 53),
                Color.FromArgb(156, 39, 176)
            };

            int maxCount = 0;
            foreach (DataRow r in dt.Rows)
                if (Convert.ToInt32(r["orderCount"]) > maxCount)
                    maxCount = Convert.ToInt32(r["orderCount"]);
            if (maxCount == 0) maxCount = 1;

            int panelW = pnlStatusChart.Width - 20;
            int panelH = pnlStatusChart.Height - 40;
            int barW = Math.Max(20, (panelW / dt.Rows.Count) - 10);
            int x = 10;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string status = dt.Rows[i]["status"].ToString();
                int count = Convert.ToInt32(dt.Rows[i]["orderCount"]);
                int barH = (int)((double)count / maxCount * panelH);
                int y = panelH - barH + 10;
                Color c = colors[i % colors.Length];

                using (var br = new SolidBrush(c))
                    g.FillRectangle(br, x, y, barW, barH);

                using (var tf = new Font("Segoe UI", 8, FontStyle.Bold))
                using (var tb = new SolidBrush(c))
                    g.DrawString(count.ToString(), tf, tb, x + barW / 2 - 8, y - 18);

                using (var tf = new Font("Segoe UI", 7))
                using (var tb = new SolidBrush(Color.FromArgb(117, 117, 117)))
                {
                    string lbl = status.Length > 8 ? status.Substring(0, 8) : status;
                    g.DrawString(lbl, tf, tb, x, panelH + 14);
                }
                x += barW + 10;
            }
        }

        // ── Category Revenue Bar Chart ────────────────────────
        private void pnlCategoryChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            var dt = pnlCategoryChart.Tag as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                using (var f = new Font("Segoe UI", 9))
                using (var b = new SolidBrush(Color.FromArgb(189, 189, 189)))
                    g.DrawString("No data yet", f, b, 10, 40);
                return;
            }

            Color[] colors = {
                Color.FromArgb(255, 111, 0),
                Color.FromArgb(33, 150, 243),
                Color.FromArgb(67, 160, 71),
                Color.FromArgb(156, 39, 176),
                Color.FromArgb(229, 57, 53)
            };

            double maxRev = 0;
            foreach (DataRow r in dt.Rows)
                if (Convert.ToDouble(r["totalRevenue"]) > maxRev)
                    maxRev = Convert.ToDouble(r["totalRevenue"]);
            if (maxRev == 0) maxRev = 1;

            int panelW = pnlCategoryChart.Width - 20;
            int panelH = pnlCategoryChart.Height - 40;
            int barW = Math.Max(20, (panelW / dt.Rows.Count) - 10);
            int x = 10;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string cat = dt.Rows[i]["category"].ToString();
                double rev = Convert.ToDouble(dt.Rows[i]["totalRevenue"]);
                int barH = (int)(rev / maxRev * panelH);
                int y = panelH - barH + 10;
                Color c = colors[i % colors.Length];

                using (var br = new SolidBrush(c))
                    g.FillRectangle(br, x, y, barW, barH);

                using (var tf = new Font("Segoe UI", 7, FontStyle.Bold))
                using (var tb = new SolidBrush(c))
                    g.DrawString($"₱{rev:N0}", tf, tb, x, y - 16);

                using (var tf = new Font("Segoe UI", 7))
                using (var tb = new SolidBrush(Color.FromArgb(117, 117, 117)))
                {
                    string lbl = cat.Length > 8 ? cat.Substring(0, 8) : cat;
                    g.DrawString(lbl, tf, tb, x, panelH + 14);
                }
                x += barW + 10;
            }
        }

        private void StartAutoRefresh()
        {
            _refreshTimer = new System.Windows.Forms.Timer { Interval = 30000 };
            _refreshTimer.Tick += (s, e) => LoadAnalytics();
            _refreshTimer.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _refreshTimer?.Stop();
            base.OnFormClosed(e);
        }
    }
}