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

        private DateTime _rangeFrom;
        private DateTime _rangeTo;

        public AnalyticsForm()
        {
            InitializeComponent();
            ApplyMonthFilter(DateTime.Today.Year, DateTime.Today.Month);
            StartAutoRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAnalytics();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void cmbFilterMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilterMode_Visibility();
            switch (cmbFilterMode.SelectedIndex)
            {
                case 0: ApplyMonthFilter((int)cmbYear.SelectedItem, cmbMonth.SelectedIndex + 1); break;
                case 1: ApplyYearFilter((int)cmbYear.SelectedItem); break;
                case 2: UpdateFilterLabel("Select a date range and click Apply"); break;
            }
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

        private void btnApplyRange_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _rangeFrom = dtpFrom.Value.Date;
            _rangeTo = dtpTo.Value.Date.AddDays(1);
            UpdateFilterLabel($"Showing: {_rangeFrom:MMM dd} – {dtpTo.Value:MMM dd, yyyy}");
            LoadAnalytics();
        }

        private void cmbFilterMode_Visibility()
        {
            bool isCustom = cmbFilterMode.SelectedIndex == 2;
            bool isMonthly = cmbFilterMode.SelectedIndex == 0;
            cmbMonth.Visible = isMonthly;
            cmbYear.Visible = !isCustom;
            lblFilterYear.Visible = !isCustom;
            lblFilterMonth.Visible = isMonthly;
            dtpFrom.Visible = isCustom;
            dtpTo.Visible = isCustom;
            lblFrom.Visible = isCustom;
            lblTo.Visible = isCustom;
            btnApplyRange.Visible = isCustom;
        }

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

        private void UpdateFilterLabel(string text) => lblFilterRange.Text = text;

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
            double today = _analytics.GetTotalSalesToday();
            lblTodaySales.Text = $"₱{today:N2}";
            int ordersToday = _analytics.GetTotalOrdersToday();
            lblTodayOrders.Text = ordersToday.ToString();

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

        private void pnlStatusChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.White);

            var dt = pnlStatusChart.Tag as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                using (var f = new Font("Segoe UI", 9))
                using (var b = new SolidBrush(Color.FromArgb(189, 189, 189)))
                    g.DrawString("No data yet", f, b, 16, 80);
                return;
            }

            Color[] colors = {
                Color.FromArgb(33, 150, 243), Color.FromArgb(255, 111, 0),
                Color.FromArgb(67, 160, 71),  Color.FromArgb(229, 57, 53),
                Color.FromArgb(156, 39, 176)
            };

            int maxCount = 0;
            foreach (DataRow r in dt.Rows)
                if (Convert.ToInt32(r["orderCount"]) > maxCount)
                    maxCount = Convert.ToInt32(r["orderCount"]);
            if (maxCount == 0) maxCount = 1;

            int padL = 16, padR = 16, padTop = 28, padBot = 22;
            int chartW = pnlStatusChart.Width - padL - padR;
            int chartH = pnlStatusChart.Height - padTop - padBot;
            int n = dt.Rows.Count;
            int gap = Math.Max(8, chartW / (n * 4));
            int barW = Math.Max(24, (chartW - gap * (n + 1)) / n);

            using (var pen = new System.Drawing.Pen(Color.FromArgb(220, 220, 220), 1))
                g.DrawLine(pen, padL, padTop + chartH, padL + chartW, padTop + chartH);

            int x = padL + gap;
            for (int i = 0; i < n; i++)
            {
                string status = dt.Rows[i]["status"].ToString();
                int count = Convert.ToInt32(dt.Rows[i]["orderCount"]);
                int barH = Math.Max(4, (int)((double)count / maxCount * chartH));
                int barY = padTop + chartH - barH;
                Color c = colors[i % colors.Length];

                using (var lgb = new LinearGradientBrush(
                    new System.Drawing.Point(x, barY),
                    new System.Drawing.Point(x, barY + barH),
                    Color.FromArgb(255, c.R, c.G, c.B),
                    Color.FromArgb(180, c.R, c.G, c.B)))
                    g.FillRectangle(lgb, x, barY, barW, barH);

                using (var tf = new Font("Segoe UI", 8, FontStyle.Bold))
                using (var tb = new SolidBrush(c))
                {
                    string lbl = count.ToString();
                    var sz = g.MeasureString(lbl, tf);
                    g.DrawString(lbl, tf, tb, x + (barW - sz.Width) / 2, barY - sz.Height - 2);
                }

                using (var tf = new Font("Segoe UI", 7.5f))
                using (var tb = new SolidBrush(Color.FromArgb(90, 90, 90)))
                {
                    string lbl = status.Length > 9 ? status.Substring(0, 9) : status;
                    var sz = g.MeasureString(lbl, tf);
                    g.DrawString(lbl, tf, tb, x + (barW - sz.Width) / 2, padTop + chartH + 5);
                }
                x += barW + gap;
            }
        }

        private void pnlCategoryChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.White);

            var dt = pnlCategoryChart.Tag as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                using (var f = new Font("Segoe UI", 9))
                using (var b = new SolidBrush(Color.FromArgb(189, 189, 189)))
                    g.DrawString("No data yet", f, b, 16, 80);
                return;
            }

            Color[] colors = {
                Color.FromArgb(255, 111, 0),  Color.FromArgb(33, 150, 243),
                Color.FromArgb(67, 160, 71),  Color.FromArgb(156, 39, 176),
                Color.FromArgb(229, 57, 53)
            };

            double maxRev = 0;
            foreach (DataRow r in dt.Rows)
                if (Convert.ToDouble(r["totalRevenue"]) > maxRev)
                    maxRev = Convert.ToDouble(r["totalRevenue"]);
            if (maxRev == 0) maxRev = 1;

            int padL = 16, padR = 16, padTop = 28, padBot = 22;
            int chartW = pnlCategoryChart.Width - padL - padR;
            int chartH = pnlCategoryChart.Height - padTop - padBot;
            int n = dt.Rows.Count;
            int gap = Math.Max(8, chartW / (n * 4));
            int barW = Math.Max(24, (chartW - gap * (n + 1)) / n);

            using (var pen = new System.Drawing.Pen(Color.FromArgb(220, 220, 220), 1))
                g.DrawLine(pen, padL, padTop + chartH, padL + chartW, padTop + chartH);

            int x = padL + gap;
            for (int i = 0; i < n; i++)
            {
                string cat = dt.Rows[i]["category"].ToString();
                double rev = Convert.ToDouble(dt.Rows[i]["totalRevenue"]);
                int barH = Math.Max(4, (int)(rev / maxRev * chartH));
                int barY = padTop + chartH - barH;
                Color c = colors[i % colors.Length];

                using (var lgb = new LinearGradientBrush(
                    new System.Drawing.Point(x, barY),
                    new System.Drawing.Point(x, barY + barH),
                    Color.FromArgb(255, c.R, c.G, c.B),
                    Color.FromArgb(170, c.R, c.G, c.B)))
                    g.FillRectangle(lgb, x, barY, barW, barH);

                using (var tf = new Font("Segoe UI", 7.5f, FontStyle.Bold))
                using (var tb = new SolidBrush(c))
                {
                    string lbl = $"₱{rev:N0}";
                    var sz = g.MeasureString(lbl, tf);
                    g.DrawString(lbl, tf, tb, x + (barW - sz.Width) / 2, barY - sz.Height - 2);
                }

                using (var tf = new Font("Segoe UI", 7.5f))
                using (var tb = new SolidBrush(Color.FromArgb(90, 90, 90)))
                {
                    string lbl = cat.Length > 9 ? cat.Substring(0, 9) : cat;
                    var sz = g.MeasureString(lbl, tf);
                    g.DrawString(lbl, tf, tb, x + (barW - sz.Width) / 2, padTop + chartH + 5);
                }
                x += barW + gap;
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