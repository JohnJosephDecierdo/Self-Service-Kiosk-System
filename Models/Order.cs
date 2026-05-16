using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    // ── Models ─────────────────────────────────────────────
    public class OrderDetail
    {
        public int DetailID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double GetSubtotal() => Price * Quantity;
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }  // Pending, Preparing, Ready, Completed

        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var d in Details) total += d.GetSubtotal();
            TotalAmount = total;
            return total;
        }
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public double Amount { get; set; }
        public string Method { get; set; }  // Cash, GCash, Card

        public bool ProcessPayment() => Amount > 0;
    }

    // ── Order Repository ───────────────────────────────────
    public class OrderRepository
    {
        public int CreateOrder(Order order)
        {
            string query = "INSERT INTO Orders (userID, orderDate, totalAmount, [status]) VALUES (?, ?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@u", OleDbType.Integer)  { Value = order.UserID },
                new OleDbParameter("@d", OleDbType.Date)     { Value = DateTime.Now },
                new OleDbParameter("@t", OleDbType.Double)   { Value = order.TotalAmount },
                new OleDbParameter("@s", OleDbType.VarWChar) { Value = "Pending" }
            };
            DatabaseHelper.ExecuteNonQuery(query, p);

            object id = DatabaseHelper.ExecuteScalar("SELECT MAX(orderID) FROM Orders");
            return Convert.ToInt32(id);
        }

        public bool AddOrderDetail(OrderDetail detail)
        {
            // Store price at time of ordering — protects against future price changes
            string query = "INSERT INTO OrderDetails (orderID, itemID, orderQty, price) VALUES (?, ?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@o", detail.OrderID),
                new OleDbParameter("@i", detail.ItemID),
                new OleDbParameter("@q", detail.Quantity),
                new OleDbParameter("@p", detail.Price)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool UpdateStatus(int orderID, string status)
        {
            string query = "UPDATE Orders SET [status] = ? WHERE orderID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@s",  status),
                new OleDbParameter("@id", orderID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public DataTable GetPendingOrders()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Orders WHERE [status] IN ('Pending','Preparing') ORDER BY orderDate");
        }

        public DataTable GetOrderDetails(int orderID)
        {
            // Use stored price from OrderDetails — accurate even if menu price changes later
            string query = @"SELECT od.detailID, od.orderQty, mi.name, 
                             od.price, (od.orderQty * od.price) AS subtotal
                             FROM (OrderDetails od
                             INNER JOIN MenuItems mi ON od.itemID = mi.itemID)
                             WHERE od.orderID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", orderID) };
            return DatabaseHelper.ExecuteQuery(query, p);
        }

        public DataTable GetAllOrders()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Orders ORDER BY orderDate DESC");
        }

        public DataTable GetOrdersByStatuses(string[] statuses)
        {
            string inClause = "'" + string.Join("','", statuses) + "'";
            return DatabaseHelper.ExecuteQuery(
                $"SELECT * FROM Orders WHERE [status] IN ({inClause}) ORDER BY orderDate");
        }

        public string GetOrderStatus(int orderID)
        {
            string query = "SELECT [status] FROM Orders WHERE orderID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", orderID) };
            object result = DatabaseHelper.ExecuteScalar(query, p);
            return result?.ToString();
        }

        public bool UpdateOrderDetailQty(int detailID, int newQty)
        {
            string query = "UPDATE OrderDetails SET orderQty = ? WHERE detailID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@q",  newQty),
                new OleDbParameter("@id", detailID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool DeleteOrderDetail(int detailID)
        {
            string query = "DELETE FROM OrderDetails WHERE detailID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", detailID) };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool UpdateOrderTotal(int orderID, double newTotal)
        {
            string query = "UPDATE Orders SET totalAmount = ? WHERE orderID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@t",  newTotal),
                new OleDbParameter("@id", orderID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public DataTable GetAllOrdersWithStatus()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT orderID, userID, orderDate, totalAmount, [status] FROM Orders ORDER BY orderDate DESC");
        }
    }

    // ── Payment Repository ─────────────────────────────────
    public class PaymentRepository
    {
        public bool RecordPayment(Payment payment)
        {
            string query = "INSERT INTO Payments (orderID, amount, [method]) VALUES (?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@o", payment.OrderID),
                new OleDbParameter("@a", payment.Amount),
                new OleDbParameter("@m", payment.Method)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public DataTable GetPaymentByOrder(int orderID)
        {
            string query = "SELECT * FROM Payments WHERE orderID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", orderID) };
            return DatabaseHelper.ExecuteQuery(query, p);
        }
    }
}