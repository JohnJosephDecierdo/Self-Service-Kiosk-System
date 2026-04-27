namespace OOP_FINAL_PROJECT
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Header
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.lblSub           = new System.Windows.Forms.Label();
            this.btnClose         = new System.Windows.Forms.Button();
            // Summary cards
            this.pnlCards         = new System.Windows.Forms.Panel();
            this.pnlTotal         = new System.Windows.Forms.Panel();
            this.lblTotalLbl      = new System.Windows.Forms.Label();
            this.lblTotalItems    = new System.Windows.Forms.Label();
            this.pnlLow           = new System.Windows.Forms.Panel();
            this.lblLowLbl        = new System.Windows.Forms.Label();
            this.lblLowStock      = new System.Windows.Forms.Label();
            this.pnlDamaged       = new System.Windows.Forms.Panel();
            this.lblDamagedLbl    = new System.Windows.Forms.Label();
            this.lblDamaged       = new System.Windows.Forms.Label();
            this.pnlLost          = new System.Windows.Forms.Panel();
            this.lblLostLbl       = new System.Windows.Forms.Label();
            this.lblLost          = new System.Windows.Forms.Label();
            // Filter bar
            this.pnlFilter        = new System.Windows.Forms.Panel();
            this.btnFilterAll     = new System.Windows.Forms.Button();
            this.btnFilterLow     = new System.Windows.Forms.Button();
            this.btnFilterDamaged = new System.Windows.Forms.Button();
            this.cboFilterCat     = new System.Windows.Forms.ComboBox();
            this.btnRefresh       = new System.Windows.Forms.Button();
            // Left: inventory grid
            this.dgvInventory     = new System.Windows.Forms.DataGridView();
            // Action buttons
            this.pnlActions       = new System.Windows.Forms.Panel();
            this.btnCheckIn       = new System.Windows.Forms.Button();
            this.btnCheckOut      = new System.Windows.Forms.Button();
            this.btnDamage        = new System.Windows.Forms.Button();
            this.btnLost          = new System.Windows.Forms.Button();
            this.btnRestoreCondition = new System.Windows.Forms.Button();
            // Right: form card
            this.pnlFormCard      = new System.Windows.Forms.Panel();
            this.lblFormTitle     = new System.Windows.Forms.Label();
            this.lblNameLbl       = new System.Windows.Forms.Label();
            this.txtItemName      = new System.Windows.Forms.TextBox();
            this.lblCatLbl        = new System.Windows.Forms.Label();
            this.cboCategory      = new System.Windows.Forms.ComboBox();
            this.lblQtyLbl        = new System.Windows.Forms.Label();
            this.nudQuantity      = new System.Windows.Forms.NumericUpDown();
            this.lblMinLbl        = new System.Windows.Forms.Label();
            this.nudMinStock      = new System.Windows.Forms.NumericUpDown();
            this.lblCondLbl       = new System.Windows.Forms.Label();
            this.cboCondition     = new System.Windows.Forms.ComboBox();
            this.lblLocLbl        = new System.Windows.Forms.Label();
            this.cboLocation      = new System.Windows.Forms.ComboBox();
            this.lblNotesLbl      = new System.Windows.Forms.Label();
            this.txtNotes         = new System.Windows.Forms.TextBox();
            this.pnlFormButtons   = new System.Windows.Forms.Panel();
            this.btnAdd           = new System.Windows.Forms.Button();
            this.btnUpdate        = new System.Windows.Forms.Button();
            this.btnDelete        = new System.Windows.Forms.Button();
            // Logs
            this.lblLogsTitle     = new System.Windows.Forms.Label();
            this.dgvLogs          = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlFormButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinStock)).BeginInit();
            this.SuspendLayout();

            // ── HEADER ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSub, this.btnClose });
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 58;

            this.lblTitle.AutoSize  = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(16, 10); this.lblTitle.Text = "📦  Inventory Management";

            this.lblSub.AutoSize  = true; this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblSub.Location  = new System.Drawing.Point(18, 36); this.lblSub.Text = "Track utensils, furniture, and equipment";

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location  = new System.Drawing.Point(1120, 14);
            this.btnClose.Size      = new System.Drawing.Size(70, 30);
            this.btnClose.Text      = "Close";
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── SUMMARY CARDS ─────────────────────────────────
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlCards.Location  = new System.Drawing.Point(0, 58);
            this.pnlCards.Size      = new System.Drawing.Size(1200, 80);
            this.pnlCards.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlTotal, this.pnlLow, this.pnlDamaged, this.pnlLost });

            MakeStatCard(this.pnlTotal,   this.lblTotalLbl,   this.lblTotalItems, "Total Items",    "0",  10,  8, System.Drawing.Color.FromArgb(13, 71, 161));
            MakeStatCard(this.pnlLow,     this.lblLowLbl,     this.lblLowStock,   "Low Stock",      "0", 220,  8, System.Drawing.Color.FromArgb(255, 111, 0));
            MakeStatCard(this.pnlDamaged, this.lblDamagedLbl, this.lblDamaged,    "Damaged",        "0", 430,  8, System.Drawing.Color.FromArgb(180, 60, 60));
            MakeStatCard(this.pnlLost,    this.lblLostLbl,    this.lblLost,       "Lost",           "0", 640,  8, System.Drawing.Color.FromArgb(100, 30, 100));

            // ── FILTER BAR ────────────────────────────────────
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Location = new System.Drawing.Point(10, 148);
            this.pnlFilter.Size     = new System.Drawing.Size(830, 42);
            this.pnlFilter.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnFilterAll, this.btnFilterLow, this.btnFilterDamaged, this.cboFilterCat, this.btnRefresh });

            StyleFilterBtn(this.btnFilterAll,     "All Items",     10,  6, 90,  System.Drawing.Color.FromArgb(13,71,161));
            StyleFilterBtn(this.btnFilterLow,     "⚠ Low Stock",  108, 6, 110, System.Drawing.Color.FromArgb(255,111,0));
            StyleFilterBtn(this.btnFilterDamaged, "🔴 Dmg/Lost",  226, 6, 110, System.Drawing.Color.FromArgb(180,60,60));
            this.btnFilterAll.Click     += new System.EventHandler(this.btnFilterAll_Click);
            this.btnFilterLow.Click     += new System.EventHandler(this.btnFilterLow_Click);
            this.btnFilterDamaged.Click += new System.EventHandler(this.btnFilterDamaged_Click);

            this.cboFilterCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCat.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterCat.Location = new System.Drawing.Point(344, 8);
            this.cboFilterCat.Size     = new System.Drawing.Size(150, 24);
            this.cboFilterCat.Items.AddRange(new object[] { "All Categories", "Utensils", "Furniture", "Equipment", "Supplies" });
            this.cboFilterCat.SelectedIndex = 0;
            this.cboFilterCat.SelectedIndexChanged += new System.EventHandler(this.cboFilterCat_SelectedIndexChanged);

            this.btnRefresh.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor  = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.Location   = new System.Drawing.Point(502, 6);
            this.btnRefresh.Size       = new System.Drawing.Size(80, 28);
            this.btnRefresh.Text       = "↺ Refresh";
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33,150,243);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // ── INVENTORY GRID ────────────────────────────────
            this.dgvInventory.AllowUserToAddRows  = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor     = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.Location            = new System.Drawing.Point(10, 198);
            this.dgvInventory.ReadOnly            = true;
            this.dgvInventory.RowHeadersVisible   = false;
            this.dgvInventory.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.MultiSelect         = false;
            this.dgvInventory.Size                = new System.Drawing.Size(830, 280);
            this.dgvInventory.SelectionChanged   += new System.EventHandler(this.dgvInventory_SelectionChanged);
            SetGridStyle(this.dgvInventory);

            // ── ACTION BUTTONS ────────────────────────────────
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Location  = new System.Drawing.Point(10, 486);
            this.pnlActions.Size      = new System.Drawing.Size(830, 52);
            this.pnlActions.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnCheckIn, this.btnCheckOut, this.btnDamage, this.btnLost, this.btnRestoreCondition });

            StyleActionBtn(this.btnCheckIn,          "✔ Check In",     6,  8, 150, System.Drawing.Color.FromArgb(39,174,96));
            StyleActionBtn(this.btnCheckOut,         "✘ Check Out",   162, 8, 150, System.Drawing.Color.FromArgb(255,111,0));
            StyleActionBtn(this.btnDamage,           "⚠ Damage",      318, 8, 140, System.Drawing.Color.FromArgb(180,100,0));
            StyleActionBtn(this.btnLost,             "✕ Lost",        464, 8, 130, System.Drawing.Color.FromArgb(180,60,60));
            StyleActionBtn(this.btnRestoreCondition, "↺ Restore",     600, 8, 130, System.Drawing.Color.FromArgb(33,150,243));
            this.btnCheckIn.Click           += new System.EventHandler(this.btnCheckIn_Click);
            this.btnCheckOut.Click          += new System.EventHandler(this.btnCheckOut_Click);
            this.btnDamage.Click            += new System.EventHandler(this.btnDamage_Click);
            this.btnLost.Click              += new System.EventHandler(this.btnLost_Click);
            this.btnRestoreCondition.Click  += new System.EventHandler(this.btnRestoreCondition_Click);

            // ── FORM CARD (right panel) ───────────────────────
            this.pnlFormCard.BackColor   = System.Drawing.Color.White;
            this.pnlFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormCard.Location    = new System.Drawing.Point(854, 148);
            this.pnlFormCard.Size        = new System.Drawing.Size(340, 390);
            this.pnlFormCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFormTitle,
                this.lblNameLbl, this.txtItemName,
                this.lblCatLbl,  this.cboCategory,
                this.lblQtyLbl,  this.nudQuantity,
                this.lblMinLbl,  this.nudMinStock,
                this.lblCondLbl, this.cboCondition,
                this.lblLocLbl,  this.cboLocation,
                this.lblNotesLbl, this.txtNotes,
                this.pnlFormButtons
            });

            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(13,71,161);
            this.lblFormTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Height    = 34;
            this.lblFormTitle.Padding   = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFormTitle.Text      = "Add / Edit Item";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            MakeFieldRow(this.lblNameLbl, this.txtItemName,  "Name:",      10, 44);
            MakeFieldRow(this.lblCatLbl,  this.cboCategory,  "Category:",  10, 84);
            MakeFieldRow(this.lblQtyLbl,  this.nudQuantity,  "Qty:",       10, 124);
            MakeFieldRow(this.lblMinLbl,  this.nudMinStock,  "Min Stock:", 10, 164);
            MakeFieldRow(this.lblCondLbl, this.cboCondition, "Condition:", 10, 204);
            MakeFieldRow(this.lblLocLbl,  this.cboLocation,  "Location:",  10, 244);
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new object[] { "Utensils", "Furniture", "Equipment", "Supplies" });
            this.cboCategory.SelectedIndex = 0;

            this.nudQuantity.Minimum = 0; this.nudQuantity.Maximum = 9999;
            this.nudMinStock.Minimum = 0; this.nudMinStock.Maximum = 999; this.nudMinStock.Value = 1;

            this.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondition.Items.AddRange(new object[] { "Good", "Damaged", "Lost" });
            this.cboCondition.SelectedIndex = 0;

            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.Items.AddRange(new object[] { "Kitchen", "Dining Area", "Storage", "Counter", "Office" });
            this.cboLocation.SelectedIndex = 0;

            this.lblNotesLbl.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotesLbl.ForeColor = System.Drawing.Color.FromArgb(80,80,80);
            this.lblNotesLbl.Location  = new System.Drawing.Point(10, 284);
            this.lblNotesLbl.Size      = new System.Drawing.Size(80, 20);
            this.lblNotesLbl.Text      = "Notes:";

            this.txtNotes.Location   = new System.Drawing.Point(10, 306);
            this.txtNotes.Multiline  = true;
            this.txtNotes.Size       = new System.Drawing.Size(318, 40);
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Form buttons
            this.pnlFormButtons.Location = new System.Drawing.Point(10, 352);
            this.pnlFormButtons.Size     = new System.Drawing.Size(318, 30);
            this.pnlFormButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnAdd, this.btnUpdate, this.btnDelete });

            StyleFormBtn(this.btnAdd,    "+ Add",    0,  0, 100, System.Drawing.Color.FromArgb(255,111,0));
            StyleFormBtn(this.btnUpdate, "✎ Update", 106, 0, 100, System.Drawing.Color.FromArgb(33,150,243));
            StyleFormBtn(this.btnDelete, "🗑 Delete", 212, 0, 100, System.Drawing.Color.FromArgb(180,60,60));
            this.btnAdd.Click    += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ── LOGS ──────────────────────────────────────────
            this.lblLogsTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogsTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblLogsTitle.Location  = new System.Drawing.Point(10, 546);
            this.lblLogsTitle.Size      = new System.Drawing.Size(400, 22);
            this.lblLogsTitle.Text      = "Activity Log  (select item to filter, or shows all)";

            this.dgvLogs.AllowUserToAddRows  = false;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor     = System.Drawing.Color.White;
            this.dgvLogs.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.Location            = new System.Drawing.Point(10, 570);
            this.dgvLogs.ReadOnly            = true;
            this.dgvLogs.RowHeadersVisible   = false;
            this.dgvLogs.Size                = new System.Drawing.Size(1184, 170);
            SetGridStyle(this.dgvLogs);

            // ── FORM ──────────────────────────────────────────
            this.BackColor     = System.Drawing.Color.FromArgb(240, 244, 250);
            this.ClientSize    = new System.Drawing.Size(1204, 755);
            this.MinimumSize   = new System.Drawing.Size(1204, 755);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name          = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Inventory Management";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.pnlCards,
                this.pnlFilter, this.dgvInventory,
                this.pnlActions, this.pnlFormCard,
                this.lblLogsTitle, this.dgvLogs
            });

            this.pnlHeader.ResumeLayout(false);  this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlFormCard.ResumeLayout(false); this.pnlFormCard.PerformLayout();
            this.pnlFormButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinStock)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Helper methods ────────────────────────────────────
        private void MakeStatCard(System.Windows.Forms.Panel pnl,
            System.Windows.Forms.Label lblL, System.Windows.Forms.Label lblV,
            string label, string val, int x, int y, System.Drawing.Color color)
        {
            pnl.BackColor = color; pnl.Location = new System.Drawing.Point(x, y);
            pnl.Size = new System.Drawing.Size(200, 62);
            pnl.Controls.AddRange(new System.Windows.Forms.Control[] { lblL, lblV });
            lblL.AutoSize = true; lblL.BackColor = System.Drawing.Color.Transparent;
            lblL.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblL.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            lblL.Location = new System.Drawing.Point(10, 8); lblL.Text = label;
            lblV.AutoSize = true; lblV.BackColor = System.Drawing.Color.Transparent;
            lblV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblV.ForeColor = System.Drawing.Color.White;
            lblV.Location = new System.Drawing.Point(8, 24); lblV.Text = val;
        }

        private void StyleFilterBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, System.Drawing.Color color)
        {
            btn.BackColor = color; btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y); btn.Size = new System.Drawing.Size(w, 28);
            btn.Text = text; btn.FlatAppearance.BorderSize = 0;
        }

        private void StyleActionBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, System.Drawing.Color color)
        {
            btn.BackColor = color; btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y); btn.Size = new System.Drawing.Size(w, 34);
            btn.Text = text; btn.FlatAppearance.BorderSize = 0;
        }

        private void StyleFormBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, System.Drawing.Color color)
        {
            btn.BackColor = color; btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y); btn.Size = new System.Drawing.Size(w, 30);
            btn.Text = text; btn.FlatAppearance.BorderSize = 0;
        }

        private void MakeFieldRow(System.Windows.Forms.Label lbl,
            System.Windows.Forms.Control ctrl, string labelText, int left, int top)
        {
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            lbl.Location = new System.Drawing.Point(left, top + 2);
            lbl.Size = new System.Drawing.Size(80, 20); lbl.Text = labelText;
            ctrl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            ctrl.Location = new System.Drawing.Point(left + 85, top - 1);
            ctrl.Size = new System.Drawing.Size(240, 24);
        }

        private void SetGridStyle(System.Windows.Forms.DataGridView dgv)
        {
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 255);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
        }

        // ── Declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel         pnlHeader, pnlCards, pnlFilter, pnlActions, pnlFormCard, pnlFormButtons;
        private System.Windows.Forms.Label         lblTitle, lblSub;
        private System.Windows.Forms.Button        btnClose;
        private System.Windows.Forms.Panel         pnlTotal, pnlLow, pnlDamaged, pnlLost;
        private System.Windows.Forms.Label         lblTotalLbl, lblTotalItems, lblLowLbl, lblLowStock;
        private System.Windows.Forms.Label         lblDamagedLbl, lblDamaged, lblLostLbl, lblLost;
        private System.Windows.Forms.Button        btnFilterAll, btnFilterLow, btnFilterDamaged, btnRefresh;
        private System.Windows.Forms.ComboBox      cboFilterCat;
        private System.Windows.Forms.DataGridView  dgvInventory;
        private System.Windows.Forms.Button        btnCheckIn, btnCheckOut, btnDamage, btnLost, btnRestoreCondition;
        private System.Windows.Forms.Label         lblFormTitle, lblNameLbl, lblCatLbl, lblQtyLbl;
        private System.Windows.Forms.Label         lblMinLbl, lblCondLbl, lblLocLbl, lblNotesLbl;
        private System.Windows.Forms.TextBox       txtItemName, txtNotes;
        private System.Windows.Forms.ComboBox      cboCategory, cboCondition, cboLocation;
        private System.Windows.Forms.NumericUpDown nudQuantity, nudMinStock;
        private System.Windows.Forms.Button        btnAdd, btnUpdate, btnDelete;
        private System.Windows.Forms.Label         lblLogsTitle;
        private System.Windows.Forms.DataGridView  dgvLogs;
    }
}
