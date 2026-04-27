namespace OOP_FINAL_PROJECT
{
    partial class GCashPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblGCash = new Label();
            pnlOrderInfo = new Panel();
            lblOrderNum = new Label();
            lblAmountLbl = new Label();
            lblAmountVal = new Label();
            pnlDivider1 = new Panel();
            lblSummaryLbl = new Label();
            dgvItems = new DataGridView();
            colQty = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            pnlTotalBar = new Panel();
            lblTotal = new Label();
            lblTotalVal = new Label();
            pnlDivider2 = new Panel();
            lblScanHint = new Label();
            picQR = new PictureBox();
            pnlAcctBar = new Panel();
            lblAcctName = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            pnlTotalBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            pnlAcctBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 100, 220);
            pnlHeader.Controls.Add(lblGCash);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(420, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblGCash
            // 
            lblGCash.BackColor = Color.Transparent;
            lblGCash.Dock = DockStyle.Fill;
            lblGCash.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblGCash.ForeColor = Color.White;
            lblGCash.Location = new Point(0, 0);
            lblGCash.Name = "lblGCash";
            lblGCash.Size = new Size(420, 60);
            lblGCash.TabIndex = 0;
            lblGCash.Text = "💙  GCash";
            lblGCash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOrderInfo
            // 
            pnlOrderInfo.BackColor = Color.FromArgb(0, 85, 200);
            pnlOrderInfo.Controls.Add(lblOrderNum);
            pnlOrderInfo.Controls.Add(lblAmountLbl);
            pnlOrderInfo.Controls.Add(lblAmountVal);
            pnlOrderInfo.Location = new Point(0, 60);
            pnlOrderInfo.Name = "pnlOrderInfo";
            pnlOrderInfo.Size = new Size(420, 100);
            pnlOrderInfo.TabIndex = 1;
            // 
            // lblOrderNum
            // 
            lblOrderNum.BackColor = Color.FromArgb(0, 55, 150);
            lblOrderNum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrderNum.ForeColor = Color.White;
            lblOrderNum.Location = new Point(155, 10);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(110, 24);
            lblOrderNum.TabIndex = 0;
            lblOrderNum.Text = "Order #...";
            lblOrderNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmountLbl
            // 
            lblAmountLbl.BackColor = Color.Transparent;
            lblAmountLbl.Font = new Font("Segoe UI", 9F);
            lblAmountLbl.ForeColor = Color.FromArgb(180, 215, 255);
            lblAmountLbl.Location = new Point(0, 42);
            lblAmountLbl.Name = "lblAmountLbl";
            lblAmountLbl.Size = new Size(420, 18);
            lblAmountLbl.TabIndex = 1;
            lblAmountLbl.Text = "Amount to Pay";
            lblAmountLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmountVal
            // 
            lblAmountVal.BackColor = Color.Transparent;
            lblAmountVal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAmountVal.ForeColor = Color.White;
            lblAmountVal.Location = new Point(0, 60);
            lblAmountVal.Name = "lblAmountVal";
            lblAmountVal.Size = new Size(420, 36);
            lblAmountVal.TabIndex = 2;
            lblAmountVal.Text = "₱0.00";
            lblAmountVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider1
            // 
            pnlDivider1.BackColor = Color.FromArgb(220, 228, 248);
            pnlDivider1.Location = new Point(14, 174);
            pnlDivider1.Name = "pnlDivider1";
            pnlDivider1.Size = new Size(392, 1);
            pnlDivider1.TabIndex = 0;
            // 
            // lblSummaryLbl
            // 
            lblSummaryLbl.BackColor = Color.FromArgb(225, 238, 255);
            lblSummaryLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSummaryLbl.ForeColor = Color.FromArgb(0, 75, 180);
            lblSummaryLbl.Location = new Point(0, 162);
            lblSummaryLbl.Name = "lblSummaryLbl";
            lblSummaryLbl.Size = new Size(420, 28);
            lblSummaryLbl.TabIndex = 2;
            lblSummaryLbl.Text = "  \U0001f9fe  Order Summary";
            lblSummaryLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(225, 238, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 75, 180);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colQty, colName, colSubtotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 238, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 75, 180);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.FromArgb(225, 232, 250);
            dgvItems.Location = new Point(14, 190);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(392, 120);
            dgvItems.TabIndex = 3;
            // 
            // colQty
            // 
            colQty.FillWeight = 15F;
            colQty.HeaderText = "Qty";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 60F;
            colName.HeaderText = "Item";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 75, 180);
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle2;
            colSubtotal.FillWeight = 25F;
            colSubtotal.HeaderText = "Amount";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // pnlTotalBar
            // 
            pnlTotalBar.BackColor = Color.FromArgb(235, 243, 255);
            pnlTotalBar.Controls.Add(lblTotal);
            pnlTotalBar.Controls.Add(lblTotalVal);
            pnlTotalBar.Location = new Point(14, 314);
            pnlTotalBar.Name = "pnlTotalBar";
            pnlTotalBar.Size = new Size(392, 36);
            pnlTotalBar.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(80, 100, 150);
            lblTotal.Location = new Point(10, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 19);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "TOTAL";
            // 
            // lblTotalVal
            // 
            lblTotalVal.BackColor = Color.Transparent;
            lblTotalVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(0, 75, 180);
            lblTotalVal.Location = new Point(240, 5);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(140, 26);
            lblTotalVal.TabIndex = 1;
            lblTotalVal.Text = "₱0.00";
            lblTotalVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlDivider2
            // 
            pnlDivider2.BackColor = Color.FromArgb(220, 228, 248);
            pnlDivider2.Location = new Point(14, 356);
            pnlDivider2.Name = "pnlDivider2";
            pnlDivider2.Size = new Size(392, 1);
            pnlDivider2.TabIndex = 5;
            // 
            // lblScanHint
            // 
            lblScanHint.BackColor = Color.White;
            lblScanHint.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblScanHint.ForeColor = Color.FromArgb(100, 120, 170);
            lblScanHint.Location = new Point(0, 362);
            lblScanHint.Name = "lblScanHint";
            lblScanHint.Size = new Size(420, 20);
            lblScanHint.TabIndex = 6;
            lblScanHint.Text = "Scan the QR code below using your GCash app";
            lblScanHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picQR
            // 
            picQR.BackColor = Color.White;
            picQR.BorderStyle = BorderStyle.FixedSingle;
            picQR.Location = new Point(14, 386);
            picQR.Name = "picQR";
            picQR.Size = new Size(392, 320);
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            picQR.TabIndex = 7;
            picQR.TabStop = false;
            // 
            // pnlAcctBar
            // 
            pnlAcctBar.BackColor = Color.FromArgb(0, 65, 170);
            pnlAcctBar.Controls.Add(lblAcctName);
            pnlAcctBar.Location = new Point(0, 712);
            pnlAcctBar.Name = "pnlAcctBar";
            pnlAcctBar.Size = new Size(420, 28);
            pnlAcctBar.TabIndex = 8;
            // 
            // lblAcctName
            // 
            lblAcctName.BackColor = Color.Transparent;
            lblAcctName.Dock = DockStyle.Fill;
            lblAcctName.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAcctName.ForeColor = Color.FromArgb(185, 215, 255);
            lblAcctName.Location = new Point(0, 0);
            lblAcctName.Name = "lblAcctName";
            lblAcctName.Size = new Size(420, 28);
            lblAcctName.TabIndex = 0;
            lblAcctName.Text = "JOHN JOSEPH D. DECIERDO   |   09215103271";
            lblAcctName.TextAlign = ContentAlignment.MiddleCenter;
            lblAcctName.Click += lblAcctName_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(39, 174, 96);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(10, 748);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(264, 40);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "✔  Payment Received";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(204, 50, 50);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(282, 748);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "✕  Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // GCashPaymentForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(420, 798);
            Controls.Add(pnlHeader);
            Controls.Add(pnlOrderInfo);
            Controls.Add(lblSummaryLbl);
            Controls.Add(dgvItems);
            Controls.Add(pnlTotalBar);
            Controls.Add(pnlDivider2);
            Controls.Add(lblScanHint);
            Controls.Add(picQR);
            Controls.Add(pnlAcctBar);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GCashPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCash Payment";
            pnlHeader.ResumeLayout(false);
            pnlOrderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            pnlTotalBar.ResumeLayout(false);
            pnlTotalBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            pnlAcctBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel               pnlHeader;
        private System.Windows.Forms.Label               lblGCash;
        private System.Windows.Forms.Panel               pnlOrderInfo;
        private System.Windows.Forms.Label               lblOrderNum;
        private System.Windows.Forms.Label               lblAmountLbl;
        private System.Windows.Forms.Label               lblAmountVal;
        private System.Windows.Forms.Panel               pnlDivider1;
        private System.Windows.Forms.Label               lblSummaryLbl;
        private System.Windows.Forms.DataGridView        dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Panel               pnlTotalBar;
        private System.Windows.Forms.Label               lblTotal;
        private System.Windows.Forms.Label               lblTotalVal;
        private System.Windows.Forms.Panel               pnlDivider2;
        private System.Windows.Forms.Label               lblScanHint;
        private System.Windows.Forms.PictureBox          picQR;
        private System.Windows.Forms.Panel               pnlAcctBar;
        private System.Windows.Forms.Label               lblAcctName;
        private System.Windows.Forms.Button              btnConfirm;
        private System.Windows.Forms.Button              btnCancel;
    }
}
