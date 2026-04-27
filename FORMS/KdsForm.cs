using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class KDSForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private System.Windows.Forms.Timer _refreshTimer;
        private System.Windows.Forms.Timer _animTimer;
        private System.Windows.Forms.Timer _clockTimer;

        private HashSet<int> _readyOrders = new HashSet<int>();
        private HashSet<int> _prevReadyOrders = new HashSet<int>();
        private float _flashAlpha = 0f;
        private bool _flashGrowing = true;

        public KDSForm()
        {
            InitializeComponent();
            LoadOrders();
            StartTimers();
            SessionManager.OrderChanged += OnOrderChanged;
        }

        private void OnOrderChanged()
        {
            if (!IsDisposed) Invoke((Action)LoadOrders);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(255, 180, 50), 2))
                e.Graphics.DrawLine(pen, 0, 79, 1100, 79);
        }

        private void pnlPrepHeader_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(Color.FromArgb(220, 80, 40)))
                e.Graphics.FillRectangle(b, 0, 0, 530, 60);
        }

        private void pnlReadyHeader_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(Color.FromArgb(39, 174, 96)))
                e.Graphics.FillRectangle(b, 0, 0, 530, 60);
        }

        private void pnlPreparing_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(40, 40, 55), 1))
                e.Graphics.DrawRectangle(pen, 0, 0, pnlPreparing.Width - 1, pnlPreparing.Height - 1);
        }

        private void pnlReady_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(40, 40, 55), 1))
                e.Graphics.DrawRectangle(pen, 0, 0, pnlReady.Width - 1, pnlReady.Height - 1);
        }

        // ── Load & render orders ─────────────────────────────
        private void LoadOrders()
        {
            // Only show PAID/Preparing in left column — Pending means not paid yet, don't show on board
            DataTable dtPrep = _orderRepo.GetOrdersByStatuses(new[] { "Preparing" });
            DataTable dtReady = _orderRepo.GetOrdersByStatuses(new[] { "Ready" });

            var newReadyOrders = new HashSet<int>();
            foreach (DataRow r in dtReady.Rows)
                newReadyOrders.Add(Convert.ToInt32(r["orderID"]));

            foreach (int id in newReadyOrders)
                if (!_prevReadyOrders.Contains(id))
                    _readyOrders.Add(id);

            _prevReadyOrders = newReadyOrders;

            RenderColumn(pnlPreparing, dtPrep, false);
            RenderColumn(pnlReady, dtReady, true);

            lblPreparingCount.Text = $"{dtPrep.Rows.Count} order{(dtPrep.Rows.Count != 1 ? "s" : "")}";
            lblReadyCount.Text = $"{dtReady.Rows.Count} order{(dtReady.Rows.Count != 1 ? "s" : "")}";
        }

        private void RenderColumn(Panel panel, DataTable dt, bool isReady)
        {
            panel.Controls.Clear();

            if (dt.Rows.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = isReady ? "No orders ready yet" : "No orders in queue",
                    Font = new Font("Segoe UI", 12),
                    ForeColor = Color.FromArgb(60, 60, 80),
                    Left = 0,
                    Top = 200,
                    Width = panel.Width,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                panel.Controls.Add(lblEmpty);
                return;
            }

            int top = 12;
            foreach (DataRow row in dt.Rows)
            {
                int orderID = Convert.ToInt32(row["orderID"]);
                string status = row["status"].ToString();
                bool isNew = _readyOrders.Contains(orderID);

                var card = CreateOrderCard(orderID, status, isReady, isNew, panel.Width - 20);
                card.Left = 10;
                card.Top = top;
                panel.Controls.Add(card);
                top += card.Height + 10;
            }
        }

        private Panel CreateOrderCard(int orderID, string status, bool isReady, bool isNew, int width)
        {
            int flashA = isNew ? Math.Max(0, Math.Min(80, (int)(_flashAlpha * 80))) : 0;
            Color cardBg = isReady ? Color.FromArgb(15, 35, 20) : Color.FromArgb(35, 18, 12);
            Color borderColor = isReady ? Color.FromArgb(39, 174, 96) : Color.FromArgb(220, 80, 40);
            Color numColor = isReady ? Color.FromArgb(80, 220, 120) : Color.White;

            var card = new Panel { Width = width, Height = 90, BackColor = cardBg };
            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (var pen = new Pen(borderColor, 2))
                    g.DrawRectangle(pen, 1, 1, card.Width - 2, card.Height - 2);

                if (flashA > 0)
                    using (var flash = new SolidBrush(Color.FromArgb(flashA, 80, 255, 120)))
                        g.FillRectangle(flash, 0, 0, card.Width, card.Height);

                using (var bar = new SolidBrush(borderColor))
                    g.FillRectangle(bar, 0, 0, 6, card.Height);

                // Order number — BIG, centered
                using (var numFont = new Font("Segoe UI", 34, FontStyle.Bold))
                using (var numBrush = new SolidBrush(numColor))
                    g.DrawString($"#{orderID}", numFont, numBrush, 20, 16);

                // Status badge only
                string badge = status == "Ready" ? "READY ✓" : "PREPARING...";
                Color badgeColor = status == "Ready" ? Color.FromArgb(39, 174, 96) : Color.FromArgb(243, 156, 18);

                using (var badgeBrush = new SolidBrush(badgeColor))
                using (var badgeFont = new Font("Segoe UI", 9, FontStyle.Bold))
                {
                    var sz = g.MeasureString(badge, badgeFont);
                    float bx = card.Width - sz.Width - 20;
                    float by = (card.Height - sz.Height) / 2;
                    using (var bgBrush = new SolidBrush(Color.FromArgb(40, badgeColor.R, badgeColor.G, badgeColor.B)))
                        g.FillRectangle(bgBrush, bx - 8, by - 4, sz.Width + 16, sz.Height + 8);
                    g.DrawString(badge, badgeFont, badgeBrush, bx, by);
                }

                if (isReady)
                    using (var hintFont = new Font("Segoe UI", 8, FontStyle.Italic))
                    using (var hintBrush = new SolidBrush(Color.FromArgb(80, 180, 100)))
                        g.DrawString("Please proceed to the counter", hintFont, hintBrush, 20, 66);
            };

            return card;
        }

        // ── Timers ───────────────────────────────────────────
        private void StartTimers()
        {
            _refreshTimer = new System.Windows.Forms.Timer { Interval = 3000 };
            _refreshTimer.Tick += (s, e) => LoadOrders();
            _refreshTimer.Start();

            _animTimer = new System.Windows.Forms.Timer { Interval = 40 };
            _animTimer.Tick += (s, e) =>
            {
                if (_flashGrowing) { _flashAlpha += 0.04f; if (_flashAlpha >= 1f) _flashGrowing = false; }
                else { _flashAlpha -= 0.04f; if (_flashAlpha <= 0f) { _flashGrowing = true; _readyOrders.Clear(); } }
                if (_readyOrders.Count > 0) pnlReady.Invalidate(true);
            };
            _animTimer.Start();

            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _clockTimer.Tick += (s, e) => lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            _clockTimer.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _refreshTimer?.Stop();
            _animTimer?.Stop();
            _clockTimer?.Stop();
            SessionManager.OrderChanged -= OnOrderChanged;
            base.OnFormClosed(e);
        }
    }
}