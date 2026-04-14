using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class CashierForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private PaymentRepository _paymentRepo = new PaymentRepository();
        private System.Windows.Forms.Timer _refreshTimer;

        public CashierForm()
        {
            InitializeComponent();
            LoadActiveOrders();
            LoadCompletedOrders();
            StartAutoRefresh();
            SessionManager.OrderChanged += OnOrderChanged;
        }

        private void OnOrderChanged()
        {
            if (!IsDisposed) Invoke((Action)(() => {
                LoadActiveOrders();
                LoadCompletedOrders();
            }));
        }

        // ── Logout ────────────────────────────────────────────
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

        // ── Tab 1: Active Orders ──────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadActiveOrders();
            LoadCompletedOrders();
        }

        private void btnPay_Click(object sender, EventArgs e) => ProcessPayment();
        private void btnComplete_Click(object sender, EventArgs e) => MarkCompleted();

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dgvOrders.SelectedRows[0].Cells["status"].Value?.ToString();
            if (status != "Pending")
            {
                MessageBox.Show($"Only Pending orders can be modified.\nThis order is already '{status}'.",
                    "Cannot Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pinForm = new PINPromptForm();
            if (pinForm.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            var editForm = new EditOrderForm(orderID, status);
            if (editForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadActiveOrders();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e) => LoadOrderDetails();

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            txtAmountPaid.BackColor = Color.White;
            string t = lblTotal.Text.Replace("Total: ₱", "");
            if (double.TryParse(t, out double total) &&
                double.TryParse(txtAmountPaid.Text, out double paid))
                lblChange.Text = $"Change: ₱{Math.Max(0, paid - total):F2}";
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && txtAmountPaid.Text.Contains('.'))
                e.Handled = true;
        }

        private void LoadActiveOrders()
        {
            dgvOrders.DataSource = _orderRepo.GetOrdersByStatuses(new[] { "Pending", "Ready" });
        }

        private void LoadOrderDetails()
        {
            if (dgvOrders.SelectedRows.Count == 0) return;
            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            dgvDetails.DataSource = _orderRepo.GetOrderDetails(orderID);
            DataTable dt = _orderRepo.GetAllOrders();
            DataRow[] rows = dt.Select($"orderID = {orderID}");
            if (rows.Length > 0)
                lblTotal.Text = $"Total: ₱{Convert.ToDouble(rows[0]["totalAmount"]):F2}";
        }

        private void ProcessPayment()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string status = dgvOrders.SelectedRows[0].Cells["status"].Value?.ToString();
            if (status != "Pending")
            {
                MessageBox.Show("Only Pending orders can be processed.", "Invalid Status",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text))
            {
                txtAmountPaid.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Please enter the amount paid.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus(); return;
            }

            if (!double.TryParse(txtAmountPaid.Text, out double paid) || paid <= 0)
            {
                txtAmountPaid.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Please enter a valid amount.", "Invalid Amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus(); return;
            }

            double total = double.Parse(lblTotal.Text.Replace("Total: ₱", ""));
            if (paid < total)
            {
                txtAmountPaid.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show($"Insufficient payment.\nTotal is ₱{total:F2} but entered ₱{paid:F2}.",
                    "Insufficient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmountPaid.Focus(); return;
            }

            txtAmountPaid.BackColor = Color.White;
            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            _paymentRepo.RecordPayment(new Payment
            {
                OrderID = orderID,
                Amount = paid,
                Method = cboMethod.SelectedItem.ToString()
            });
            _orderRepo.UpdateStatus(orderID, "Paid");
            SessionManager.NotifyOrderChanged();

            // Show receipt immediately after payment
            var receipt = new ReceiptForm(orderID, paid, cboMethod.SelectedItem.ToString(), total);
            receipt.ShowDialog();

            txtAmountPaid.Clear();
            lblChange.Text = "Change: ₱0.00";
            LoadActiveOrders();
            LoadCompletedOrders();
        }

        private void MarkCompleted()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (dgvOrders.SelectedRows[0].Cells["status"].Value?.ToString() != "Ready")
            {
                MessageBox.Show("Only Ready orders can be completed.", "Invalid Status",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["orderID"].Value);
            _orderRepo.UpdateStatus(orderID, "Completed");
            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{orderID} marked as Completed!", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadActiveOrders();
            LoadCompletedOrders();
        }

        // ── Tab 2: Completed Orders ───────────────────────────
        private void btnRefreshCompleted_Click(object sender, EventArgs e) => LoadCompletedOrders();

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            if (dgvCompleted.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a completed order.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            int orderID = Convert.ToInt32(dgvCompleted.SelectedRows[0].Cells["orderID"].Value);
            double total = Convert.ToDouble(dgvCompleted.SelectedRows[0].Cells["totalAmount"].Value);

            // Get payment info
            DataTable payDt = _paymentRepo.GetPaymentByOrder(orderID);
            double amountPaid = total;
            string method = "Cash";
            if (payDt.Rows.Count > 0)
            {
                amountPaid = Convert.ToDouble(payDt.Rows[0]["amount"]);
                method = payDt.Rows[0]["method"].ToString();
            }

            var receipt = new ReceiptForm(orderID, amountPaid, method, total);
            receipt.ShowDialog();
        }

        private void LoadCompletedOrders()
        {
            dgvCompleted.DataSource = _orderRepo.GetOrdersByStatuses(new[] { "Completed" });
            // Show order count
            lblCompletedCount.Text = $"Total completed: {dgvCompleted.Rows.Count} orders";
        }

        // ── Auto refresh ──────────────────────────────────────
        private void StartAutoRefresh()
        {
            _refreshTimer = new System.Windows.Forms.Timer { Interval = 8000 };
            _refreshTimer.Tick += (s, e) => { LoadActiveOrders(); LoadCompletedOrders(); };
            _refreshTimer.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _refreshTimer?.Stop();
            SessionManager.OrderChanged -= OnOrderChanged;
            base.OnFormClosed(e);
        }
    }
}