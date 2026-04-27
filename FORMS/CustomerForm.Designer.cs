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
            // ── Three panels that swap ────────────────────────
            this.pnlIdle         = new System.Windows.Forms.Panel();
            this.pnlOrdering     = new System.Windows.Forms.Panel();
            this.pnlConfirmation = new System.Windows.Forms.Panel();

            // ── IDLE panel controls ───────────────────────────
            this.lblIdleTitle    = new System.Windows.Forms.Label();
            this.lblIdleTouch    = new System.Windows.Forms.Label();
            this.lblIdleSub      = new System.Windows.Forms.Label();
            this.lblIdleLogo     = new System.Windows.Forms.Label();

            // ── ORDERING panel controls ───────────────────────
            this.pnlHeader       = new System.Windows.Forms.Panel();
            this.lblHeaderTitle  = new System.Windows.Forms.Label();
            this.lblLive         = new System.Windows.Forms.Label();
            this.pnlCategory     = new System.Windows.Forms.Panel();
            this.lblCategories   = new System.Windows.Forms.Label();
            this.btnAll          = new System.Windows.Forms.Button();
            this.btnBurgers      = new System.Windows.Forms.Button();
            this.btnChicken      = new System.Windows.Forms.Button();
            this.btnSides        = new System.Windows.Forms.Button();
            this.btnDrinks       = new System.Windows.Forms.Button();
            this.btnDesserts     = new System.Windows.Forms.Button();
            this.lblMenuTitle    = new System.Windows.Forms.Label();
            this.flpMenu         = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCart         = new System.Windows.Forms.Panel();
            this.lblCartTitle    = new System.Windows.Forms.Label();
            this.dgvCart         = new System.Windows.Forms.DataGridView();
            this.colItem         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal        = new System.Windows.Forms.Label();
            this.btnRemove       = new System.Windows.Forms.Button();
            this.btnIncrease     = new System.Windows.Forms.Button();
            this.btnPlace        = new System.Windows.Forms.Button();
            this.btnClear        = new System.Windows.Forms.Button();

            // ── CONFIRMATION panel controls ───────────────────
            this.lblConfirmTitle  = new System.Windows.Forms.Label();
            this.lblConfirmSub    = new System.Windows.Forms.Label();
            this.lblBigOrderNum   = new System.Windows.Forms.Label();
            this.lblConfirmTotal  = new System.Windows.Forms.Label();
            this.lblConfirmItems  = new System.Windows.Forms.Label();
            this.lstConfirmItems  = new System.Windows.Forms.ListBox();
            this.lblConfirmHint   = new System.Windows.Forms.Label();
            this.btnPrintReceipt  = new System.Windows.Forms.Button();
            this.btnNewOrder      = new System.Windows.Forms.Button();
            this.lblCountdown     = new System.Windows.Forms.Label();

            this.pnlIdle.SuspendLayout();
            this.pnlOrdering.SuspendLayout();
            this.pnlConfirmation.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();


            // ════════════════════════════════════════════════
            //  PANEL 1 — IDLE SCREEN  (fullscreen, blue)
            // ════════════════════════════════════════════════
            this.pnlIdle.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlIdle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlIdle.Name      = "pnlIdle";
            this.pnlIdle.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.pnlIdle.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblIdleLogo, this.lblIdleTitle, this.lblIdleTouch, this.lblIdleSub
            });

            this.lblIdleLogo.AutoSize  = false;
            this.lblIdleLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblIdleLogo.Font      = new System.Drawing.Font("Segoe UI Emoji", 80F);
            this.lblIdleLogo.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblIdleLogo.Location  = new System.Drawing.Point(0, 120);
            this.lblIdleLogo.Size      = new System.Drawing.Size(1000, 140);
            this.lblIdleLogo.Text      = "🍔";
            this.lblIdleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblIdleTitle.AutoSize  = false;
            this.lblIdleTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblIdleTitle.Font      = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblIdleTitle.ForeColor = System.Drawing.Color.White;
            this.lblIdleTitle.Location  = new System.Drawing.Point(0, 280);
            this.lblIdleTitle.Size      = new System.Drawing.Size(1000, 70);
            this.lblIdleTitle.Text      = "DECIERDO KIOSK";
            this.lblIdleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblIdleTouch.AutoSize  = false;
            this.lblIdleTouch.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.lblIdleTouch.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblIdleTouch.ForeColor = System.Drawing.Color.White;
            this.lblIdleTouch.Location  = new System.Drawing.Point(250, 390);
            this.lblIdleTouch.Size      = new System.Drawing.Size(500, 64);
            this.lblIdleTouch.Text      = "👆  TOUCH TO ORDER";
            this.lblIdleTouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdleTouch.Cursor    = System.Windows.Forms.Cursors.Hand;

            this.lblIdleSub.AutoSize  = false;
            this.lblIdleSub.BackColor = System.Drawing.Color.Transparent;
            this.lblIdleSub.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIdleSub.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblIdleSub.Location  = new System.Drawing.Point(0, 475);
            this.lblIdleSub.Size      = new System.Drawing.Size(1000, 30);
            this.lblIdleSub.Text      = "Fast • Easy • Contactless Ordering";
            this.lblIdleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // ════════════════════════════════════════════════
            //  PANEL 2 — ORDERING SCREEN
            // ════════════════════════════════════════════════
            this.pnlOrdering.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrdering.Name      = "pnlOrdering";
            this.pnlOrdering.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOrdering.Visible   = false;
            this.pnlOrdering.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.pnlCategory, this.lblMenuTitle, this.flpMenu, this.pnlCart
            });

            // Header bar
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblHeaderTitle, this.lblLive });
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 48;
            this.pnlHeader.Name   = "pnlHeader";

            this.lblHeaderTitle.AutoSize  = true;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location  = new System.Drawing.Point(16, 12);
            this.lblHeaderTitle.Text      = "CUSTOMER — ORDERING";

            this.lblLive.AutoSize  = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblLive.Location  = new System.Drawing.Point(400, 15);
            this.lblLive.Text      = "● LIVE";

            // Category sidebar
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlCategory.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCategories, this.btnAll, this.btnBurgers,
                this.btnChicken, this.btnSides, this.btnDrinks, this.btnDesserts
            });
            this.pnlCategory.Location = new System.Drawing.Point(0, 48);
            this.pnlCategory.Size     = new System.Drawing.Size(150, 632);

            this.lblCategories.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location  = new System.Drawing.Point(10, 20);
            this.lblCategories.Size      = new System.Drawing.Size(130, 23);
            this.lblCategories.Text      = "CATEGORIES";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            var catBtns = new[] { btnAll, btnBurgers, btnChicken, btnSides, btnDrinks, btnDesserts };
            var catNames = new[] { "All","Burgers","Chicken","Sides","Drinks","Desserts" };
            var catHandlers = new System.EventHandler[] {
                btnAll_Click, btnBurgers_Click, btnChicken_Click,
                btnSides_Click, btnDrinks_Click, btnDesserts_Click
            };
            for (int i = 0; i < catBtns.Length; i++)
            {
                catBtns[i].BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
                catBtns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                catBtns[i].Font      = new System.Drawing.Font("Segoe UI", 9F);
                catBtns[i].ForeColor = System.Drawing.Color.White;
                catBtns[i].Location  = new System.Drawing.Point(10, 60 + i * 50);
                catBtns[i].Size      = new System.Drawing.Size(130, 40);
                catBtns[i].Text      = catNames[i];
                catBtns[i].FlatAppearance.BorderSize = 0;
                catBtns[i].Cursor    = System.Windows.Forms.Cursors.Hand;
                catBtns[i].Click    += catHandlers[i];
            }

            // Menu title + grid
            this.lblMenuTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.Location  = new System.Drawing.Point(160, 58);
            this.lblMenuTitle.Size      = new System.Drawing.Size(440, 28);
            this.lblMenuTitle.Text      = "MENU";

            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor  = System.Drawing.Color.WhiteSmoke;
            this.flpMenu.Location   = new System.Drawing.Point(160, 93);
            this.flpMenu.Size       = new System.Drawing.Size(450, 587);


            // Cart panel
            this.pnlCart.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlCart.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCartTitle, this.dgvCart, this.lblTotal,
                this.btnRemove, this.btnIncrease, this.btnPlace, this.btnClear
            });
            this.pnlCart.Location = new System.Drawing.Point(625, 48);
            this.pnlCart.Size     = new System.Drawing.Size(375, 632);

            this.lblCartTitle.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.Location  = new System.Drawing.Point(5, 10);
            this.lblCartTitle.Size      = new System.Drawing.Size(363, 25);
            this.lblCartTitle.Text      = "YOUR ORDER";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.dgvCart.AllowUserToAddRows    = false;
            this.dgvCart.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor       = System.Drawing.Color.White;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colItem, this.colQty, this.colSubtotal });
            this.dgvCart.Location      = new System.Drawing.Point(5, 40);
            this.dgvCart.ReadOnly      = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size          = new System.Drawing.Size(363, 320);
            this.colItem.HeaderText    = "Item";     this.colItem.Name    = "colItem";
            this.colQty.HeaderText     = "Qty";      this.colQty.Name     = "colQty";
            this.colSubtotal.HeaderText= "Subtotal"; this.colSubtotal.Name= "colSubtotal";

            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location  = new System.Drawing.Point(5, 368);
            this.lblTotal.Size      = new System.Drawing.Size(363, 28);
            this.lblTotal.Text      = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location  = new System.Drawing.Point(5, 404);
            this.btnRemove.Size      = new System.Drawing.Size(114, 38);
            this.btnRemove.Text      = "−  Decrease";
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Click    += new System.EventHandler(this.btnRemove_Click);

            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.Location  = new System.Drawing.Point(122, 404);
            this.btnIncrease.Size      = new System.Drawing.Size(114, 38);
            this.btnIncrease.Text      = "+  Increase";
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.Click    += new System.EventHandler(this.btnIncrease_Click);

            this.btnPlace.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlace.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.Location  = new System.Drawing.Point(239, 404);
            this.btnPlace.Size      = new System.Drawing.Size(129, 38);
            this.btnPlace.Text      = "Place Order ▶";
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPlace.Click    += new System.EventHandler(this.btnPlace_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location  = new System.Drawing.Point(5, 450);
            this.btnClear.Size      = new System.Drawing.Size(363, 32);
            this.btnClear.Text      = "Clear Cart";
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);


            // ════════════════════════════════════════════════
            //  PANEL 3 — CONFIRMATION / RECEIPT SCREEN
            // ════════════════════════════════════════════════
            this.pnlConfirmation.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmation.Name      = "pnlConfirmation";
            this.pnlConfirmation.BackColor = System.Drawing.Color.FromArgb(245, 255, 245);
            this.pnlConfirmation.Visible   = false;
            this.pnlConfirmation.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblConfirmTitle, this.lblConfirmSub,
                this.lblBigOrderNum,  this.lblConfirmTotal,
                this.lblConfirmItems, this.lstConfirmItems,
                this.lblConfirmHint,  this.btnPrintReceipt,
                this.btnNewOrder,     this.lblCountdown
            });

            // Big green checkmark title
            this.lblConfirmTitle.AutoSize  = false;
            this.lblConfirmTitle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblConfirmTitle.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblConfirmTitle.ForeColor = System.Drawing.Color.White;
            this.lblConfirmTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmTitle.Height    = 64;
            this.lblConfirmTitle.Text      = "✔  Order Placed Successfully!";
            this.lblConfirmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Sub title
            this.lblConfirmSub.AutoSize  = false;
            this.lblConfirmSub.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmSub.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirmSub.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblConfirmSub.Location  = new System.Drawing.Point(0, 74);
            this.lblConfirmSub.Size      = new System.Drawing.Size(1000, 30);
            this.lblConfirmSub.Text      = "Please give your order number to the cashier";
            this.lblConfirmSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // HUGE order number
            this.lblBigOrderNum.AutoSize  = false;
            this.lblBigOrderNum.BackColor = System.Drawing.Color.Transparent;
            this.lblBigOrderNum.Font      = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.lblBigOrderNum.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblBigOrderNum.Location  = new System.Drawing.Point(0, 108);
            this.lblBigOrderNum.Size      = new System.Drawing.Size(1000, 120);
            this.lblBigOrderNum.Text      = "#00";
            this.lblBigOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Total amount
            this.lblConfirmTotal.AutoSize  = false;
            this.lblConfirmTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmTotal.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblConfirmTotal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblConfirmTotal.Location  = new System.Drawing.Point(0, 230);
            this.lblConfirmTotal.Size      = new System.Drawing.Size(1000, 36);
            this.lblConfirmTotal.Text      = "Total: ₱0.00";
            this.lblConfirmTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Items header
            this.lblConfirmItems.AutoSize  = false;
            this.lblConfirmItems.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmItems.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmItems.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblConfirmItems.Location  = new System.Drawing.Point(300, 272);
            this.lblConfirmItems.Size      = new System.Drawing.Size(400, 22);
            this.lblConfirmItems.Text      = "YOUR ORDER SUMMARY";
            this.lblConfirmItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Order items list
            this.lstConfirmItems.BackColor   = System.Drawing.Color.White;
            this.lstConfirmItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstConfirmItems.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.lstConfirmItems.Location    = new System.Drawing.Point(300, 296);
            this.lstConfirmItems.Size        = new System.Drawing.Size(400, 200);

            // Hint to go to cashier
            this.lblConfirmHint.AutoSize  = false;
            this.lblConfirmHint.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.lblConfirmHint.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmHint.ForeColor = System.Drawing.Color.FromArgb(230, 100, 0);
            this.lblConfirmHint.Location  = new System.Drawing.Point(250, 508);
            this.lblConfirmHint.Size      = new System.Drawing.Size(500, 36);
            this.lblConfirmHint.Text      = "💳  Proceed to cashier to pay";
            this.lblConfirmHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Print receipt button
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location  = new System.Drawing.Point(350, 558);
            this.btnPrintReceipt.Size      = new System.Drawing.Size(300, 50);
            this.btnPrintReceipt.Text      = "🖨  Print Receipt";
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.Click    += new System.EventHandler(this.btnPrintReceipt_Click);

            // New Order (skip print) button
            this.btnNewOrder.BackColor = System.Drawing.Color.White;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnNewOrder.Location  = new System.Drawing.Point(350, 616);
            this.btnNewOrder.Size      = new System.Drawing.Size(300, 36);
            this.btnNewOrder.Text      = "▶  New Order (Skip Print)";
            this.btnNewOrder.FlatAppearance.BorderSize  = 2;
            this.btnNewOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnNewOrder.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Click    += new System.EventHandler(this.btnNewOrder_Click);

            // Countdown label
            this.lblCountdown.AutoSize  = false;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountdown.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCountdown.Location  = new System.Drawing.Point(0, 658);
            this.lblCountdown.Size      = new System.Drawing.Size(1000, 22);
            this.lblCountdown.Text      = "Screen resets in 15 seconds...";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // ════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════
            this.ClientSize      = new System.Drawing.Size(1000, 680);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name            = "CustomerForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.Manual;
            this.Text            = "Customer — Kiosk";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlIdle, this.pnlOrdering, this.pnlConfirmation
            });

            this.pnlIdle.ResumeLayout(false);
            this.pnlOrdering.ResumeLayout(false);
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel    pnlIdle;
        private System.Windows.Forms.Label    lblIdleTitle;
        private System.Windows.Forms.Label    lblIdleTouch;
        private System.Windows.Forms.Label    lblIdleSub;
        private System.Windows.Forms.Label    lblIdleLogo;
        private System.Windows.Forms.Panel    pnlOrdering;
        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblHeaderTitle;
        private System.Windows.Forms.Label    lblLive;
        private System.Windows.Forms.Panel    pnlCategory;
        private System.Windows.Forms.Label    lblCategories;
        private System.Windows.Forms.Button   btnAll;
        private System.Windows.Forms.Button   btnBurgers;
        private System.Windows.Forms.Button   btnChicken;
        private System.Windows.Forms.Button   btnSides;
        private System.Windows.Forms.Button   btnDrinks;
        private System.Windows.Forms.Button   btnDesserts;
        private System.Windows.Forms.Label    lblMenuTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel    pnlCart;
        private System.Windows.Forms.Label    lblCartTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label    lblTotal;
        private System.Windows.Forms.Button   btnRemove;
        private System.Windows.Forms.Button   btnIncrease;
        private System.Windows.Forms.Button   btnPlace;
        private System.Windows.Forms.Button   btnClear;
        private System.Windows.Forms.Panel    pnlConfirmation;
        private System.Windows.Forms.Label    lblConfirmTitle;
        private System.Windows.Forms.Label    lblConfirmSub;
        private System.Windows.Forms.Label    lblBigOrderNum;
        private System.Windows.Forms.Label    lblConfirmTotal;
        private System.Windows.Forms.Label    lblConfirmItems;
        private System.Windows.Forms.ListBox  lstConfirmItems;
        private System.Windows.Forms.Label    lblConfirmHint;
        private System.Windows.Forms.Button   btnPrintReceipt;
        private System.Windows.Forms.Button   btnNewOrder;
        private System.Windows.Forms.Label    lblCountdown;
    }
}
