using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class CustomerForm : Form
    {
        private MenuItemRepository _menuRepo = new MenuItemRepository();
        private OrderRepository _orderRepo = new OrderRepository();
        private List<OrderDetail> _cart = new List<OrderDetail>();
        private User _currentUser;
        private System.Windows.Forms.Timer _statusTimer;
        private int _lastOrderID = 0;

        public CustomerForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            lblHeaderTitle.Text = $"CUSTOMER  —  {user.Username}";
            LoadMenuCategories();
            LoadMenu("All");
            StartStatusRefresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e) => LoadMenu("All");
        private void btnBurgers_Click(object sender, EventArgs e) => LoadMenu("Burgers");
        private void btnChicken_Click(object sender, EventArgs e) => LoadMenu("Chicken");
        private void btnSides_Click(object sender, EventArgs e) => LoadMenu("Sides");
        private void btnDrinks_Click(object sender, EventArgs e) => LoadMenu("Drinks");
        private void btnDesserts_Click(object sender, EventArgs e) => LoadMenu("Desserts");

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int index = dgvCart.SelectedRows[0].Index;
            if (index < _cart.Count) _cart.RemoveAt(index);
            RefreshCart();
        }

        private void btnPlace_Click(object sender, EventArgs e) => PlaceOrder();
        private void btnClear_Click(object sender, EventArgs e) { _cart.Clear(); RefreshCart(); }
        private void btnNewOrder_Click(object sender, EventArgs e) { pnlStatus.Visible = false; _lastOrderID = 0; }

        private void LoadMenuCategories()
        {
            // Category buttons already in designer — just wire them up
        }

        private void LoadMenu(string category)
        {
            flpMenu.Controls.Clear();
            DataTable dt = category == "All" ? _menuRepo.GetAll() : _menuRepo.GetByCategory(category);

            foreach (DataRow row in dt.Rows)
            {
                int itemID = Convert.ToInt32(row["itemID"]);
                string name = row["name"].ToString();
                double price = Convert.ToDouble(row["price"]);
                string cat = row["category"].ToString();

                var card = new Panel { Size = new Size(130, 110), Margin = new Padding(5), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
                var lName = new Label { Text = name, Left = 5, Top = 8, Width = 120, Height = 38, Font = new Font("Segoe UI", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter };
                var lCat = new Label { Text = cat, Left = 5, Top = 46, Width = 120, Font = new Font("Segoe UI", 8), TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Gray };
                var lPrice = new Label { Text = $"₱{price:F2}", Left = 5, Top = 62, Width = 120, Font = new Font("Segoe UI", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.FromArgb(39, 174, 96) };
                var bAdd = new Button { Text = "+ Add", Left = 15, Top = 82, Width = 100, Height = 24, BackColor = Color.FromArgb(33, 150, 243), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 8) };
                bAdd.FlatAppearance.BorderSize = 0;

                int ci = itemID; string cn = name; double cp = price;
                bAdd.Click += (s, ev) => AddToCart(ci, cn, cp);
                card.Controls.AddRange(new Control[] { lName, lCat, lPrice, bAdd });
                flpMenu.Controls.Add(card);
            }
        }

        private void AddToCart(int itemID, string name, double price)
        {
            var ex = _cart.Find(x => x.ItemID == itemID);
            if (ex != null) ex.Quantity++;
            else _cart.Add(new OrderDetail { ItemID = itemID, ItemName = name, Price = price, Quantity = 1 });
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

        private void PlaceOrder()
        {
            // Validation 1: cart must not be empty
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!\nPlease add items before placing an order.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation 2: check for zero quantity items (safety check)
            foreach (var item in _cart)
            {
                if (item.Quantity <= 0)
                {
                    MessageBox.Show($"Invalid quantity for '{item.ItemName}'.\nPlease remove and re-add the item.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validation 3: confirm before placing
            double total = 0;
            foreach (var item in _cart) total += item.GetSubtotal();

            var confirmMsg = $"Confirm your order?\n\nItems: {_cart.Count}\nTotal: ₱{total:F2}";
            if (MessageBox.Show(confirmMsg, "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var order = new Order { UserID = _currentUser.UserID, TotalAmount = total };
            int orderID = _orderRepo.CreateOrder(order);
            foreach (var d in _cart) { d.OrderID = orderID; _orderRepo.AddOrderDetail(d); }

            _lastOrderID = orderID;
            _cart.Clear();
            RefreshCart();

            lblOrderNum.Text = $"Order #{orderID}  |  Total: ₱{total:F2}";
            lblStatusValue.Text = "PENDING";
            lblStatusValue.ForeColor = Color.FromArgb(243, 156, 18);
            pnlStatus.Visible = true;

            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{orderID} placed!\nTotal: ₱{total:F2}\n\nPlease proceed to the cashier.", "Order Placed");
        }

        private void StartStatusRefresh()
        {
            _statusTimer = new System.Windows.Forms.Timer { Interval = 5000 };
            _statusTimer.Tick += (s, e) => RefreshOrderStatus();
            _statusTimer.Start();
        }

        private void RefreshOrderStatus()
        {
            if (_lastOrderID == 0 || !pnlStatus.Visible) return;
            // Only show status for current session's order
            string status = _orderRepo.GetOrderStatus(_lastOrderID);
            if (string.IsNullOrEmpty(status)) return;

            lblStatusValue.Text = status.ToUpper();
            switch (status)
            {
                case "Pending": lblStatusValue.ForeColor = Color.FromArgb(243, 156, 18); break;
                case "Paid": lblStatusValue.ForeColor = Color.FromArgb(33, 150, 243); break;
                case "Preparing": lblStatusValue.ForeColor = Color.FromArgb(155, 89, 182); break;
                case "Ready":
                    lblStatusValue.ForeColor = Color.FromArgb(39, 174, 96);
                    MessageBox.Show($"Order #{_lastOrderID} is READY!\nPlease collect at the counter.", "Order Ready!");
                    break;
                case "Completed": lblStatusValue.ForeColor = Color.Gray; break;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _statusTimer?.Stop();
            base.OnFormClosed(e);
        }
    }
}