namespace OOP_FINAL_PROJECT
{
    partial class ReceiptForm
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
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreTagline = new System.Windows.Forms.Label();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.pnlTotals = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblMethodVal = new System.Windows.Forms.Label();
            this.pnlTotalBar = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPaidVal = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeVal = new System.Windows.Forms.Label();
            this.pnlDivider3 = new System.Windows.Forms.Panel();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.pnlTotalBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // ── pnlHeader — Dark Blue ─────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStoreName, this.lblStoreTagline
            });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 75;
            this.pnlHeader.Name = "pnlHeader";

            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.Location = new System.Drawing.Point(0, 10);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(400, 36);
            this.lblStoreName.Text = "DECIERDO KIOSK";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStoreTagline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStoreTagline.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblStoreTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreTagline.Location = new System.Drawing.Point(0, 48);
            this.lblStoreTagline.Name = "lblStoreTagline";
            this.lblStoreTagline.Size = new System.Drawing.Size(400, 20);
            this.lblStoreTagline.Text = "Self-Service Ordering System";
            this.lblStoreTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── pnlOrderInfo — Light Blue ─────────────────────
            this.pnlOrderInfo.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlOrderInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOrderNum, this.lblDateTime
            });
            this.pnlOrderInfo.Location = new System.Drawing.Point(0, 75);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(400, 52);

            this.lblOrderNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblOrderNum.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblOrderNum.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderNum.Location = new System.Drawing.Point(0, 6);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(400, 26);
            this.lblOrderNum.Text = "Order # ...";
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Location = new System.Drawing.Point(0, 32);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(400, 18);
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Divider 1 ─────────────────────────────────────
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlDivider1.Location = new System.Drawing.Point(20, 134);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(360, 1);

            // ── Items label ───────────────────────────────────
            this.lblItemsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblItemsTitle.Location = new System.Drawing.Point(20, 142);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Text = "ORDER ITEMS";

            // ── dgvItems ──────────────────────────────────────
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.dgvItems.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colQty, this.colName, this.colPrice, this.colSubtotal
            });
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvItems.Location = new System.Drawing.Point(20, 164);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(360, 170);

            this.colQty.HeaderText = "Qty"; this.colQty.Name = "colQty"; this.colQty.FillWeight = 15;
            this.colName.HeaderText = "Item"; this.colName.Name = "colName"; this.colName.FillWeight = 45;
            this.colPrice.HeaderText = "Price"; this.colPrice.Name = "colPrice"; this.colPrice.FillWeight = 20;
            this.colSubtotal.HeaderText = "Subtotal"; this.colSubtotal.Name = "colSubtotal"; this.colSubtotal.FillWeight = 20;

            // ── Divider 2 ─────────────────────────────────────
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlDivider2.Location = new System.Drawing.Point(20, 340);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(360, 1);

            // ── pnlTotals — White ─────────────────────────────
            this.pnlTotals.BackColor = System.Drawing.Color.White;
            this.pnlTotals.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSubtotal, this.lblSubtotalVal,
                this.lblMethod,   this.lblMethodVal,
                this.pnlTotalBar,
                this.lblPaid,     this.lblPaidVal,
                this.lblChange,   this.lblChangeVal
            });
            this.pnlTotals.Location = new System.Drawing.Point(20, 348);
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Size = new System.Drawing.Size(360, 175);

            // Subtotal row
            MakeTotalRow(this.lblSubtotal, this.lblSubtotalVal, "Subtotal:", "₱0.00", 0,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.FromArgb(80, 80, 80), false);
            // Payment method row
            MakeTotalRow(this.lblMethod, this.lblMethodVal, "Payment Method:", "---", 28,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.FromArgb(80, 80, 80), false);

            // pnlTotalBar — Orange highlight for total
            this.pnlTotalBar.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlTotalBar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTotal, this.lblTotalVal
            });
            this.pnlTotalBar.Location = new System.Drawing.Point(0, 60);
            this.pnlTotalBar.Name = "pnlTotalBar";
            this.pnlTotalBar.Size = new System.Drawing.Size(360, 38);

            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(10, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 26);
            this.lblTotal.Text = "TOTAL:";

            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblTotalVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVal.Location = new System.Drawing.Point(200, 6);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(150, 26);
            this.lblTotalVal.Text = "₱0.00";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Paid row
            MakeTotalRow(this.lblPaid, this.lblPaidVal, "Amount Paid:", "₱0.00", 106,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.FromArgb(67, 160, 71), false);
            // Change row
            MakeTotalRow(this.lblChange, this.lblChangeVal, "Change:", "₱0.00", 134,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.FromArgb(33, 150, 243), true);

            // ── Divider 3 ─────────────────────────────────────
            this.pnlDivider3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlDivider3.Location = new System.Drawing.Point(20, 530);
            this.pnlDivider3.Name = "pnlDivider3";
            this.pnlDivider3.Size = new System.Drawing.Size(360, 1);

            // ── Thank you ─────────────────────────────────────
            this.lblThankYou.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThankYou.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblThankYou.Location = new System.Drawing.Point(0, 540);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(400, 24);
            this.lblThankYou.Text = "Thank you for your order! Please come again.";
            this.lblThankYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Buttons ───────────────────────────────────────
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(20, 575);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(175, 40);
            this.btnPrint.Text = "🖨 Print Receipt";
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(205, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.Text = "Close";
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── ReceiptForm ───────────────────────────────────
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 630);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.pnlOrderInfo,
                this.pnlDivider1, this.lblItemsTitle, this.dgvItems,
                this.pnlDivider2, this.pnlTotals,
                this.pnlDivider3, this.lblThankYou,
                this.btnPrint, this.btnClose
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlTotals.ResumeLayout(false);
            this.pnlTotalBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
        }

        private void MakeTotalRow(
            System.Windows.Forms.Label lbl, System.Windows.Forms.Label lblVal,
            string labelText, string valueText, int top,
            System.Drawing.Color labelColor, System.Drawing.Color valueColor, bool bold)
        {
            var font = bold
                ? new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
                : new System.Drawing.Font("Segoe UI", 9F);

            lbl.Font = font;
            lbl.ForeColor = labelColor;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Location = new System.Drawing.Point(10, top);
            lbl.Size = new System.Drawing.Size(180, 22);
            lbl.Text = labelText;

            lblVal.Font = font;
            lblVal.ForeColor = valueColor;
            lblVal.BackColor = System.Drawing.Color.Transparent;
            lblVal.Location = new System.Drawing.Point(200, top);
            lblVal.Size = new System.Drawing.Size(150, 22);
            lblVal.Text = valueText;
            lblVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        // Control declarations
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreTagline;
        private System.Windows.Forms.Panel pnlOrderInfo;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Panel pnlTotals;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblMethodVal;
        private System.Windows.Forms.Panel pnlTotalBar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPaidVal;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeVal;
        private System.Windows.Forms.Panel pnlDivider3;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}