namespace OOP_FINAL_PROJECT
{
    partial class KDSForm
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPrepHeader = new System.Windows.Forms.Panel();
            this.lblPrepTitle = new System.Windows.Forms.Label();
            this.lblPreparingCount = new System.Windows.Forms.Label();
            this.pnlReadyHeader = new System.Windows.Forms.Panel();
            this.lblReadyTitle = new System.Windows.Forms.Label();
            this.lblReadyCount = new System.Windows.Forms.Label();
            this.pnlPreparing = new System.Windows.Forms.Panel();
            this.pnlReady = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();

            this.pnlHeader.SuspendLayout();
            this.pnlPrepHeader.SuspendLayout();
            this.pnlReadyHeader.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 15, 22);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBrand, this.lblClock, this.lblSub, this.btnClose
            });
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 80);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(30, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Text = "ORDER STATUS BOARD";

            // lblClock
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(255, 180, 50);
            this.lblClock.Location = new System.Drawing.Point(880, 25);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(200, 30);
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblSub
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.lblSub.Location = new System.Drawing.Point(32, 52);
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Watch for your order number below";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(30, 30, 42);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(150, 150, 170);
            this.btnClose.Location = new System.Drawing.Point(1015, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.Text = "Close";
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── pnlPrepHeader ──────────────────────────────────
            this.pnlPrepHeader.BackColor = System.Drawing.Color.FromArgb(180, 60, 30);
            this.pnlPrepHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPrepTitle, this.lblPreparingCount
            });
            this.pnlPrepHeader.Location = new System.Drawing.Point(10, 88);
            this.pnlPrepHeader.Name = "pnlPrepHeader";
            this.pnlPrepHeader.Size = new System.Drawing.Size(530, 60);
            this.pnlPrepHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrepHeader_Paint);

            this.lblPrepTitle.AutoSize = true;
            this.lblPrepTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPrepTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrepTitle.ForeColor = System.Drawing.Color.White;
            this.lblPrepTitle.Location = new System.Drawing.Point(20, 14);
            this.lblPrepTitle.Name = "lblPrepTitle";
            this.lblPrepTitle.Text = "NOW PREPARING";

            this.lblPreparingCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPreparingCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPreparingCount.ForeColor = System.Drawing.Color.FromArgb(255, 200, 180);
            this.lblPreparingCount.Location = new System.Drawing.Point(380, 20);
            this.lblPreparingCount.Name = "lblPreparingCount";
            this.lblPreparingCount.Size = new System.Drawing.Size(140, 23);
            this.lblPreparingCount.Text = "0 orders";
            this.lblPreparingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── pnlReadyHeader ─────────────────────────────────
            this.pnlReadyHeader.BackColor = System.Drawing.Color.FromArgb(30, 140, 70);
            this.pnlReadyHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblReadyTitle, this.lblReadyCount
            });
            this.pnlReadyHeader.Location = new System.Drawing.Point(558, 88);
            this.pnlReadyHeader.Name = "pnlReadyHeader";
            this.pnlReadyHeader.Size = new System.Drawing.Size(530, 60);
            this.pnlReadyHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReadyHeader_Paint);

            this.lblReadyTitle.AutoSize = true;
            this.lblReadyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblReadyTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblReadyTitle.ForeColor = System.Drawing.Color.White;
            this.lblReadyTitle.Location = new System.Drawing.Point(20, 14);
            this.lblReadyTitle.Name = "lblReadyTitle";
            this.lblReadyTitle.Text = "READY TO CLAIM";

            this.lblReadyCount.BackColor = System.Drawing.Color.Transparent;
            this.lblReadyCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReadyCount.ForeColor = System.Drawing.Color.FromArgb(180, 255, 200);
            this.lblReadyCount.Location = new System.Drawing.Point(380, 20);
            this.lblReadyCount.Name = "lblReadyCount";
            this.lblReadyCount.Size = new System.Drawing.Size(140, 23);
            this.lblReadyCount.Text = "0 orders";
            this.lblReadyCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── pnlPreparing ───────────────────────────────────
            this.pnlPreparing.AutoScroll = true;
            this.pnlPreparing.BackColor = System.Drawing.Color.FromArgb(18, 12, 10);
            this.pnlPreparing.Location = new System.Drawing.Point(10, 155);
            this.pnlPreparing.Name = "pnlPreparing";
            this.pnlPreparing.Size = new System.Drawing.Size(530, 520);
            this.pnlPreparing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPreparing_Paint);

            // ── pnlReady ───────────────────────────────────────
            this.pnlReady.AutoScroll = true;
            this.pnlReady.BackColor = System.Drawing.Color.FromArgb(10, 18, 12);
            this.pnlReady.Location = new System.Drawing.Point(558, 155);
            this.pnlReady.Name = "pnlReady";
            this.pnlReady.Size = new System.Drawing.Size(530, 520);
            this.pnlReady.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReady_Paint);

            // ── pnlDivider ─────────────────────────────────────
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(255, 180, 50);
            this.pnlDivider.Location = new System.Drawing.Point(546, 88);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(8, 590);

            // ── pnlBottom ──────────────────────────────────────
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(255, 180, 50);
            this.pnlBottom.Location = new System.Drawing.Point(0, 682);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1100, 8);

            // ── KDSForm ────────────────────────────────────────
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 15);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KDSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Status Board";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader,
                this.pnlPrepHeader, this.pnlReadyHeader,
                this.pnlPreparing,  this.pnlReady,
                this.pnlDivider,    this.pnlBottom
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPrepHeader.ResumeLayout(false);
            this.pnlPrepHeader.PerformLayout();
            this.pnlReadyHeader.ResumeLayout(false);
            this.pnlReadyHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── Control declarations ──────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlPrepHeader;
        private System.Windows.Forms.Label lblPrepTitle;
        private System.Windows.Forms.Label lblPreparingCount;
        private System.Windows.Forms.Panel pnlReadyHeader;
        private System.Windows.Forms.Label lblReadyTitle;
        private System.Windows.Forms.Label lblReadyCount;
        private System.Windows.Forms.Panel pnlPreparing;
        private System.Windows.Forms.Panel pnlReady;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlBottom;
    }
}