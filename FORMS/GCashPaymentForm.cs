using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class GCashPaymentForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private int _orderID;
        private double _total;

        public bool PaymentConfirmed { get; private set; } = false;

        public GCashPaymentForm(int orderID, double total)
        {
            _orderID = orderID;
            _total = total;
            InitializeComponent();
            LoadOrderSummary();
        }

        private void LoadOrderSummary()
        {
            lblOrderNum.Text = $"Order #{_orderID}";
            lblAmountVal.Text = $"₱{_total:N2}";

            try
            {
                DataTable dt = _orderRepo.GetOrderDetails(_orderID);
                dgvItems.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["name"]?.ToString() ?? "";
                    int qty = Convert.ToInt32(row["orderQty"]);
                    double sub = Convert.ToDouble(row["subtotal"]);
                    dgvItems.Rows.Add($"{qty}x", name, $"₱{sub:N2}");
                }
            }
            catch { }

            lblTotalVal.Text = $"₱{_total:N2}";

            // Load QR image
            try
            {
                string qrPath = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "QRGCASH.jpg");
                if (System.IO.File.Exists(qrPath))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(qrPath);
                    using (var ms = new System.IO.MemoryStream(bytes))
                        picQR.Image = new System.Drawing.Bitmap(ms);
                }
            }
            catch { }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblAcctName_Click(object sender, EventArgs e)
        {

        }
    }
}
