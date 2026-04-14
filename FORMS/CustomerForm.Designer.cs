namespace OOP_FINAL_PROJECT
{
    partial class CustomerForm
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnBurgers = new System.Windows.Forms.Button();
            this.btnChicken = new System.Windows.Forms.Button();
            this.btnSides = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatusHint = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblHeaderTitle, this.lblLive, this.btnLogout });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;
            this.pnlHeader.Name = "pnlHeader";

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 12);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Text = "CUSTOMER";

            // lblLive
            this.lblLive.AutoSize = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblLive.Location = new System.Drawing.Point(370, 15);
            this.lblLive.Name = "lblLive";
            this.lblLive.Text = "● LIVE";

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(905, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 28);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlCategory
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlCategory.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCategories, this.btnAll, this.btnBurgers,
                this.btnChicken, this.btnSides, this.btnDrinks, this.btnDesserts
            });
            this.pnlCategory.Location = new System.Drawing.Point(0, 48);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(150, 632);

            // lblCategories
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(10, 20);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(130, 23);
            this.lblCategories.Text = "CATEGORIES";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Category buttons helper
            System.Windows.Forms.Button[] catBtns = {
                this.btnAll, this.btnBurgers, this.btnChicken,
                this.btnSides, this.btnDrinks, this.btnDesserts
            };
            string[] catNames = { "All", "Burgers", "Chicken", "Sides", "Drinks", "Desserts" };
            System.EventHandler[] catHandlers = {
                new System.EventHandler(this.btnAll_Click),
                new System.EventHandler(this.btnBurgers_Click),
                new System.EventHandler(this.btnChicken_Click),
                new System.EventHandler(this.btnSides_Click),
                new System.EventHandler(this.btnDrinks_Click),
                new System.EventHandler(this.btnDesserts_Click)
            };
            for (int i = 0; i < catBtns.Length; i++)
            {
                catBtns[i].BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
                catBtns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                catBtns[i].Font = new System.Drawing.Font("Segoe UI", 9F);
                catBtns[i].ForeColor = System.Drawing.Color.White;
                catBtns[i].Location = new System.Drawing.Point(10, 60 + i * 50);
                catBtns[i].Name = "btn" + catNames[i];
                catBtns[i].Size = new System.Drawing.Size(130, 40);
                catBtns[i].Text = catNames[i];
                catBtns[i].FlatAppearance.BorderSize = 0;
                catBtns[i].Click += catHandlers[i];
            }

            // lblMenuTitle
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.Location = new System.Drawing.Point(160, 58);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(440, 28);
            this.lblMenuTitle.Text = "MENU";

            // flpMenu
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpMenu.Location = new System.Drawing.Point(160, 93);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(440, 535);

            // pnlCart
            this.pnlCart.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlCart.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCartTitle, this.dgvCart, this.lblTotal,
                this.btnRemove, this.btnPlace, this.btnClear, this.pnlStatus
            });
            this.pnlCart.Location = new System.Drawing.Point(615, 48);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(385, 632);

            // lblCartTitle
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.Location = new System.Drawing.Point(5, 10);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(375, 25);
            this.lblCartTitle.Text = "YOUR ORDER";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvCart
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colItem, this.colQty, this.colSubtotal });
            this.dgvCart.Location = new System.Drawing.Point(5, 40);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(373, 260);

            this.colItem.HeaderText = "Item"; this.colItem.Name = "colItem";
            this.colQty.HeaderText = "Qty"; this.colQty.Name = "colQty";
            this.colSubtotal.HeaderText = "Subtotal"; this.colSubtotal.Name = "colSubtotal";

            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(5, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(373, 25);
            this.lblTotal.Text = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(5, 338);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 32);
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // btnPlace
            this.btnPlace.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.Location = new System.Drawing.Point(193, 338);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(185, 32);
            this.btnPlace.Text = "Place Order";
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(5, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(373, 28);
            this.btnClear.Text = "Clear Cart";
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // pnlStatus
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStatusTitle, this.lblOrderNum, this.lblStatusValue,
                this.lblStatusHint, this.btnNewOrder
            });
            this.pnlStatus.Location = new System.Drawing.Point(5, 415);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(373, 210);
            this.pnlStatus.Visible = false;

            // pnlStatus children
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.Location = new System.Drawing.Point(5, 10);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(363, 23);
            this.lblStatusTitle.Text = "ORDER STATUS";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblOrderNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderNum.ForeColor = System.Drawing.Color.Gray;
            this.lblOrderNum.Location = new System.Drawing.Point(5, 35);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(363, 23);
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.lblStatusValue.Location = new System.Drawing.Point(5, 60);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(363, 70);
            this.lblStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatusHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusHint.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusHint.Location = new System.Drawing.Point(5, 135);
            this.lblStatusHint.Name = "lblStatusHint";
            this.lblStatusHint.Size = new System.Drawing.Size(363, 20);
            this.lblStatusHint.Text = "Updates every 5 seconds";
            this.lblStatusHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(87, 163);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(200, 35);
            this.btnNewOrder.Text = "Start New Order";
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);

            // CustomerForm
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customer — Order";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.pnlCategory, this.lblMenuTitle, this.flpMenu, this.pnlCart
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnBurgers;
        private System.Windows.Forms.Button btnChicken;
        private System.Windows.Forms.Button btnSides;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatusHint;
        private System.Windows.Forms.Button btnNewOrder;
    }
}