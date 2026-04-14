namespace OOP_FINAL_PROJECT
{
    partial class ManagerForm
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
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();

            // Tab: Menu Management
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.pnlMenuLeft = new System.Windows.Forms.Panel();
            this.lblMenuListTitle = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnRefreshMenu = new System.Windows.Forms.Button();
            this.pnlMenuRight = new System.Windows.Forms.Panel();
            this.lblMenuFormTitle = new System.Windows.Forms.Label();
            this.pnlMenuFormCard = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();

            // Tab: Reports
            this.tabReports = new System.Windows.Forms.TabPage();
            this.pnlReportsTop = new System.Windows.Forms.Panel();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.btnShowOrders = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();

            // Tab: Users
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.pnlUsersTop = new System.Windows.Forms.Panel();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();

            // Tab: Settings
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pnlSettingsCard = new System.Windows.Forms.Panel();
            this.lblPINTitle = new System.Windows.Forms.Label();
            this.lblPINHint = new System.Windows.Forms.Label();
            this.pnlPINDivider1 = new System.Windows.Forms.Panel();
            this.lblCurrentPINLabel = new System.Windows.Forms.Label();
            this.txtCurrentPIN = new System.Windows.Forms.TextBox();
            this.btnShowPIN = new System.Windows.Forms.Button();
            this.pnlPINDivider = new System.Windows.Forms.Panel();
            this.lblNewPINLabel = new System.Windows.Forms.Label();
            this.txtNewPIN = new System.Windows.Forms.TextBox();
            this.lblConfirmPINLabel = new System.Windows.Forms.Label();
            this.txtConfirmPIN = new System.Windows.Forms.TextBox();
            this.btnSavePIN = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlMenuLeft.SuspendLayout();
            this.pnlMenuRight.SuspendLayout();
            this.pnlMenuFormCard.SuspendLayout();
            this.pnlMenuButtons.SuspendLayout();
            this.pnlReportsTop.SuspendLayout();
            this.pnlUsersTop.SuspendLayout();
            this.pnlSettingsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // ── HEADER ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle, this.btnAnalytics, this.btnLogout
            });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "MANAGER DASHBOARD";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(144, 202, 249);
            this.lblSubtitle.Location = new System.Drawing.Point(18, 34);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Manage menu, orders, users and system settings";

            this.btnAnalytics.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.Location = new System.Drawing.Point(720, 15);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(130, 30);
            this.btnAnalytics.Text = "📊 Analytics";
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(10, 55, 130);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(860, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ── TAB CONTROL ───────────────────────────────────
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabMenu, this.tabReports, this.tabUsers, this.tabSettings
            });
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(960, 630);

            // ══════════════════════════════════════════════════
            // TAB 1 — MENU MANAGEMENT
            // ══════════════════════════════════════════════════
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabMenu.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlMenuLeft, this.pnlMenuRight
            });
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Text = "  🍔  Menu Management  ";

            // Left side — grid + refresh
            this.pnlMenuLeft.BackColor = System.Drawing.Color.White;
            this.pnlMenuLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMenuListTitle, this.dgvMenu, this.btnRefreshMenu
            });
            this.pnlMenuLeft.Location = new System.Drawing.Point(10, 10);
            this.pnlMenuLeft.Name = "pnlMenuLeft";
            this.pnlMenuLeft.Size = new System.Drawing.Size(570, 590);

            this.lblMenuListTitle.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblMenuListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuListTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuListTitle.Height = 36;
            this.lblMenuListTitle.Name = "lblMenuListTitle";
            this.lblMenuListTitle.Text = "   Menu Items";
            this.lblMenuListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.Location = new System.Drawing.Point(0, 36);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(568, 510);
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            StyleGrid(this.dgvMenu);

            this.btnRefreshMenu.BackColor = System.Drawing.Color.White;
            this.btnRefreshMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefreshMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshMenu.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshMenu.Height = 36;
            this.btnRefreshMenu.Name = "btnRefreshMenu";
            this.btnRefreshMenu.Text = "↺  Refresh Menu";
            this.btnRefreshMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnRefreshMenu.Click += new System.EventHandler(this.btnRefreshMenu_Click);

            // Right side — form card
            this.pnlMenuRight.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMenuFormTitle, this.pnlMenuFormCard, this.pnlMenuButtons
            });
            this.pnlMenuRight.Location = new System.Drawing.Point(592, 10);
            this.pnlMenuRight.Name = "pnlMenuRight";
            this.pnlMenuRight.Size = new System.Drawing.Size(350, 590);

            this.lblMenuFormTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuFormTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblMenuFormTitle.Location = new System.Drawing.Point(0, 8);
            this.lblMenuFormTitle.Name = "lblMenuFormTitle";
            this.lblMenuFormTitle.Size = new System.Drawing.Size(350, 24);
            this.lblMenuFormTitle.Text = "Add / Edit Item";

            // Card panel
            this.pnlMenuFormCard.BackColor = System.Drawing.Color.White;
            this.pnlMenuFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuFormCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblName, this.txtName,
                this.lblPrice, this.txtPrice,
                this.lblCategory, this.cboCategory
            });
            this.pnlMenuFormCard.Location = new System.Drawing.Point(0, 38);
            this.pnlMenuFormCard.Name = "pnlMenuFormCard";
            this.pnlMenuFormCard.Size = new System.Drawing.Size(350, 200);

            MakeFormRow(this.lblName, this.txtName, "Item Name:", 15, 20);
            MakeFormRow(this.lblPrice, this.txtPrice, "Price (₱):", 15, 75);
            this.txtName.MaxLength = 100;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);

            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCategory.Location = new System.Drawing.Point(15, 130);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 22);
            this.lblCategory.Text = "Category:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.Items.AddRange(new object[] { "Burgers", "Chicken", "Sides", "Drinks", "Desserts" });
            this.cboCategory.Location = new System.Drawing.Point(115, 128);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(218, 26);
            this.cboCategory.SelectedIndex = 0;

            // Action buttons panel
            this.pnlMenuButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnAddItem, this.btnUpdateItem, this.btnDeleteItem
            });
            this.pnlMenuButtons.Location = new System.Drawing.Point(0, 248);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(350, 160);

            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(0, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(350, 44);
            this.btnAddItem.Text = "+ Add New Item";
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.Location = new System.Drawing.Point(0, 52);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(350, 44);
            this.btnUpdateItem.Text = "✎  Update Selected Item";
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);

            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 104);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(350, 44);
            this.btnDeleteItem.Text = "🗑  Delete Selected Item";
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);

            // ══════════════════════════════════════════════════
            // TAB 2 — REPORTS
            // ══════════════════════════════════════════════════
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabReports.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlReportsTop, this.dgvReports
            });
            this.tabReports.Name = "tabReports";
            this.tabReports.Text = "  📋  Reports  ";

            this.pnlReportsTop.BackColor = System.Drawing.Color.White;
            this.pnlReportsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportsTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblReportsTitle, this.btnShowOrders, this.btnEditOrder
            });
            this.pnlReportsTop.Location = new System.Drawing.Point(10, 10);
            this.pnlReportsTop.Name = "pnlReportsTop";
            this.pnlReportsTop.Size = new System.Drawing.Size(930, 60);

            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblReportsTitle.Location = new System.Drawing.Point(12, 18);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Text = "Order Reports";

            this.btnShowOrders.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnShowOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowOrders.ForeColor = System.Drawing.Color.White;
            this.btnShowOrders.Location = new System.Drawing.Point(660, 13);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(120, 32);
            this.btnShowOrders.Text = "↺  All Orders";
            this.btnShowOrders.FlatAppearance.BorderSize = 0;
            this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);

            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(790, 13);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(130, 32);
            this.btnEditOrder.Text = "✎  Edit Order";
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);

            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.Location = new System.Drawing.Point(10, 78);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Size = new System.Drawing.Size(930, 530);
            StyleGrid(this.dgvReports);

            // ══════════════════════════════════════════════════
            // TAB 3 — USERS
            // ══════════════════════════════════════════════════
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabUsers.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlUsersTop, this.dgvUsers
            });
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Text = "  👥  Users  ";

            this.pnlUsersTop.BackColor = System.Drawing.Color.White;
            this.pnlUsersTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsersTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsersTitle,
                this.btnRefreshUsers, this.btnAddUser, this.btnEditUser, this.btnDeleteUser
            });
            this.pnlUsersTop.Location = new System.Drawing.Point(10, 10);
            this.pnlUsersTop.Name = "pnlUsersTop";
            this.pnlUsersTop.Size = new System.Drawing.Size(930, 60);

            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblUsersTitle.Location = new System.Drawing.Point(12, 18);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.Text = "System Users";

            this.btnRefreshUsers.BackColor = System.Drawing.Color.White;
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshUsers.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshUsers.Location = new System.Drawing.Point(470, 13);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(110, 32);
            this.btnRefreshUsers.Text = "↺  Refresh";
            this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);

            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(590, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(110, 32);
            this.btnAddUser.Text = "+  Add User";
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(710, 13);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 32);
            this.btnEditUser.Text = "✎  Edit";
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);

            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(820, 13);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteUser.Text = "🗑  Delete";
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);

            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(10, 78);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(930, 530);
            StyleGrid(this.dgvUsers);

            // ══════════════════════════════════════════════════
            // TAB 4 — SETTINGS
            // ══════════════════════════════════════════════════
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.tabSettings.Controls.Add(this.pnlSettingsCard);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Text = "  ⚙  Settings  ";

            this.pnlSettingsCard.BackColor = System.Drawing.Color.White;
            this.pnlSettingsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettingsCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPINTitle, this.lblPINHint, this.pnlPINDivider1,
                this.lblCurrentPINLabel, this.txtCurrentPIN, this.btnShowPIN,
                this.pnlPINDivider,
                this.lblNewPINLabel, this.txtNewPIN,
                this.lblConfirmPINLabel, this.txtConfirmPIN,
                this.btnSavePIN
            });
            this.pnlSettingsCard.Location = new System.Drawing.Point(10, 10);
            this.pnlSettingsCard.Name = "pnlSettingsCard";
            this.pnlSettingsCard.Size = new System.Drawing.Size(500, 380);

            this.lblPINTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPINTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblPINTitle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.lblPINTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPINTitle.Height = 44;
            this.lblPINTitle.Name = "lblPINTitle";
            this.lblPINTitle.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblPINTitle.Text = "🔒  Manager Override PIN";
            this.lblPINTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblPINHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPINHint.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblPINHint.Location = new System.Drawing.Point(16, 56);
            this.lblPINHint.Name = "lblPINHint";
            this.lblPINHint.Size = new System.Drawing.Size(465, 18);
            this.lblPINHint.Text = "This PIN is required by the Cashier to edit a customer's order.";

            this.pnlPINDivider1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlPINDivider1.Location = new System.Drawing.Point(16, 82);
            this.pnlPINDivider1.Size = new System.Drawing.Size(465, 1);
            this.pnlPINDivider1.Name = "pnlPINDivider1";

            this.lblCurrentPINLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCurrentPINLabel.Location = new System.Drawing.Point(16, 96);
            this.lblCurrentPINLabel.Name = "lblCurrentPINLabel";
            this.lblCurrentPINLabel.Size = new System.Drawing.Size(110, 22);
            this.lblCurrentPINLabel.Text = "Current PIN:";

            this.txtCurrentPIN.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPIN.Location = new System.Drawing.Point(16, 120);
            this.txtCurrentPIN.Name = "txtCurrentPIN";
            this.txtCurrentPIN.ReadOnly = true;
            this.txtCurrentPIN.Size = new System.Drawing.Size(120, 28);
            this.txtCurrentPIN.UseSystemPasswordChar = true;
            this.txtCurrentPIN.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.btnShowPIN.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnShowPIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPIN.ForeColor = System.Drawing.Color.White;
            this.btnShowPIN.Location = new System.Drawing.Point(146, 120);
            this.btnShowPIN.Name = "btnShowPIN";
            this.btnShowPIN.Size = new System.Drawing.Size(100, 28);
            this.btnShowPIN.Text = "Show PIN";
            this.btnShowPIN.FlatAppearance.BorderSize = 0;
            this.btnShowPIN.Click += new System.EventHandler(this.btnShowPIN_Click);

            this.pnlPINDivider.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.pnlPINDivider.Location = new System.Drawing.Point(16, 162);
            this.pnlPINDivider.Name = "pnlPINDivider";
            this.pnlPINDivider.Size = new System.Drawing.Size(465, 1);

            this.lblNewPINLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblNewPINLabel.Location = new System.Drawing.Point(16, 176);
            this.lblNewPINLabel.Name = "lblNewPINLabel";
            this.lblNewPINLabel.Size = new System.Drawing.Size(100, 22);
            this.lblNewPINLabel.Text = "New PIN:";

            this.txtNewPIN.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPIN.Location = new System.Drawing.Point(16, 200);
            this.txtNewPIN.MaxLength = 4;
            this.txtNewPIN.Name = "txtNewPIN";
            this.txtNewPIN.Size = new System.Drawing.Size(120, 28);
            this.txtNewPIN.UseSystemPasswordChar = true;
            this.txtNewPIN.TextChanged += new System.EventHandler(this.txtNewPIN_TextChanged);
            this.txtNewPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPIN_KeyPress);

            this.lblConfirmPINLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPINLabel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblConfirmPINLabel.Location = new System.Drawing.Point(16, 242);
            this.lblConfirmPINLabel.Name = "lblConfirmPINLabel";
            this.lblConfirmPINLabel.Size = new System.Drawing.Size(130, 22);
            this.lblConfirmPINLabel.Text = "Confirm New PIN:";

            this.txtConfirmPIN.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPIN.Location = new System.Drawing.Point(16, 266);
            this.txtConfirmPIN.MaxLength = 4;
            this.txtConfirmPIN.Name = "txtConfirmPIN";
            this.txtConfirmPIN.Size = new System.Drawing.Size(120, 28);
            this.txtConfirmPIN.UseSystemPasswordChar = true;
            this.txtConfirmPIN.TextChanged += new System.EventHandler(this.txtConfirmPIN_TextChanged);
            this.txtConfirmPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPIN_KeyPress);

            this.btnSavePIN.BackColor = System.Drawing.Color.FromArgb(255, 111, 0);
            this.btnSavePIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePIN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePIN.ForeColor = System.Drawing.Color.White;
            this.btnSavePIN.Location = new System.Drawing.Point(16, 312);
            this.btnSavePIN.Name = "btnSavePIN";
            this.btnSavePIN.Size = new System.Drawing.Size(220, 44);
            this.btnSavePIN.Text = "💾  Save New PIN";
            this.btnSavePIN.FlatAppearance.BorderSize = 0;
            this.btnSavePIN.Click += new System.EventHandler(this.btnSavePIN_Click);

            // ── ManagerForm ───────────────────────────────────
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(960, 700);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manager Dashboard";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlHeader, this.tabControl });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
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
            this.pnlSettingsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
        }

        private void MakeFormRow(
            System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt,
            string labelText, int left, int top)
        {
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Size = new System.Drawing.Size(95, 22);
            lbl.Text = labelText;

            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            txt.Location = new System.Drawing.Point(left + 100, top - 2);
            txt.Size = new System.Drawing.Size(230, 26);
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        // ── Declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Panel pnlMenuLeft;
        private System.Windows.Forms.Label lblMenuListTitle;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnRefreshMenu;
        private System.Windows.Forms.Panel pnlMenuRight;
        private System.Windows.Forms.Label lblMenuFormTitle;
        private System.Windows.Forms.Panel pnlMenuFormCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Panel pnlReportsTop;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Button btnShowOrders;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel pnlUsersTop;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel pnlSettingsCard;
        private System.Windows.Forms.Label lblPINTitle;
        private System.Windows.Forms.Label lblPINHint;
        private System.Windows.Forms.Panel pnlPINDivider1;
        private System.Windows.Forms.Label lblCurrentPINLabel;
        private System.Windows.Forms.TextBox txtCurrentPIN;
        private System.Windows.Forms.Button btnShowPIN;
        private System.Windows.Forms.Panel pnlPINDivider;
        private System.Windows.Forms.Label lblNewPINLabel;
        private System.Windows.Forms.TextBox txtNewPIN;
        private System.Windows.Forms.Label lblConfirmPINLabel;
        private System.Windows.Forms.TextBox txtConfirmPIN;
        private System.Windows.Forms.Button btnSavePIN;
    }
}