namespace OOP_FINAL_PROJECT
{
    partial class OwnerForm
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
            this.pnlHeader   = new System.Windows.Forms.Panel();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnAnalytics= new System.Windows.Forms.Button();
            this.btnLogout   = new System.Windows.Forms.Button();
            this.tabControl  = new System.Windows.Forms.TabControl();

            // Tab Menu
            this.tabMenu         = new System.Windows.Forms.TabPage();
            this.pnlMenuLeft     = new System.Windows.Forms.Panel();
            this.lblMenuListTitle= new System.Windows.Forms.Label();
            this.dgvMenu         = new System.Windows.Forms.DataGridView();
            this.btnRefreshMenu  = new System.Windows.Forms.Button();
            this.pnlMenuRight    = new System.Windows.Forms.Panel();
            this.lblMenuFormTitle= new System.Windows.Forms.Label();
            this.pnlMenuFormCard = new System.Windows.Forms.Panel();
            this.lblName         = new System.Windows.Forms.Label();
            this.txtName         = new System.Windows.Forms.TextBox();
            this.lblPrice        = new System.Windows.Forms.Label();
            this.txtPrice        = new System.Windows.Forms.TextBox();
            this.lblCategory     = new System.Windows.Forms.Label();
            this.cboCategory     = new System.Windows.Forms.ComboBox();
            this.pnlMenuButtons  = new System.Windows.Forms.Panel();
            this.btnAddItem      = new System.Windows.Forms.Button();
            this.btnUpdateItem   = new System.Windows.Forms.Button();
            this.btnDeleteItem   = new System.Windows.Forms.Button();

            // Tab Reports
            this.tabReports    = new System.Windows.Forms.TabPage();
            this.pnlReportsTop = new System.Windows.Forms.Panel();
            this.lblReportsTitle= new System.Windows.Forms.Label();
            this.btnShowOrders = new System.Windows.Forms.Button();
            this.btnEditOrder  = new System.Windows.Forms.Button();
            this.dgvReports    = new System.Windows.Forms.DataGridView();

            // Tab Users
            this.tabUsers        = new System.Windows.Forms.TabPage();
            this.pnlUsersTop     = new System.Windows.Forms.Panel();
            this.lblUsersTitle   = new System.Windows.Forms.Label();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnAddUser      = new System.Windows.Forms.Button();
            this.btnEditUser     = new System.Windows.Forms.Button();
            this.btnDeleteUser   = new System.Windows.Forms.Button();
            this.dgvUsers        = new System.Windows.Forms.DataGridView();

            // Tab Settings
            this.tabSettings       = new System.Windows.Forms.TabPage();
            this.pnlSettingsCard   = new System.Windows.Forms.Panel();
            this.lblPINTitle       = new System.Windows.Forms.Label();
            this.lblPINHint        = new System.Windows.Forms.Label();
            this.pnlPINDivider1    = new System.Windows.Forms.Panel();
            this.lblCurrentPINLabel= new System.Windows.Forms.Label();
            this.txtCurrentPIN     = new System.Windows.Forms.TextBox();
            this.btnShowPIN        = new System.Windows.Forms.Button();
            this.pnlPINDivider     = new System.Windows.Forms.Panel();
            this.lblNewPINLabel    = new System.Windows.Forms.Label();
            this.txtNewPIN         = new System.Windows.Forms.TextBox();
            this.lblConfirmPINLabel= new System.Windows.Forms.Label();
            this.txtConfirmPIN     = new System.Windows.Forms.TextBox();
            this.btnSavePIN        = new System.Windows.Forms.Button();

