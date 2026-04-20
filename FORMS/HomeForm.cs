using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class HomeForm : Form
    {
        private readonly Dictionary<string, Form> _openSessions = new Dictionary<string, Form>();

        public HomeForm()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            try
            {
                string logoPath = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "logo.png");
                if (System.IO.File.Exists(logoPath))
                {
                    picLogo.Image    = Image.FromFile(logoPath);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    picLogo.BackColor = Color.FromArgb(30, 40, 60);
            }
            catch { picLogo.BackColor = Color.FromArgb(30, 40, 60); }
        }

        // ── Button handlers ───────────────────────────────────
        private void btnCustomer_Click(object sender, EventArgs e) => OpenRoleWindow("customer");
        private void btnCashier_Click (object sender, EventArgs e) => OpenRoleWindow("cashier");
        private void btnCook_Click    (object sender, EventArgs e) => OpenRoleWindow("cook");
        private void btnManager_Click (object sender, EventArgs e) => OpenRoleWindow("manager");
        private void btnOwner_Click   (object sender, EventArgs e) => OpenRoleWindow("owner");
        private void btnStart_Click   (object sender, EventArgs e) => OpenRoleWindow("customer");

        private void btnKDS_Click(object sender, EventArgs e)
        {
            if (_openSessions.ContainsKey("kds") && !_openSessions["kds"].IsDisposed)
            {
                _openSessions["kds"].BringToFront();
                return;
            }
            var kds = new KDSForm();
            kds.StartPosition = FormStartPosition.Manual;
            kds.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width  - kds.Width)  / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - kds.Height) / 2);
            _openSessions["kds"] = kds;
            kds.FormClosed += (fs, fe) => _openSessions.Remove("kds");
            kds.Show();
        }

        // ── Main routing ──────────────────────────────────────
        private void OpenRoleWindow(string role)
        {
            // Already open — just bring to front
            if (_openSessions.ContainsKey(role) && !_openSessions[role].IsDisposed)
            {
                _openSessions[role].BringToFront();
                _openSessions[role].Focus();
                return;
            }

            // All roles go through login — including Customer
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK) return;
            var loggedInUser = loginForm.LoggedInUser;

            // ── Role enforcement ──────────────────────────────
            bool allowed = false;
            switch (role)
            {
                case "customer": allowed = loggedInUser.Role.ToLower() == "customer"; break;
                case "cashier":  allowed = loggedInUser.Role.ToLower() == "cashier";  break;
                case "cook":     allowed = loggedInUser.Role.ToLower() == "cook";     break;
                case "manager":  allowed = loggedInUser.Role.ToLower() == "manager";  break;
                case "owner":    allowed = loggedInUser.Role.ToLower() == "owner";    break;
            }

            if (!allowed)
            {
                string extra = (loggedInUser.Role.ToLower() == "owner" && role == "manager")
                    ? "\n\nTip: Use the 👑 Owner Dashboard button instead."
                    : "\n\nPlease log in with the correct account.";
                MessageBox.Show(
                    $"Access Denied!\n\n'{loggedInUser.Username}' has the role '{loggedInUser.Role}'.\n" +
                    $"The {char.ToUpper(role[0]) + role.Substring(1)} button is for that role only." +
                    extra,
                    "Wrong Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Create the correct form ───────────────────────
            Form roleForm = null;
            switch (loggedInUser.Role.ToLower())
            {
                case "customer": roleForm = new CustomerForm(loggedInUser); break;
                case "cashier":  roleForm = new CashierForm();              break;
                case "cook":     roleForm = new CookForm();                 break;
                case "manager":  roleForm = new ManagerForm();              break;
                case "owner":    roleForm = new OwnerForm();                break;
                default:
                    MessageBox.Show("Unknown role: " + loggedInUser.Role);
                    return;
            }

            PositionWindow(roleForm, loggedInUser.Role.ToLower());

            string sessionKey = loggedInUser.Role.ToLower();
            _openSessions[sessionKey] = roleForm;
            UpdateSessionLabel(sessionKey, loggedInUser.Username, true);

            roleForm.FormClosed += (s, e) =>
            {
                _openSessions.Remove(sessionKey);
                UpdateSessionLabel(sessionKey, loggedInUser.Username, false);
            };

            roleForm.Show();
        }

        private void PositionWindow(Form form, string role)
        {
            var screen = Screen.PrimaryScreen.WorkingArea;
            form.StartPosition = FormStartPosition.Manual;
            switch (role)
            {
                case "customer":
                    form.Location = new Point(20, 50);
                    break;
                case "cashier":
                    form.Location = new Point(screen.Width - form.Width - 20, 50);
                    break;
                case "cook":
                    form.Location = new Point(20, screen.Height - form.Height - 50);
                    break;
                case "manager":
                case "owner":
                    form.Location = new Point(screen.Width - form.Width - 20, screen.Height - form.Height - 50);
                    break;
                default:
                    form.StartPosition = FormStartPosition.CenterScreen;
                    break;
            }
        }

        private void UpdateSessionLabel(string role, string username, bool active)
        {
            Label lbl         = null;
            Color activeColor = Color.FromArgb(33, 150, 243);

            switch (role)
            {
                case "customer": lbl = lblCustomerStatus; activeColor = Color.FromArgb(255, 111, 0);   break;
                case "cashier":  lbl = lblCashierStatus;  activeColor = Color.FromArgb(33,  150, 243); break;
                case "cook":     lbl = lblCookStatus;     activeColor = Color.FromArgb(255, 111, 0);   break;
                case "manager":  lbl = lblManagerStatus;  activeColor = Color.FromArgb(13,  71,  161); break;
                case "owner":    lbl = lblOwnerStatus;    activeColor = Color.FromArgb(183, 110, 0);   break;
            }

            if (lbl == null) return;

            string roleName = char.ToUpper(role[0]) + role.Substring(1);
            if (active)
            {
                lbl.Text      = $"● {roleName}  —  {username}  ✔ Active";
                lbl.ForeColor = activeColor;
                lbl.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            else
            {
                lbl.Text      = $"● {roleName}  —  Not active";
                lbl.ForeColor = Color.FromArgb(189, 189, 189);
                lbl.Font      = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (var f in _openSessions.Values)
                if (!f.IsDisposed) f.Close();
            base.OnFormClosed(e);
        }
    }
}
