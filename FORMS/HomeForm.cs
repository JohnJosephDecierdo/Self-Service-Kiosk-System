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

        // ?? Load logo image ??????????????????????????????????
        private void LoadLogo()
        {
            try
            {
                // Look for logo.png in same folder as the exe
                string logoPath = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "logo.png");

                if (System.IO.File.Exists(logoPath))
                {
                    picLogo.Image = Image.FromFile(logoPath);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Fallback: just show text if image not found
                    picLogo.BackColor = Color.FromArgb(30, 40, 60);
                }
            }
            catch
            {
                picLogo.BackColor = Color.FromArgb(30, 40, 60);
            }
        }

        // ?? Role button clicks ???????????????????????????????
        private void btnCustomer_Click(object sender, EventArgs e) => OpenRoleWindow("customer");
        private void btnCashier_Click(object sender, EventArgs e) => OpenRoleWindow("cashier");
        private void btnCook_Click(object sender, EventArgs e) => OpenRoleWindow("cook");
        private void btnManager_Click(object sender, EventArgs e) => OpenRoleWindow("manager");
        private void btnStart_Click(object sender, EventArgs e) => OpenRoleWindow("customer");

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
                (Screen.PrimaryScreen.WorkingArea.Width - kds.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - kds.Height) / 2
            );
            _openSessions["kds"] = kds;
            kds.FormClosed += (fs, fe) => _openSessions.Remove("kds");
            kds.Show();
        }

        // ?? Open role window without closing HomeForm ????????
        private void OpenRoleWindow(string role)
        {
            if (_openSessions.ContainsKey(role) && !_openSessions[role].IsDisposed)
            {
                _openSessions[role].BringToFront();
                _openSessions[role].Focus();
                return;
            }

            var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) return;

            var user = login.LoggedInUser;

            // ?? Role enforcement ??????????????????????????????
            // The button clicked must match the user's actual role.
            // Prevents a Customer from opening the Cashier window, etc.
            bool allowed = false;
            switch (role)
            {
                case "customer":
                    allowed = user.Role.ToLower() == "customer";
                    break;
                case "cashier":
                    allowed = user.Role.ToLower() == "cashier";
                    break;
                case "cook":
                    allowed = user.Role.ToLower() == "cook";
                    break;
                case "manager":
                    allowed = user.Role.ToLower() == "manager" || user.Role.ToLower() == "owner";
                    break;
            }

            if (!allowed)
            {
                MessageBox.Show(
                    $"Access Denied!\n\n'{user.Username}' has the role of '{user.Role}'.\n" +
                    $"This window is for {char.ToUpper(role[0]) + role.Substring(1)} only.\n\n" +
                    "Please log in with the correct account.",
                    "Wrong Role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Form roleForm = null;
            switch (user.Role.ToLower())
            {
                case "customer": roleForm = new CustomerForm(user); break;
                case "cashier": roleForm = new CashierForm(); break;
                case "cook": roleForm = new CookForm(); break;
                case "manager":
                case "owner": roleForm = new ManagerForm(); break;
                default:
                    MessageBox.Show("Unknown role: " + user.Role); return;
            }

            PositionWindow(roleForm, user.Role.ToLower());

            string sessionKey = user.Role.ToLower();
            _openSessions[sessionKey] = roleForm;
            UpdateSessionLabel(sessionKey, user.Username, true);

            roleForm.FormClosed += (s, e) =>
            {
                _openSessions.Remove(sessionKey);
                UpdateSessionLabel(sessionKey, user.Username, false);
            };

            roleForm.Show();
        }

        private void PositionWindow(Form form, string role)
        {
            var screen = Screen.PrimaryScreen.WorkingArea;
            switch (role)
            {
                case "customer": form.StartPosition = FormStartPosition.Manual; form.Location = new Point(20, 50); break;
                case "cashier": form.StartPosition = FormStartPosition.Manual; form.Location = new Point(screen.Width - form.Width - 20, 50); break;
                case "cook": form.StartPosition = FormStartPosition.Manual; form.Location = new Point(20, screen.Height - form.Height - 50); break;
                case "manager":
                case "owner": form.StartPosition = FormStartPosition.Manual; form.Location = new Point(screen.Width - form.Width - 20, screen.Height - form.Height - 50); break;
                default: form.StartPosition = FormStartPosition.CenterScreen; break;
            }
        }

        private void UpdateSessionLabel(string role, string username, bool active)
        {
            Label lbl = null;
            Color activeColor = Color.FromArgb(33, 150, 243);
            switch (role)
            {
                case "customer": lbl = lblCustomerStatus; activeColor = Color.FromArgb(255, 111, 0); break;
                case "cashier": lbl = lblCashierStatus; activeColor = Color.FromArgb(33, 150, 243); break;
                case "cook": lbl = lblCookStatus; activeColor = Color.FromArgb(255, 111, 0); break;
                case "manager":
                case "owner": lbl = lblManagerStatus; activeColor = Color.FromArgb(33, 150, 243); break;
            }
            if (lbl == null) return;

            string roleName = char.ToUpper(role[0]) + role.Substring(1);
            if (active)
            {
                lbl.Text = $"? {roleName}  —  {username}  ? Active";
                lbl.ForeColor = activeColor;
                lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            else
            {
                lbl.Text = $"? {roleName}  —  Not active";
                lbl.ForeColor = Color.FromArgb(189, 189, 189);
                lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
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