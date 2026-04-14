using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class ReceiptForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private PaymentRepository _paymentRepo = new PaymentRepository();
        private int _orderID;
        private double _amountPaid;
        private string _method;
        private double _total;
        private double _change;

        public ReceiptForm(int orderID, double amountPaid, string method, double total)
        {
            _orderID = orderID;
            _amountPaid = amountPaid;
            _method = method;
            _total = total;
            _change = amountPaid - total;
            InitializeComponent();
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            // Header info
            lblOrderNum.Text = $"Order #  {_orderID}";
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm tt");

            // Order items
            DataTable dt = _orderRepo.GetOrderDetails(_orderID);
            dgvItems.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["name"].ToString();
                int qty = Convert.ToInt32(row["orderQty"]);
                double price = Convert.ToDouble(row["price"]);
                double sub = qty * price;
                dgvItems.Rows.Add(qty, name, $"₱{price:F2}", $"₱{sub:F2}");
            }

            // Totals
            lblSubtotalVal.Text = $"₱{_total:F2}";
            lblTotalVal.Text = $"₱{_total:F2}";
            lblMethodVal.Text = _method;
            lblPaidVal.Text = $"₱{_amountPaid:F2}";
            lblChangeVal.Text = $"₱{_change:F2}";

            // Change color — green if exact, blue if overpaid
            lblChangeVal.ForeColor = _change == 0
                ? Color.FromArgb(67, 160, 71)
                : Color.FromArgb(33, 150, 243);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += PrintReceiptPage;
            var preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 500,
                Height = 700,
                StartPosition = FormStartPosition.CenterScreen
            };
            preview.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float x = 40;
            float y = 30;
            float lineH = 22;

            var fontTitle = new Font("Courier New", 14, FontStyle.Bold);
            var fontBold = new Font("Courier New", 10, FontStyle.Bold);
            var fontNormal = new Font("Courier New", 9, FontStyle.Regular);
            var fontSmall = new Font("Courier New", 8, FontStyle.Regular);
            var bBlue = new SolidBrush(Color.FromArgb(13, 71, 161));
            var bOrange = new SolidBrush(Color.FromArgb(255, 111, 0));
            var bBlack = new SolidBrush(Color.Black);
            var bGray = new SolidBrush(Color.Gray);

            // Store name
            g.DrawString("DECIERDO KIOSK", fontTitle, bBlue, x, y); y += 28;
            g.DrawString("Self-Service Ordering System", fontSmall, bGray, x, y); y += lineH;
            g.DrawString(new string('-', 38), fontNormal, bGray, x, y); y += lineH;

            // Order info
            g.DrawString($"Order #: {_orderID}", fontBold, bBlack, x, y); y += lineH;
            g.DrawString($"Date:    {DateTime.Now:MM/dd/yyyy hh:mm tt}", fontNormal, bBlack, x, y); y += lineH;
            g.DrawString($"Method:  {_method}", fontNormal, bBlack, x, y); y += lineH;
            g.DrawString(new string('-', 38), fontNormal, bGray, x, y); y += lineH;

            // Column headers
            g.DrawString("QTY  ITEM                  PRICE", fontBold, bBlack, x, y); y += lineH;
            g.DrawString(new string('-', 38), fontNormal, bGray, x, y); y += lineH;

            // Items
            DataTable dt = _orderRepo.GetOrderDetails(_orderID);
            foreach (DataRow row in dt.Rows)
            {
                string name = row["name"].ToString();
                int qty = Convert.ToInt32(row["orderQty"]);
                double price = Convert.ToDouble(row["price"]);
                double sub = qty * price;
                string nameTrunc = name.Length > 18 ? name.Substring(0, 18) : name.PadRight(18);
                g.DrawString($"{qty,-4} {nameTrunc}  P{sub:F2}", fontNormal, bBlack, x, y);
                y += lineH;
            }

            g.DrawString(new string('-', 38), fontNormal, bGray, x, y); y += lineH;

            // Totals
            g.DrawString($"{"TOTAL:",-22} P{_total:F2}", fontBold, bOrange, x, y); y += lineH;
            g.DrawString($"{"PAID:",-22} P{_amountPaid:F2}", fontNormal, bBlack, x, y); y += lineH;
            g.DrawString($"{"CHANGE:",-22} P{_change:F2}", fontNormal, bBlack, x, y); y += lineH;
            g.DrawString(new string('-', 38), fontNormal, bGray, x, y); y += lineH;

            // Footer
            g.DrawString("  Thank you for your order!", fontBold, bBlue, x, y); y += lineH;
            g.DrawString("   Please come again soon :)", fontSmall, bGray, x, y);

            fontTitle.Dispose(); fontBold.Dispose();
            fontNormal.Dispose(); fontSmall.Dispose();
            bBlue.Dispose(); bOrange.Dispose();
            bBlack.Dispose(); bGray.Dispose();
        }
    }
}