namespace OOP_FINAL_PROJECT
{
    partial class EditOrderForm
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.lblEditNote = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlQtyButtons = new System.Windows.Forms.Panel();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            // Add Item section
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.lblAddItemTitle = new System.Windows.Forms.Label();
            this.cboMenuItems = new System.Windows.Forms.ComboBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            // Bottom buttons
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlQtyButtons.SuspendLayout();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();

            // ── Header ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSubtitle });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Edit Order";

            this.lblSubtitle.AutoSize = true; this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44); this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Modify quantities, add or remove items";

            // ── Order info bar ────────────────────────────────
            this.lblOrderInfo.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.lblOrderInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderInfo.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblOrderInfo.Location = new System.Drawing.Point(0, 70);
            this.lblOrderInfo.Name = "lblOrderInfo"; this.lblOrderInfo.Size = new System.Drawing.Size(600, 30);
            this.lblOrderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderInfo.Text = "Order #...";

            // ── Edit note ─────────────────────────────────────
            this.lblEditNote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblEditNote.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblEditNote.Location = new System.Drawing.Point(10, 108);
            this.lblEditNote.Name = "lblEditNote"; this.lblEditNote.Size = new System.Drawing.Size(578, 18);
            this.lblEditNote.Text = "Select an item below and click + Add Item to add it to the order.";

            // ── dgvItems ──────────────────────────────────────
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.dgvItems.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDetailID, this.colName, this.colPrice, this.colQty, this.colSubtotal
            });
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvItems.Location = new System.Drawing.Point(10, 130);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Size = new System.Drawing.Size(578, 180);
            this.dgvItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.dgvItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(13, 71, 161);

            this.colDetailID.HeaderText = "ID"; this.colDetailID.Name = "colDetailID"; this.colDetailID.Visible = false;
            this.colName.HeaderText = "Item"; this.colName.Name = "colName";
            this.colPrice.HeaderText = "Price"; this.colPrice.Name = "colPrice";
            this.colQty.HeaderText = "Qty"; this.colQty.Name = "colQty";
            this.colSubtotal.HeaderText = "Subtotal"; this.colSubtotal.Name = "colSubtotal";

            // ── lblTotal ──────────────────────────────────────
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblTotal.Location = new System.Drawing.Point(10, 318);
            this.lblTotal.Name = "lblTotal"; this.lblTotal.Size = new System.Drawing.Size(578, 26);
            this.lblTotal.Text = "New Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── Qty buttons ───────────────────────────────────
            this.pnlQtyButtons.Location = new System.Drawing.Point(10, 350);
            this.pnlQtyButtons.Name = "pnlQtyButtons";
            this.pnlQtyButtons.Size = new System.Drawing.Size(578, 42);
            this.pnlQtyButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnIncrease, this.btnDecrease, this.btnRemoveItem
            });

            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.Location = new System.Drawing.Point(0, 0);
            this.btnIncrease.Name = "btnIncrease"; this.btnIncrease.Size = new System.Drawing.Size(188, 40);
            this.btnIncrease.Text = "+ Increase Qty";
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);

            this.btnDecrease.BackColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDecrease.Location = new System.Drawing.Point(196, 0);
            this.btnDecrease.Name = "btnDecrease"; this.btnDecrease.Size = new System.Drawing.Size(188, 40);
            this.btnDecrease.Text = "- Decrease Qty";
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);

            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(392, 0);
            this.btnRemoveItem.Name = "btnRemoveItem"; this.btnRemoveItem.Size = new System.Drawing.Size(186, 40);
            this.btnRemoveItem.Text = "✕ Remove Item";
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            // ── Add Item panel ────────────────────────────────
            this.pnlAddItem.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddItem.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAddItemTitle, this.cboMenuItems, this.lblQtyLabel, this.nudQty, this.btnAddItem
            });
            this.pnlAddItem.Location = new System.Drawing.Point(10, 402);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(578, 80);

            this.lblAddItemTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddItemTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblAddItemTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItemTitle.Location = new System.Drawing.Point(10, 8);
            this.lblAddItemTitle.Name = "lblAddItemTitle"; this.lblAddItemTitle.AutoSize = true;
            this.lblAddItemTitle.Text = "➕  Add Item to Order:";

            this.cboMenuItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMenuItems.Location = new System.Drawing.Point(10, 42);
            this.cboMenuItems.Name = "cboMenuItems";
            this.cboMenuItems.Size = new System.Drawing.Size(310, 24);

            this.lblQtyLabel.AutoSize = true; this.lblQtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblQtyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQtyLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblQtyLabel.Location = new System.Drawing.Point(330, 46);
            this.lblQtyLabel.Name = "lblQtyLabel"; this.lblQtyLabel.Text = "Qty:";

            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQty.Location = new System.Drawing.Point(365, 42);
            this.nudQty.Minimum = 1; this.nudQty.Maximum = 99; this.nudQty.Value = 1;
            this.nudQty.Name = "nudQty"; this.nudQty.Size = new System.Drawing.Size(60, 26);

            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(435, 38);
            this.btnAddItem.Name = "btnAddItem"; this.btnAddItem.Size = new System.Drawing.Size(130, 32);
            this.btnAddItem.Text = "+ Add Item";
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // ── Divider ───────────────────────────────────────
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlDivider.Location = new System.Drawing.Point(10, 492);
            this.pnlDivider.Name = "pnlDivider"; this.pnlDivider.Size = new System.Drawing.Size(578, 1);

            // ── Action buttons ────────────────────────────────
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 502);
            this.btnSave.Name = "btnSave"; this.btnSave.Size = new System.Drawing.Size(578, 44);
            this.btnSave.Text = "💾  Save Changes";
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(10, 554);
            this.btnCancelOrder.Name = "btnCancelOrder"; this.btnCancelOrder.Size = new System.Drawing.Size(578, 40);
            this.btnCancelOrder.Text = "✕  Cancel Entire Order";
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);

            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.btnClose.Location = new System.Drawing.Point(10, 602);
            this.btnClose.Name = "btnClose"; this.btnClose.Size = new System.Drawing.Size(578, 30);
            this.btnClose.Text = "Close";
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── EditOrderForm ─────────────────────────────────
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 645);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Order";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.lblOrderInfo, this.lblEditNote,
                this.dgvItems, this.lblTotal,
                this.pnlQtyButtons, this.pnlAddItem,
                this.pnlDivider, this.btnSave, this.btnCancelOrder, this.btnClose
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlQtyButtons.ResumeLayout(false);
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Label lblEditNote;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlQtyButtons;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Label lblAddItemTitle;
        private System.Windows.Forms.ComboBox cboMenuItems;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnClose;
    }
}