using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    // ══════════════════════════════════════════════════════════
    //  CustomerForm — Kiosk mode WITH login
    //
    //  SCREEN FLOW:
    //    [IDLE] → touch → LoginForm → [ORDERING] → place order
    //          → [CONFIRMATION + receipt] → auto-reset to [IDLE]
    //
    //  Orders are recorded under the logged-in user's real ID,
    //  so analytics, payments and reports all work correctly.
    // ══════════════════════════════════════════════════════════
    public partial class CustomerForm : Form
    {
        // ── Repositories ──────────────────────────────────────
        private readonly MenuItemRepository _menuRepo = new MenuItemRepository();
        private readonly OrderRepository _orderRepo = new OrderRepository();

        // ── Logged-in customer for this session ───────────────
        private User _currentUser = null;

        // ── Cart ──────────────────────────────────────────────
        private List<OrderDetail> _cart = new List<OrderDetail>();

        // ── Last placed order ─────────────────────────────────
        private int _lastOrderID = 0;
        private double _lastTotal = 0;

        // ── Countdown timer (auto-reset after order) ──────────
        private System.Windows.Forms.Timer _countdownTimer;
        private int _secondsLeft;
        private const int RESET_SECONDS = 15;

        // ── Image cache ───────────────────────────────────────
        private static readonly string _imgDir = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "MenuImages");

        private static readonly Dictionary<string, Image> _imageCache
            = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        private static readonly Dictionary<string, string> _catEmoji =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Burgers","🍔"},{"Chicken","🍗"},
            {"Sides","🍟"},{"Drinks","🥤"},{"Desserts","🍦"},
        };

        private static readonly Dictionary<string, Color> _catColor =
            new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase)
        {
            {"Burgers", Color.FromArgb(255, 87,  34)},
            {"Chicken", Color.FromArgb(255,152,   0)},
            {"Sides",   Color.FromArgb(255,193,   7)},
            {"Drinks",  Color.FromArgb(  3,169, 244)},
            {"Desserts",Color.FromArgb(233, 30,  99)},
        };

        private static readonly Dictionary<string, string> _imageMap =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Double Cheeseburger",    "double_cheeseburger.jpg"},
            {"Bacon Burger",           "bacon_burger.jpg"},
            {"BBQ Burger",             "bbq_burger.jpg"},
            {"Mushroom Swiss Burger",  "mushroom_swiss_burger.jpg"},
            {"Spicy Chicken Burger",   "spicy_chicken_burger.jpg"},
            {"Fried Chicken (2 pcs)",  "fried_chicken.jpg"},
            {"Chicken Nuggets (6 pcs)","chicken_nuggets.jpg"},
            {"Chicken Fillet",         "chicken_fillet.jpg"},
            {"Spicy Chicken Wings",    "spicy_chicken_wings.jpg"},
            {"Onion Rings",            "onion_rings.jpg"},
            {"Mozzarella Sticks",      "mozzarella_sticks.jpg"},
            {"Coleslaw",               "coleslaw.jpg"},
            {"Iced Tea",               "iced_tea.jpg"},
            {"Lemonade",               "lemonade.jpg"},
            {"Bottled Water",          "bottled_water.jpg"},
            {"Milk Tea",               "milk_tea.jpg"},
            {"Chocolate Sundae",       "chocolate_sundae.jpg"},
            {"Brownie",                "brownie.jpg"},
            {"Oreo McFlurry",          "oreo_mcflurry.jpg"},
            {"Cheeseburger",           "cheeseburger.jpg"},
            {"Crispy Chicken",         "crispy_chciken.jpg"},
            {"French Fries",           "french_fries.jpg"},
            {"Coke Regular",           "coke_regular.jpg"},
            {"Sundae Cup",             "sundae_cup.jpg"},
        };

        // ════════════════════════════════════════════════════
        //  Constructor
        // ════════════════════════════════════════════════════
        public CustomerForm()
        {
            InitializeComponent();
            WireIdleEvents();
            ShowIdle();
            Task.Run(() => PreloadImages());
        }

        // Keep compatibility with old call CustomerForm(user)
        public CustomerForm(User user) : this()
        {
            // Store the user so when they touch the idle screen,
            // TryLogin is skipped and ordering starts immediately
            if (user != null)
            {
                _currentUser = user;
                lblHeaderTitle.Text = $"CUSTOMER  —  {user.Username}";
                // Do NOT call StartOrdering() here — let idle show first
                // Touching the screen will call TryLogin which we override below
            }
        }

        // ── Wire every idle panel control to trigger login ────
        private void WireIdleEvents()
        {
            pnlIdle.Click += (s, e) => TryLogin();
            lblIdleLogo.Click += (s, e) => TryLogin();
            lblIdleTitle.Click += (s, e) => TryLogin();
            lblIdleTouch.Click += (s, e) => TryLogin();
            lblIdleSub.Click += (s, e) => TryLogin();
        }

        // ════════════════════════════════════════════════════
        //  LOGIN GATE
        // ════════════════════════════════════════════════════
        private void TryLogin()
        {
            // If user was already passed in from HomeForm, skip login dialog
            if (_currentUser != null)
            {
                StartOrdering();
                return;
            }

            var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) return;

            var user = login.LoggedInUser;

            if (user.Role.ToLower() != "customer")
            {
                MessageBox.Show(
                    $"This kiosk is for Customers only.\n\n" +
                    $"'{user.Username}' has the role '{user.Role}'.\n" +
                    $"Please use the correct window from the Home screen.",
                    "Wrong Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentUser = user;
            lblHeaderTitle.Text = $"CUSTOMER  —  {user.Username}";
            StartOrdering();
        }

        // ════════════════════════════════════════════════════
        //  SCREEN SWITCHES
        // ════════════════════════════════════════════════════
        private void ShowIdle()
        {
            StopCountdown();
            _cart.Clear();
            RefreshCart();
            _lastOrderID = 0;
            _lastTotal   = 0;
            // _currentUser stays set — no re-login between customers

            pnlIdle.Visible         = true;
            pnlOrdering.Visible     = false;
            pnlConfirmation.Visible = false;
            pnlIdle.BringToFront();
        }

        private void StartOrdering()
        {
            pnlIdle.Visible = false;
            pnlOrdering.Visible = true;
            pnlConfirmation.Visible = false;
            pnlOrdering.BringToFront();

            if (flpMenu.Controls.Count == 0)
                LoadMenu("All");
        }

        private void ShowConfirmation()
        {
            pnlIdle.Visible = false;
            pnlOrdering.Visible = false;
            pnlConfirmation.Visible = true;
            pnlConfirmation.BringToFront();

            lblBigOrderNum.Text = $"#{_lastOrderID}";
            lblConfirmTotal.Text = $"Total: ₱{_lastTotal:F2}";

            lstConfirmItems.Items.Clear();
            foreach (var item in _cart)
                lstConfirmItems.Items.Add(
                    $"  {item.Quantity}x  {item.ItemName}  —  ₱{item.GetSubtotal():F2}");

            StartCountdown();
        }

        // ════════════════════════════════════════════════════
        //  COUNTDOWN — auto-resets to idle after RESET_SECONDS
        // ════════════════════════════════════════════════════
        private void StartCountdown()
        {
            _secondsLeft = RESET_SECONDS;
            lblCountdown.Text = $"Screen resets in {_secondsLeft} seconds...";

            _countdownTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _countdownTimer.Tick += (s, e) =>
            {
                _secondsLeft--;
                lblCountdown.Text = $"Screen resets in {_secondsLeft} seconds...";
                if (_secondsLeft <= 0) ShowIdle();
            };
            _countdownTimer.Start();
        }

        private void StopCountdown()
        {
            _countdownTimer?.Stop();
            _countdownTimer?.Dispose();
            _countdownTimer = null;
        }

        // ════════════════════════════════════════════════════
        //  CATEGORY + CART BUTTONS
        // ════════════════════════════════════════════════════
        private void btnAll_Click(object sender, EventArgs e) => LoadMenu("All");
        private void btnBurgers_Click(object sender, EventArgs e) => LoadMenu("Burgers");
        private void btnChicken_Click(object sender, EventArgs e) => LoadMenu("Chicken");
        private void btnSides_Click(object sender, EventArgs e) => LoadMenu("Sides");
        private void btnDrinks_Click(object sender, EventArgs e) => LoadMenu("Drinks");
        private void btnDesserts_Click(object sender, EventArgs e) => LoadMenu("Desserts");

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int idx = dgvCart.SelectedRows[0].Index;
            if (idx < 0 || idx >= _cart.Count) return;

            if (_cart[idx].Quantity > 1)
                _cart[idx].Quantity--;
            else
                _cart.RemoveAt(idx);

            RefreshCart();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int idx = dgvCart.SelectedRows[0].Index;
            if (idx < 0 || idx >= _cart.Count) return;
            _cart[idx].Quantity++;
            RefreshCart();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();
        }

        private void btnPlace_Click(object sender, EventArgs e) => PlaceOrder();

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintKioskReceipt();
            ShowIdle();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            StopCountdown();
            ShowIdle();
        }

        // ════════════════════════════════════════════════════
        //  PLACE ORDER — uses real logged-in user ID
        // ════════════════════════════════════════════════════
        private void PlaceOrder()
        {
            if (_currentUser == null)
            {
                ShowIdle();
                return;
            }

            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!\nPlease add items first.",
                    "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = 0;
            foreach (var item in _cart) total += item.GetSubtotal();

            if (MessageBox.Show(
                $"Confirm order?\n\nItems: {_cart.Count}\nTotal: ₱{total:F2}\n\nProceed?",
                "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            // ── Save to database under real user ID ───────────
            var order = new Order
            {
                UserID = _currentUser.UserID,   // real user, not guest
                TotalAmount = total
            };
            int orderID = _orderRepo.CreateOrder(order);
            foreach (var d in _cart)
            {
                d.OrderID = orderID;
                _orderRepo.AddOrderDetail(d);
            }

            _lastOrderID = orderID;
            _lastTotal = total;

            SessionManager.NotifyOrderChanged();
            ShowConfirmation();
        }

        // ════════════════════════════════════════════════════
        //  KIOSK RECEIPT PRINT
        // ════════════════════════════════════════════════════
        private void PrintKioskReceipt()
        {
            var pd = new PrintDocument();
            pd.PrintPage += (s, e) =>
            {
                Graphics g = e.Graphics;
                float x = 40f;
                float y = 30f;
                float lineH = 22f;

                var fTitle = new Font("Courier New", 13, FontStyle.Bold);
                var fBold = new Font("Courier New", 10, FontStyle.Bold);
                var fNormal = new Font("Courier New", 9, FontStyle.Regular);
                var fSmall = new Font("Courier New", 8, FontStyle.Regular);
                var bBlue = new SolidBrush(Color.FromArgb(13, 71, 161));
                var bOrange = new SolidBrush(Color.FromArgb(255, 111, 0));
                var bBlack = new SolidBrush(Color.Black);
                var bGray = new SolidBrush(Color.Gray);

                g.DrawString("DECIERDO KIOSK", fTitle, bBlue, x, y); y += 26;
                g.DrawString("Self-Service Ordering", fSmall, bGray, x, y); y += lineH;
                g.DrawString(new string('-', 36), fNormal, bGray, x, y); y += lineH;
                g.DrawString($"Order #: {_lastOrderID}", fBold, bBlack, x, y); y += lineH;
                g.DrawString($"Customer: {_currentUser?.Username ?? "Guest"}", fNormal, bBlack, x, y); y += lineH;
                g.DrawString($"Date: {DateTime.Now:MM/dd/yyyy hh:mm tt}", fNormal, bBlack, x, y); y += lineH;
                g.DrawString(new string('-', 36), fNormal, bGray, x, y); y += lineH;
                g.DrawString("QTY  ITEM                PRICE", fBold, bBlack, x, y); y += lineH;
                g.DrawString(new string('-', 36), fNormal, bGray, x, y); y += lineH;

                foreach (var item in _cart)
                {
                    string nm = item.ItemName.Length > 18
                        ? item.ItemName.Substring(0, 18)
                        : item.ItemName.PadRight(18);
                    g.DrawString($"{item.Quantity,-4} {nm}  P{item.GetSubtotal():F2}",
                        fNormal, bBlack, x, y);
                    y += lineH;
                }

                g.DrawString(new string('-', 36), fNormal, bGray, x, y); y += lineH;
                g.DrawString($"{"TOTAL:",-22} P{_lastTotal:F2}", fBold, bOrange, x, y); y += lineH;
                g.DrawString(new string('-', 36), fNormal, bGray, x, y); y += lineH;
                g.DrawString("Proceed to cashier to pay", fBold, bBlue, x, y); y += lineH;
                g.DrawString("Thank you! Please come again :)", fSmall, bGray, x, y);

                fTitle.Dispose(); fBold.Dispose(); fNormal.Dispose(); fSmall.Dispose();
                bBlue.Dispose(); bOrange.Dispose(); bBlack.Dispose(); bGray.Dispose();
            };

            try
            {
                var preview = new PrintPreviewDialog
                {
                    Document = pd,
                    Width = 500,
                    Height = 700,
                    StartPosition = FormStartPosition.CenterScreen
                };
                preview.ShowDialog();
            }
            catch { /* no printer — just skip and reset */ }
        }

        // ════════════════════════════════════════════════════
        //  MENU LOADING + CARD BUILDING
        // ════════════════════════════════════════════════════
        private void LoadMenu(string category)
        {
            foreach (Control c in flpMenu.Controls) c.Dispose();
            flpMenu.Controls.Clear();

            DataTable dt = category == "All"
                ? _menuRepo.GetAll()
                : _menuRepo.GetByCategory(category);

            flpMenu.SuspendLayout();
            foreach (DataRow row in dt.Rows)
            {
                int itemID = Convert.ToInt32(row["itemID"]);
                string name = row["name"].ToString();
                double price = Convert.ToDouble(row["price"]);
                string cat = row["category"].ToString();
                flpMenu.Controls.Add(BuildCard(itemID, name, price, cat));
            }
            flpMenu.ResumeLayout(true);
        }

        private Panel BuildCard(int itemID, string name, double price, string category)
        {
            Color accent = _catColor.TryGetValue(category, out Color ac)
                ? ac : Color.FromArgb(33, 150, 243);
            _imageCache.TryGetValue(name, out Image cachedImg);

            var card = new Panel
            {
                Size = new Size(155, 200),
                Margin = new Padding(6),
                BackColor = Color.White,
                Cursor = Cursors.Hand,
            };

            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(210, 210, 210), 1))
                    g.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                using (var b = new SolidBrush(accent))
                    g.FillRectangle(b, 0, 0, card.Width, 5);
                if (cachedImg != null)
                    g.DrawImage(cachedImg, new Rectangle(0, 5, card.Width, 92));
                else
                    DrawPlaceholder(g, category, new Rectangle(0, 5, card.Width, 92));
            };

            var lName = new Label
            {
                Text = name,
                Left = 4,
                Top = 100,
                Width = 147,
                Height = 36,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(30, 30, 30),
                BackColor = Color.Transparent,
            };
            var lPrice = new Label
            {
                Text = $"₱{price:F2}",
                Left = 4,
                Top = 136,
                Width = 147,
                Height = 20,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(39, 174, 96),
                BackColor = Color.Transparent,
            };
            var bAdd = new Button
            {
                Text = "+ Add to Cart",
                Left = 8,
                Top = 161,
                Width = 139,
                Height = 30,
                BackColor = accent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                Cursor = Cursors.Hand,
            };
            bAdd.FlatAppearance.BorderSize = 0;

            int ci = itemID; string cn = name; double cp = price;
            bAdd.Click += (s, ev) => AddToCart(ci, cn, cp);
            card.Click += (s, ev) => AddToCart(ci, cn, cp);
            lName.Click += (s, ev) => AddToCart(ci, cn, cp);
            lPrice.Click += (s, ev) => AddToCart(ci, cn, cp);

            card.Controls.AddRange(new Control[] { lName, lPrice, bAdd });
            return card;
        }

        private void DrawPlaceholder(Graphics g, string category, Rectangle rect)
        {
            Color bg = _catColor.TryGetValue(category, out Color c)
                ? Color.FromArgb(25, c.R, c.G, c.B) : Color.FromArgb(245, 245, 245);
            string emoji = _catEmoji.TryGetValue(category, out string em) ? em : "🍽";
            using (var b = new SolidBrush(bg)) g.FillRectangle(b, rect);
            using (var f = new Font("Segoe UI Emoji", 26f))
            using (var tb = new SolidBrush(Color.FromArgb(160, 160, 160)))
            {
                var sz = g.MeasureString(emoji, f);
                g.DrawString(emoji, f, tb,
                    rect.X + (rect.Width - sz.Width) / 2,
                    rect.Y + (rect.Height - sz.Height) / 2);
            }
        }

        private void AddToCart(int itemID, string name, double price)
        {
            var ex = _cart.Find(x => x.ItemID == itemID);
            if (ex != null) ex.Quantity++;
            else _cart.Add(new OrderDetail
            { ItemID = itemID, ItemName = name, Price = price, Quantity = 1 });
            RefreshCart();
        }

        private void RefreshCart()
        {
            dgvCart.Rows.Clear();
            double total = 0;
            foreach (var item in _cart)
            {
                double s = item.GetSubtotal();
                dgvCart.Rows.Add(item.ItemName, item.Quantity, $"₱{s:F2}");
                total += s;
            }
            lblTotal.Text = $"Total: ₱{total:F2}";
        }

        // ════════════════════════════════════════════════════
        //  IMAGE PRELOADING (background thread)
        // ════════════════════════════════════════════════════
        private void PreloadImages()
        {
            if (!Directory.Exists(_imgDir)) return;
            foreach (var kvp in _imageMap)
            {
                if (_imageCache.ContainsKey(kvp.Key)) continue;
                string path = Path.Combine(_imgDir, kvp.Value);
                if (!File.Exists(path)) continue;
                try
                {
                    byte[] bytes = File.ReadAllBytes(path);
                    using (var ms = new MemoryStream(bytes))
                    {
                        Image src = Image.FromStream(ms);
                        var thumb = new Bitmap(155, 92);
                        using (var g = Graphics.FromImage(thumb))
                        {
                            g.InterpolationMode =
                                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.DrawImage(src, 0, 0, 155, 92);
                        }
                        src.Dispose();
                        _imageCache[kvp.Key] = thumb;
                    }
                }
                catch { }
            }
            if (!IsDisposed)
                Invoke((Action)(() =>
                {
                    if (pnlOrdering.Visible && flpMenu.Controls.Count > 0)
                        LoadMenu("All");
                }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirm = MessageBox.Show("Are you sure you want to log out?",
                    "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) { e.Cancel = true; return; }
            }
            StopCountdown();
            foreach (var img in _imageCache.Values) img?.Dispose();
            _imageCache.Clear();
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}