            // Tab Owner Controls
            this.tabOwner           = new System.Windows.Forms.TabPage();
            this.pnlOwnerBanner     = new System.Windows.Forms.Panel();
            this.lblOwnerBannerTitle= new System.Windows.Forms.Label();
            this.lblOwnerBannerSub  = new System.Windows.Forms.Label();
            this.btnOwnerAnalytics  = new System.Windows.Forms.Button();
            this.btnOwnerRefresh    = new System.Windows.Forms.Button();
            // stat cards
            this.pnlStatSales    = new System.Windows.Forms.Panel();
            this.lblStatSalesLbl = new System.Windows.Forms.Label();
            this.lblStatTotalSales= new System.Windows.Forms.Label();
            this.pnlStatOrders   = new System.Windows.Forms.Panel();
            this.lblStatOrdersLbl= new System.Windows.Forms.Label();
            this.lblStatTotalOrders= new System.Windows.Forms.Label();
            this.pnlStatAvg      = new System.Windows.Forms.Panel();
            this.lblStatAvgLbl   = new System.Windows.Forms.Label();
            this.lblStatAvgOrder = new System.Windows.Forms.Label();
            this.pnlStatCust     = new System.Windows.Forms.Panel();
            this.lblStatCustLbl  = new System.Windows.Forms.Label();
            this.lblStatCustomers= new System.Windows.Forms.Label();
            // owner grids
            this.lblOwnerTopTitle   = new System.Windows.Forms.Label();
            this.dgvOwnerTopItems   = new System.Windows.Forms.DataGridView();
            this.lblAllOrdersTitle  = new System.Windows.Forms.Label();
            this.btnOwnerEditOrder  = new System.Windows.Forms.Button();
            this.dgvAllOrders       = new System.Windows.Forms.DataGridView();


            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabOwner.SuspendLayout();
            this.pnlMenuLeft.SuspendLayout();
            this.pnlMenuRight.SuspendLayout();
            this.pnlMenuFormCard.SuspendLayout();
            this.pnlMenuButtons.SuspendLayout();
            this.pnlReportsTop.SuspendLayout();
            this.pnlUsersTop.SuspendLayout();
            this.pnlSettingsCard.SuspendLayout();
            this.pnlOwnerBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerTopItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════
            //  HEADER — gold theme distinguishes Owner
            // ════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle, this.btnAnalytics, this.btnLogout
            });
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;

            this.lblTitle.AutoSize  = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitle.Location  = new System.Drawing.Point(16, 8);
            this.lblTitle.Text      = "👑  OWNER DASHBOARD";

            this.lblSubtitle.AutoSize  = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 170, 100);
            this.lblSubtitle.Location  = new System.Drawing.Point(18, 34);
            this.lblSubtitle.Text      = "Full system access  •  All privileges enabled";

            this.btnAnalytics.BackColor           = System.Drawing.Color.FromArgb(255, 150, 0);
            this.btnAnalytics.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor           = System.Drawing.Color.White;
            this.btnAnalytics.Location            = new System.Drawing.Point(710, 15);
            this.btnAnalytics.Size                = new System.Drawing.Size(130, 30);
            this.btnAnalytics.Text                = "📊 Analytics";
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.Cursor              = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.Click              += new System.EventHandler(this.btnAnalytics_Click);

            this.btnLogout.BackColor              = System.Drawing.Color.FromArgb(60, 40, 10);
            this.btnLogout.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor              = System.Drawing.Color.FromArgb(255, 200, 80);
            this.btnLogout.Location               = new System.Drawing.Point(850, 15);
            this.btnLogout.Size                   = new System.Drawing.Size(80, 30);
            this.btnLogout.Text                   = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click                 += new System.EventHandler(this.btnLogout_Click);


            // ════════════════════════════════════════
            //  TAB CONTROL
            // ════════════════════════════════════════
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabMenu, this.tabReports, this.tabUsers, this.tabSettings, this.tabOwner
            });
            this.tabControl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Size     = new System.Drawing.Size(960, 640);

            // ════════════════════════════════════════
            //  TAB 1 — MENU  (identical to ManagerForm)
            // ════════════════════════════════════════
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabMenu.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlMenuLeft, this.pnlMenuRight });
            this.tabMenu.Text = "  🍔  Menu  ";

            this.pnlMenuLeft.BackColor   = System.Drawing.Color.White;
            this.pnlMenuLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMenuListTitle, this.dgvMenu, this.btnRefreshMenu });
            this.pnlMenuLeft.Location = new System.Drawing.Point(10, 10);
            this.pnlMenuLeft.Size     = new System.Drawing.Size(570, 590);

            this.lblMenuListTitle.BackColor  = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblMenuListTitle.Font       = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuListTitle.ForeColor  = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblMenuListTitle.Dock       = System.Windows.Forms.DockStyle.Top;
            this.lblMenuListTitle.Height     = 36;
            this.lblMenuListTitle.Text       = "   Menu Items";
            this.lblMenuListTitle.TextAlign  = System.Drawing.ContentAlignment.MiddleLeft;

            this.dgvMenu.AllowUserToAddRows    = false;
            this.dgvMenu.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor       = System.Drawing.Color.White;
            this.dgvMenu.Location              = new System.Drawing.Point(0, 36);
            this.dgvMenu.ReadOnly              = true;
            this.dgvMenu.RowHeadersVisible     = false;
            this.dgvMenu.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size                  = new System.Drawing.Size(568, 510);
            this.dgvMenu.SelectionChanged     += new System.EventHandler(this.dgvMenu_SelectionChanged);
            StyleGrid(this.dgvMenu);

            this.btnRefreshMenu.BackColor      = System.Drawing.Color.White;
            this.btnRefreshMenu.Dock           = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefreshMenu.FlatStyle      = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshMenu.Font           = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshMenu.ForeColor      = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshMenu.Height         = 36;
            this.btnRefreshMenu.Text           = "↺  Refresh Menu";
            this.btnRefreshMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(224,224,224);
            this.btnRefreshMenu.Click         += new System.EventHandler(this.btnRefreshMenu_Click);

            this.pnlMenuRight.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMenuFormTitle, this.pnlMenuFormCard, this.pnlMenuButtons });
            this.pnlMenuRight.Location = new System.Drawing.Point(592, 10);
            this.pnlMenuRight.Size     = new System.Drawing.Size(350, 590);

            this.lblMenuFormTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblMenuFormTitle.Location  = new System.Drawing.Point(0, 8);
            this.lblMenuFormTitle.Size      = new System.Drawing.Size(350, 24);
            this.lblMenuFormTitle.Text      = "Add / Edit Item";

            this.pnlMenuFormCard.BackColor   = System.Drawing.Color.White;
            this.pnlMenuFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuFormCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblName, this.txtName, this.lblPrice, this.txtPrice,
                this.lblCategory, this.cboCategory });
            this.pnlMenuFormCard.Location = new System.Drawing.Point(0, 38);
            this.pnlMenuFormCard.Size     = new System.Drawing.Size(350, 200);

            MakeFormRow(this.lblName,  this.txtName,  "Item Name:", 15, 20);
            MakeFormRow(this.lblPrice, this.txtPrice, "Price (₱):", 15, 75);
            this.txtName.MaxLength   = 100;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtPrice.MaxLength   = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress    += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);

            this.lblCategory.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCategory.Location  = new System.Drawing.Point(15, 130);
            this.lblCategory.Size      = new System.Drawing.Size(90, 22);
            this.lblCategory.Text      = "Category:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.Items.AddRange(new object[] { "Burgers","Chicken","Sides","Drinks","Desserts" });
            this.cboCategory.Location      = new System.Drawing.Point(115, 128);
            this.cboCategory.Size          = new System.Drawing.Size(218, 26);
            this.cboCategory.SelectedIndex = 0;

            this.pnlMenuButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnAddItem, this.btnUpdateItem, this.btnDeleteItem });
            this.pnlMenuButtons.Location = new System.Drawing.Point(0, 248);
            this.pnlMenuButtons.Size     = new System.Drawing.Size(350, 160);

            MakeActionBtn(this.btnAddItem,    "+ Add New Item",        System.Drawing.Color.FromArgb(255,111,0),   0, 0);
            MakeActionBtn(this.btnUpdateItem, "✎  Update Selected",   System.Drawing.Color.FromArgb(33,150,243), 0, 52);
            MakeActionBtn(this.btnDeleteItem, "🗑  Delete Selected",   System.Drawing.Color.FromArgb(229,57,53),  0, 104);
            this.btnAddItem.Click    += new System.EventHandler(this.btnAddItem_Click);
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);


            // ════════════════════════════════════════
            //  TAB 2 — REPORTS (no PIN banner)
            // ════════════════════════════════════════
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabReports.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlReportsTop, this.dgvReports });
            this.tabReports.Text = "  📋  Reports  ";

            this.pnlReportsTop.BackColor   = System.Drawing.Color.White;
            this.pnlReportsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportsTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblReportsTitle, this.btnShowOrders, this.btnEditOrder });
            this.pnlReportsTop.Location = new System.Drawing.Point(10, 10);
            this.pnlReportsTop.Size     = new System.Drawing.Size(930, 60);

            this.lblReportsTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblReportsTitle.Location  = new System.Drawing.Point(12, 18);
            this.lblReportsTitle.AutoSize  = true;
            this.lblReportsTitle.Text      = "Order Reports  —  No PIN required for Owner";

            this.btnShowOrders.BackColor           = System.Drawing.Color.FromArgb(33,150,243);
            this.btnShowOrders.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrders.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowOrders.ForeColor           = System.Drawing.Color.White;
            this.btnShowOrders.Location            = new System.Drawing.Point(650, 13);
            this.btnShowOrders.Size                = new System.Drawing.Size(130, 32);
            this.btnShowOrders.Text                = "↺  All Orders";
            this.btnShowOrders.FlatAppearance.BorderSize = 0;
            this.btnShowOrders.Click              += new System.EventHandler(this.btnShowOrders_Click);

            this.btnEditOrder.BackColor            = System.Drawing.Color.FromArgb(255,111,0);
            this.btnEditOrder.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font                 = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.ForeColor            = System.Drawing.Color.White;
            this.btnEditOrder.Location             = new System.Drawing.Point(790, 13);
            this.btnEditOrder.Size                 = new System.Drawing.Size(130, 32);
            this.btnEditOrder.Text                 = "✎  Edit Order";
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.Click               += new System.EventHandler(this.btnEditOrder_Click);

            this.dgvReports.AllowUserToAddRows  = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor     = System.Drawing.Color.White;
            this.dgvReports.Location            = new System.Drawing.Point(10, 78);
            this.dgvReports.ReadOnly            = true;
            this.dgvReports.RowHeadersVisible   = false;
            this.dgvReports.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size                = new System.Drawing.Size(930, 530);
            StyleGrid(this.dgvReports);

            // ════════════════════════════════════════
            //  TAB 3 — USERS  (Owner sees all roles)
            // ════════════════════════════════════════
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabUsers.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlUsersTop, this.dgvUsers });
            this.tabUsers.Text = "  👥  Users  ";

            this.pnlUsersTop.BackColor   = System.Drawing.Color.White;
            this.pnlUsersTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsersTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsersTitle, this.btnRefreshUsers, this.btnAddUser, this.btnEditUser, this.btnDeleteUser });
            this.pnlUsersTop.Location = new System.Drawing.Point(10, 10);
            this.pnlUsersTop.Size     = new System.Drawing.Size(930, 60);

            this.lblUsersTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblUsersTitle.Location  = new System.Drawing.Point(12, 18);
            this.lblUsersTitle.AutoSize  = true;
            this.lblUsersTitle.Text      = "All System Users  —  Owner can manage all roles";

            this.btnRefreshUsers.BackColor           = System.Drawing.Color.White;
            this.btnRefreshUsers.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshUsers.ForeColor           = System.Drawing.Color.FromArgb(33,150,243);
            this.btnRefreshUsers.Location            = new System.Drawing.Point(460, 13);
            this.btnRefreshUsers.Size                = new System.Drawing.Size(110, 32);
            this.btnRefreshUsers.Text                = "↺  Refresh";
            this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33,150,243);
            this.btnRefreshUsers.Click              += new System.EventHandler(this.btnRefreshUsers_Click);

            this.btnAddUser.BackColor            = System.Drawing.Color.FromArgb(255,111,0);
            this.btnAddUser.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font                 = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor            = System.Drawing.Color.White;
            this.btnAddUser.Location             = new System.Drawing.Point(580, 13);
            this.btnAddUser.Size                 = new System.Drawing.Size(110, 32);
            this.btnAddUser.Text                 = "+  Add User";
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.Click               += new System.EventHandler(this.btnAddUser_Click);

            this.btnEditUser.BackColor           = System.Drawing.Color.FromArgb(33,150,243);
            this.btnEditUser.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.ForeColor           = System.Drawing.Color.White;
            this.btnEditUser.Location            = new System.Drawing.Point(700, 13);
            this.btnEditUser.Size                = new System.Drawing.Size(100, 32);
            this.btnEditUser.Text                = "✎  Edit";
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.Click              += new System.EventHandler(this.btnEditUser_Click);

            this.btnDeleteUser.BackColor         = System.Drawing.Color.FromArgb(229,57,53);
            this.btnDeleteUser.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font              = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor         = System.Drawing.Color.White;
            this.btnDeleteUser.Location          = new System.Drawing.Point(810, 13);
            this.btnDeleteUser.Size              = new System.Drawing.Size(110, 32);
            this.btnDeleteUser.Text              = "🗑  Delete";
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.Click            += new System.EventHandler(this.btnDeleteUser_Click);

            this.dgvUsers.AllowUserToAddRows  = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor     = System.Drawing.Color.White;
            this.dgvUsers.Location            = new System.Drawing.Point(10, 78);
            this.dgvUsers.ReadOnly            = true;
            this.dgvUsers.RowHeadersVisible   = false;
            this.dgvUsers.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size                = new System.Drawing.Size(930, 530);
            StyleGrid(this.dgvUsers);


            // ════════════════════════════════════════
            //  TAB 4 — SETTINGS
            // ════════════════════════════════════════
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabSettings.Controls.Add(this.pnlSettingsCard);
            this.tabSettings.Text = "  ⚙  Settings  ";

            this.pnlSettingsCard.BackColor   = System.Drawing.Color.White;
            this.pnlSettingsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettingsCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPINTitle, this.lblPINHint, this.pnlPINDivider1,
                this.lblCurrentPINLabel, this.txtCurrentPIN, this.btnShowPIN,
                this.pnlPINDivider,
                this.lblNewPINLabel, this.txtNewPIN,
                this.lblConfirmPINLabel, this.txtConfirmPIN, this.btnSavePIN });
            this.pnlSettingsCard.Location = new System.Drawing.Point(10, 10);
            this.pnlSettingsCard.Size     = new System.Drawing.Size(500, 400);

            this.lblPINTitle.BackColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblPINTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPINTitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblPINTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblPINTitle.Height    = 44;
            this.lblPINTitle.Padding   = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblPINTitle.Text      = "🔑  Manager Override PIN";
            this.lblPINTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblPINHint.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPINHint.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblPINHint.Location  = new System.Drawing.Point(16, 56);
            this.lblPINHint.Size      = new System.Drawing.Size(465, 18);
            this.lblPINHint.Text      = "Owner can reset this PIN at any time without needing the old PIN.";

            this.pnlPINDivider1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlPINDivider1.Location  = new System.Drawing.Point(16, 82);
            this.pnlPINDivider1.Size      = new System.Drawing.Size(465, 1);

            this.lblCurrentPINLabel.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCurrentPINLabel.Location  = new System.Drawing.Point(16, 96);
            this.lblCurrentPINLabel.Size      = new System.Drawing.Size(120, 22);
            this.lblCurrentPINLabel.Text      = "Current PIN:";

            this.txtCurrentPIN.Font     = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPIN.Location = new System.Drawing.Point(16, 120);
            this.txtCurrentPIN.ReadOnly = true;
            this.txtCurrentPIN.Size     = new System.Drawing.Size(120, 28);
            this.txtCurrentPIN.UseSystemPasswordChar = true;
            this.txtCurrentPIN.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.btnShowPIN.BackColor           = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnShowPIN.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPIN.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPIN.ForeColor           = System.Drawing.Color.White;
            this.btnShowPIN.Location            = new System.Drawing.Point(146, 120);
            this.btnShowPIN.Size                = new System.Drawing.Size(100, 28);
            this.btnShowPIN.Text                = "Show PIN";
            this.btnShowPIN.FlatAppearance.BorderSize = 0;
            this.btnShowPIN.Click              += new System.EventHandler(this.btnShowPIN_Click);

            this.pnlPINDivider.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlPINDivider.Location  = new System.Drawing.Point(16, 162);
            this.pnlPINDivider.Size      = new System.Drawing.Size(465, 1);

            this.lblNewPINLabel.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblNewPINLabel.Location  = new System.Drawing.Point(16, 176);
            this.lblNewPINLabel.Size      = new System.Drawing.Size(100, 22);
            this.lblNewPINLabel.Text      = "New PIN:";

            this.txtNewPIN.Font     = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPIN.Location = new System.Drawing.Point(16, 200);
            this.txtNewPIN.MaxLength = 4;
            this.txtNewPIN.Size     = new System.Drawing.Size(120, 28);
            this.txtNewPIN.UseSystemPasswordChar = true;
            this.txtNewPIN.TextChanged += new System.EventHandler(this.txtNewPIN_TextChanged);
            this.txtNewPIN.KeyPress    += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPIN_KeyPress);

            this.lblConfirmPINLabel.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblConfirmPINLabel.Location  = new System.Drawing.Point(16, 242);
            this.lblConfirmPINLabel.Size      = new System.Drawing.Size(140, 22);
            this.lblConfirmPINLabel.Text      = "Confirm New PIN:";

            this.txtConfirmPIN.Font     = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPIN.Location = new System.Drawing.Point(16, 266);
            this.txtConfirmPIN.MaxLength = 4;
            this.txtConfirmPIN.Size     = new System.Drawing.Size(120, 28);
            this.txtConfirmPIN.UseSystemPasswordChar = true;
            this.txtConfirmPIN.TextChanged += new System.EventHandler(this.txtConfirmPIN_TextChanged);
            this.txtConfirmPIN.KeyPress    += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPIN_KeyPress);

            this.btnSavePIN.BackColor           = System.Drawing.Color.FromArgb(255, 150, 0);
            this.btnSavePIN.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePIN.Font                = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePIN.ForeColor           = System.Drawing.Color.White;
            this.btnSavePIN.Location            = new System.Drawing.Point(16, 316);
            this.btnSavePIN.Size                = new System.Drawing.Size(220, 44);
            this.btnSavePIN.Text                = "💾  Save New PIN";
            this.btnSavePIN.FlatAppearance.BorderSize = 0;
            this.btnSavePIN.Click              += new System.EventHandler(this.btnSavePIN_Click);


            // ════════════════════════════════════════
            //  TAB 5 — OWNER CONTROLS (exclusive)
            // ════════════════════════════════════════
            this.tabOwner.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabOwner.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlOwnerBanner,
                this.pnlStatSales, this.pnlStatOrders, this.pnlStatAvg, this.pnlStatCust,
                this.lblOwnerTopTitle, this.dgvOwnerTopItems,
                this.lblAllOrdersTitle, this.btnOwnerEditOrder, this.dgvAllOrders
            });
            this.tabOwner.Text = "  👑  Owner Controls  ";

            // Gold banner
            this.pnlOwnerBanner.BackColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.pnlOwnerBanner.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOwnerBannerTitle, this.lblOwnerBannerSub,
                this.btnOwnerAnalytics, this.btnOwnerRefresh });
            this.pnlOwnerBanner.Location = new System.Drawing.Point(10, 10);
            this.pnlOwnerBanner.Size     = new System.Drawing.Size(930, 60);

            this.lblOwnerBannerTitle.AutoSize  = true;
            this.lblOwnerBannerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerBannerTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblOwnerBannerTitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblOwnerBannerTitle.Location  = new System.Drawing.Point(14, 8);
            this.lblOwnerBannerTitle.Text      = "👑  Owner Controls";

            this.lblOwnerBannerSub.AutoSize  = true;
            this.lblOwnerBannerSub.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerBannerSub.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOwnerBannerSub.ForeColor = System.Drawing.Color.FromArgb(200, 170, 100);
            this.lblOwnerBannerSub.Location  = new System.Drawing.Point(16, 34);
            this.lblOwnerBannerSub.Text      = "All-time stats  •  Edit any order  •  No PIN required";

            this.btnOwnerAnalytics.BackColor           = System.Drawing.Color.FromArgb(255, 150, 0);
            this.btnOwnerAnalytics.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerAnalytics.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOwnerAnalytics.ForeColor           = System.Drawing.Color.White;
            this.btnOwnerAnalytics.Location            = new System.Drawing.Point(680, 15);
            this.btnOwnerAnalytics.Size                = new System.Drawing.Size(130, 30);
            this.btnOwnerAnalytics.Text                = "📊 Analytics";
            this.btnOwnerAnalytics.FlatAppearance.BorderSize = 0;
            this.btnOwnerAnalytics.Click              += new System.EventHandler(this.btnOwnerAnalytics_Click);

            this.btnOwnerRefresh.BackColor           = System.Drawing.Color.FromArgb(60, 40, 10);
            this.btnOwnerRefresh.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerRefresh.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOwnerRefresh.ForeColor           = System.Drawing.Color.FromArgb(255, 200, 80);
            this.btnOwnerRefresh.Location            = new System.Drawing.Point(820, 15);
            this.btnOwnerRefresh.Size                = new System.Drawing.Size(100, 30);
            this.btnOwnerRefresh.Text                = "↺  Refresh";
            this.btnOwnerRefresh.FlatAppearance.BorderSize = 0;
            this.btnOwnerRefresh.Click              += new System.EventHandler(this.btnOwnerRefresh_Click);

            // Stat cards row  Y=82  H=80  4 cards across 930px
            int sy = 82, sh = 80, sw = 218, sg = 10, sx = 10;
            MakeStatCard(this.pnlStatSales,  this.lblStatSalesLbl,  this.lblStatTotalSales,
                "This Month's Sales", "₱0.00", sx, sy, sw, sh, System.Drawing.Color.FromArgb(30,20,5));
            sx += sw + sg;
            MakeStatCard(this.pnlStatOrders, this.lblStatOrdersLbl, this.lblStatTotalOrders,
                "Orders Today", "0", sx, sy, sw, sh, System.Drawing.Color.FromArgb(255,111,0));
            sx += sw + sg;
            MakeStatCard(this.pnlStatAvg,    this.lblStatAvgLbl,    this.lblStatAvgOrder,
                "All-time Avg Order", "₱0.00", sx, sy, sw, sh, System.Drawing.Color.FromArgb(30,20,5));
            sx += sw + sg;
            MakeStatCard(this.pnlStatCust,   this.lblStatCustLbl,   this.lblStatCustomers,
                "Total Customers", "0", sx, sy, sw, sh, System.Drawing.Color.FromArgb(255,150,0));

            // All-time top items grid
            this.lblOwnerTopTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOwnerTopTitle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblOwnerTopTitle.Location  = new System.Drawing.Point(10, 174);
            this.lblOwnerTopTitle.Size      = new System.Drawing.Size(280, 22);
            this.lblOwnerTopTitle.Text      = "All-Time Top 10 Items";

            this.dgvOwnerTopItems.AllowUserToAddRows  = false;
            this.dgvOwnerTopItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOwnerTopItems.BackgroundColor     = System.Drawing.Color.White;
            this.dgvOwnerTopItems.Location            = new System.Drawing.Point(10, 198);
            this.dgvOwnerTopItems.ReadOnly            = true;
            this.dgvOwnerTopItems.RowHeadersVisible   = false;
            this.dgvOwnerTopItems.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnerTopItems.Size                = new System.Drawing.Size(450, 385);
            StyleGrid(this.dgvOwnerTopItems);

            // All orders + edit button
            this.lblAllOrdersTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAllOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 5);
            this.lblAllOrdersTitle.Location  = new System.Drawing.Point(472, 174);
            this.lblAllOrdersTitle.Size      = new System.Drawing.Size(280, 22);
            this.lblAllOrdersTitle.Text      = "All Orders  (Owner edit — no PIN)";

            this.btnOwnerEditOrder.BackColor           = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnOwnerEditOrder.FlatStyle           = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerEditOrder.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOwnerEditOrder.ForeColor           = System.Drawing.Color.White;
            this.btnOwnerEditOrder.Location            = new System.Drawing.Point(790, 170);
            this.btnOwnerEditOrder.Size                = new System.Drawing.Size(148, 26);
            this.btnOwnerEditOrder.Text                = "✎  Edit Selected Order";
            this.btnOwnerEditOrder.FlatAppearance.BorderSize = 0;
            this.btnOwnerEditOrder.Click              += new System.EventHandler(this.btnOwnerEditOrder_Click);

            this.dgvAllOrders.AllowUserToAddRows  = false;
            this.dgvAllOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllOrders.BackgroundColor     = System.Drawing.Color.White;
            this.dgvAllOrders.Location            = new System.Drawing.Point(472, 198);
            this.dgvAllOrders.ReadOnly            = true;
            this.dgvAllOrders.RowHeadersVisible   = false;
            this.dgvAllOrders.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllOrders.Size                = new System.Drawing.Size(466, 385);
            StyleGrid(this.dgvAllOrders);


            // ════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════
            this.BackColor     = System.Drawing.Color.White;
            this.ClientSize    = new System.Drawing.Size(960, 710);
            this.MinimumSize   = new System.Drawing.Size(960, 710);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name          = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text          = "Owner Dashboard";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlHeader, this.tabControl });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabOwner.ResumeLayout(false);
            this.pnlMenuLeft.ResumeLayout(false);
            this.pnlMenuRight.ResumeLayout(false);
            this.pnlMenuFormCard.ResumeLayout(false);
            this.pnlMenuFormCard.PerformLayout();
            this.pnlMenuButtons.ResumeLayout(false);
            this.pnlReportsTop.ResumeLayout(false);
            this.pnlReportsTop.PerformLayout();
            this.pnlUsersTop.ResumeLayout(false);
            this.pnlUsersTop.PerformLayout();
            this.pnlSettingsCard.ResumeLayout(false);
            this.pnlOwnerBanner.ResumeLayout(false);
            this.pnlOwnerBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerTopItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Helpers ───────────────────────────────────────────
        private void MakeFormRow(
            System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt,
            string labelText, int left, int top)
        {
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            lbl.Location  = new System.Drawing.Point(left, top);
            lbl.Size      = new System.Drawing.Size(95, 22);
            lbl.Text      = labelText;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font        = new System.Drawing.Font("Segoe UI", 10F);
            txt.Location    = new System.Drawing.Point(left + 100, top - 2);
            txt.Size        = new System.Drawing.Size(230, 26);
        }

        private void MakeActionBtn(
            System.Windows.Forms.Button btn, string text,
            System.Drawing.Color color, int x, int y)
        {
            btn.BackColor = color;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location  = new System.Drawing.Point(x, y);
            btn.Size      = new System.Drawing.Size(350, 44);
            btn.Text      = text;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
        }

        private void MakeStatCard(
            System.Windows.Forms.Panel pnl,
            System.Windows.Forms.Label lblLbl,
            System.Windows.Forms.Label lblVal,
            string labelText, string valueText,
            int x, int y, int w, int h,
            System.Drawing.Color color)
        {
            pnl.BackColor = color;
            pnl.Location  = new System.Drawing.Point(x, y);
            pnl.Size      = new System.Drawing.Size(w, h);
            pnl.Controls.AddRange(new System.Windows.Forms.Control[] { lblLbl, lblVal });
            lblLbl.AutoSize  = true;
            lblLbl.BackColor = System.Drawing.Color.Transparent;
            lblLbl.Font      = new System.Drawing.Font("Segoe UI", 8F);
            lblLbl.ForeColor = System.Drawing.Color.FromArgb(200, 170, 100);
            lblLbl.Location  = new System.Drawing.Point(10, 8);
            lblLbl.Text      = labelText;
            lblVal.AutoSize  = true;
            lblVal.BackColor = System.Drawing.Color.Transparent;
            lblVal.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblVal.ForeColor = System.Drawing.Color.White;
            lblVal.Location  = new System.Drawing.Point(10, 30);
            lblVal.Text      = valueText;
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 28, 8);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            dgv.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor  = System.Drawing.Color.FromArgb(255, 230, 150);
            dgv.DefaultCellStyle.SelectionForeColor  = System.Drawing.Color.FromArgb(30, 20, 5);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 252, 240);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor     = System.Drawing.Color.FromArgb(230, 220, 200);
        }


        // ── Field declarations ────────────────────────────────
        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Label    lblSubtitle;
        private System.Windows.Forms.Button   btnAnalytics;
        private System.Windows.Forms.Button   btnLogout;
        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Panel   pnlMenuLeft;
        private System.Windows.Forms.Label   lblMenuListTitle;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button  btnRefreshMenu;
        private System.Windows.Forms.Panel   pnlMenuRight;
        private System.Windows.Forms.Label   lblMenuFormTitle;
        private System.Windows.Forms.Panel   pnlMenuFormCard;
        private System.Windows.Forms.Label   lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label   lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label   lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel   pnlMenuButtons;
        private System.Windows.Forms.Button  btnAddItem;
        private System.Windows.Forms.Button  btnUpdateItem;
        private System.Windows.Forms.Button  btnDeleteItem;

        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Panel   pnlReportsTop;
        private System.Windows.Forms.Label   lblReportsTitle;
        private System.Windows.Forms.Button  btnShowOrders;
        private System.Windows.Forms.Button  btnEditOrder;
        private System.Windows.Forms.DataGridView dgvReports;

        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel   pnlUsersTop;
        private System.Windows.Forms.Label   lblUsersTitle;
        private System.Windows.Forms.Button  btnRefreshUsers;
        private System.Windows.Forms.Button  btnAddUser;
        private System.Windows.Forms.Button  btnEditUser;
        private System.Windows.Forms.Button  btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvUsers;

        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel   pnlSettingsCard;
        private System.Windows.Forms.Label   lblPINTitle;
        private System.Windows.Forms.Label   lblPINHint;
        private System.Windows.Forms.Panel   pnlPINDivider1;
        private System.Windows.Forms.Label   lblCurrentPINLabel;
        private System.Windows.Forms.TextBox txtCurrentPIN;
        private System.Windows.Forms.Button  btnShowPIN;
        private System.Windows.Forms.Panel   pnlPINDivider;
        private System.Windows.Forms.Label   lblNewPINLabel;
        private System.Windows.Forms.TextBox txtNewPIN;
        private System.Windows.Forms.Label   lblConfirmPINLabel;
        private System.Windows.Forms.TextBox txtConfirmPIN;
        private System.Windows.Forms.Button  btnSavePIN;

        private System.Windows.Forms.TabPage tabOwner;
        private System.Windows.Forms.Panel   pnlOwnerBanner;
        private System.Windows.Forms.Label   lblOwnerBannerTitle;
        private System.Windows.Forms.Label   lblOwnerBannerSub;
        private System.Windows.Forms.Button  btnOwnerAnalytics;
        private System.Windows.Forms.Button  btnOwnerRefresh;
        private System.Windows.Forms.Panel   pnlStatSales;
        private System.Windows.Forms.Label   lblStatSalesLbl;
        private System.Windows.Forms.Label   lblStatTotalSales;
        private System.Windows.Forms.Panel   pnlStatOrders;
        private System.Windows.Forms.Label   lblStatOrdersLbl;
        private System.Windows.Forms.Label   lblStatTotalOrders;
        private System.Windows.Forms.Panel   pnlStatAvg;
        private System.Windows.Forms.Label   lblStatAvgLbl;
        private System.Windows.Forms.Label   lblStatAvgOrder;
        private System.Windows.Forms.Panel   pnlStatCust;
        private System.Windows.Forms.Label   lblStatCustLbl;
        private System.Windows.Forms.Label   lblStatCustomers;
        private System.Windows.Forms.Label   lblOwnerTopTitle;
        private System.Windows.Forms.DataGridView dgvOwnerTopItems;
        private System.Windows.Forms.Label   lblAllOrdersTitle;
        private System.Windows.Forms.Button  btnOwnerEditOrder;
        private System.Windows.Forms.DataGridView dgvAllOrders;
    }
}
