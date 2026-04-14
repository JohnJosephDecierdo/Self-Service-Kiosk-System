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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.btnPreparing = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblLive, this.btnLogout });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "KITCHEN ORDER QUEUE";

            this.lblLive.AutoSize = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblLive.Location = new System.Drawing.Point(300, 15);
            this.lblLive.Name = "lblLive";
            this.lblLive.Text = "● LIVE";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(790, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblSub
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.lblSub.Location = new System.Drawing.Point(10, 58);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(858, 20);
            this.lblSub.Text = "Showing: Paid & Preparing orders";

            // dgvOrders
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(10, 82);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(858, 230);
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);

            // lblItems
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblItems.Location = new System.Drawing.Point(10, 322);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(200, 20);
            this.lblItems.Text = "Order Items";

            // dgvDetails
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(10, 344);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(858, 180);

            // Action buttons
            this.btnPreparing.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPreparing.ForeColor = System.Drawing.Color.White;
            this.btnPreparing.Location = new System.Drawing.Point(10, 538);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(270, 52);
            this.btnPreparing.Text = "Mark: PREPARING";
            this.btnPreparing.FlatAppearance.BorderSize = 0;
            this.btnPreparing.Click += new System.EventHandler(this.btnPreparing_Click);

            this.btnReady.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReady.ForeColor = System.Drawing.Color.White;
            this.btnReady.Location = new System.Drawing.Point(295, 538);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(270, 52);
            this.btnReady.Text = "Mark: READY";
            this.btnReady.FlatAppearance.BorderSize = 0;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);

            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.btnRefresh.Location = new System.Drawing.Point(580, 538);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(288, 52);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // CookForm
            this.ClientSize = new System.Drawing.Size(880, 610);
            this.Name = "CookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cook — Kitchen Queue";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.lblSub, this.dgvOrders,
                this.lblItems, this.dgvDetails,
                this.btnPreparing, this.btnReady, this.btnRefresh
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnPreparing;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnRefresh;
    }
}