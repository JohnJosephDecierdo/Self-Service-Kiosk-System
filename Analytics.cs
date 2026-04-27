using System;
using System.Data;
using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    public class AnalyticsRepository
    {
        // ── Access date literal helper  e.g.  #04/08/2026# (always MM/DD/YYYY) ─
        private static string D(DateTime dt) => $"#{dt:MM/dd/yyyy}#";

        // ── Sales Totals ──────────────────────────────────────
        public double GetTotalSalesToday()
        {
            string query = $@"SELECT SUM(totalAmount) FROM Orders 
                              WHERE [status] = 'Completed' 
                              AND orderDate >= {D(DateTime.Today)} 
                              AND orderDate < {D(DateTime.Today.AddDays(1))}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        public double GetTotalSalesThisWeek()
        {
            DateTime weekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            string query = $@"SELECT SUM(totalAmount) FROM Orders 
                              WHERE [status] = 'Completed' 
                              AND orderDate >= {D(weekStart)} 
                              AND orderDate < {D(weekStart.AddDays(7))}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        public double GetTotalSalesThisMonth()
        {
            DateTime monthStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            string query = $@"SELECT SUM(totalAmount) FROM Orders 
                              WHERE [status] = 'Completed' 
                              AND orderDate >= {D(monthStart)} 
                              AND orderDate < {D(monthStart.AddMonths(1))}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        // ── Range Overloads (used by filter) ──────────────────
        public double GetTotalSalesInRange(DateTime from, DateTime to)
        {
            string query = $@"SELECT SUM(totalAmount) FROM Orders 
                              WHERE [status] = 'Completed' 
                              AND orderDate >= {D(from)} AND orderDate < {D(to)}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        public int GetTotalOrdersInRange(DateTime from, DateTime to)
        {
            string query = $@"SELECT COUNT(*) FROM Orders 
                              WHERE orderDate >= {D(from)} AND orderDate < {D(to)}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }

        public double GetAverageOrderValueInRange(DateTime from, DateTime to)
        {
            string query = $@"SELECT AVG(totalAmount) FROM Orders 
                              WHERE [status] = 'Completed'
                              AND orderDate >= {D(from)} AND orderDate < {D(to)}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        public int GetTotalCustomersInRange(DateTime from, DateTime to)
        {
            // Access doesn't support COUNT(DISTINCT); use subquery without alias
            string query = $@"SELECT COUNT(*) FROM 
                              (SELECT DISTINCT userID FROM Orders
                               WHERE orderDate >= {D(from)} AND orderDate < {D(to)})";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }

        public DataTable GetTopSellingItemsInRange(DateTime from, DateTime to, int top = 5)
        {
            string query = $@"SELECT TOP {top} MenuItems.name, MenuItems.category,
                      SUM(OrderDetails.orderQty) AS totalQty,
                      SUM(OrderDetails.orderQty * MenuItems.price) AS totalRevenue
                      FROM (OrderDetails
                      INNER JOIN MenuItems ON OrderDetails.itemID = MenuItems.itemID)
                      INNER JOIN Orders ON OrderDetails.orderID = Orders.orderID
                      WHERE Orders.[status] = 'Completed'
                      AND Orders.orderDate >= {D(from)} AND Orders.orderDate < {D(to)}
                      GROUP BY MenuItems.name, MenuItems.category
                      ORDER BY SUM(OrderDetails.orderQty) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetSalesByCategoryInRange(DateTime from, DateTime to)
        {
            string query = $@"SELECT MenuItems.category,
                     SUM(OrderDetails.orderQty) AS totalQty,
                     SUM(OrderDetails.orderQty * MenuItems.price) AS totalRevenue
                     FROM (OrderDetails
                     INNER JOIN MenuItems ON OrderDetails.itemID = MenuItems.itemID)
                     INNER JOIN Orders ON OrderDetails.orderID = Orders.orderID
                     WHERE Orders.[status] = 'Completed'
                     AND Orders.orderDate >= {D(from)} AND Orders.orderDate < {D(to)}
                     GROUP BY MenuItems.category
                     ORDER BY SUM(OrderDetails.orderQty * MenuItems.price) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetOrderCountByStatusInRange(DateTime from, DateTime to)
        {
            string query = $@"SELECT [status], COUNT(*) AS orderCount 
                              FROM Orders
                              WHERE orderDate >= {D(from)} AND orderDate < {D(to)}
                              GROUP BY [status] 
                              ORDER BY COUNT(*) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetRecentOrdersInRange(DateTime from, DateTime to, int count = 10)
        {
            string query = $@"SELECT TOP {count} orderID, orderDate, totalAmount, [status]
                              FROM Orders
                              WHERE orderDate >= {D(from)} AND orderDate < {D(to)}
                              ORDER BY orderDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // ── Order Counts ──────────────────────────────────────
        public int GetTotalOrdersToday()
        {
            string query = $@"SELECT COUNT(*) FROM Orders 
                              WHERE orderDate >= {D(DateTime.Today)} 
                              AND orderDate < {D(DateTime.Today.AddDays(1))}";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }

        public DataTable GetOrderCountByStatus()
        {
            string query = @"SELECT [status], COUNT(*) AS orderCount 
                             FROM Orders 
                             GROUP BY [status] 
                             ORDER BY COUNT(*) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // ── Top Selling Items ─────────────────────────────────
        public DataTable GetTopSellingItems(int top = 5)
        {
            string query = $@"SELECT TOP {top} MenuItems.name, MenuItems.category,
                      SUM(OrderDetails.orderQty) AS totalQty,
                      SUM(OrderDetails.orderQty * MenuItems.price) AS totalRevenue
                      FROM (OrderDetails
                      INNER JOIN MenuItems ON OrderDetails.itemID = MenuItems.itemID)
                      INNER JOIN Orders ON OrderDetails.orderID = Orders.orderID
                      WHERE Orders.[status] = 'Completed'
                      GROUP BY MenuItems.name, MenuItems.category
                      ORDER BY SUM(OrderDetails.orderQty) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // ── Sales by Category ─────────────────────────────────
        public DataTable GetSalesByCategory()
        {
            string query = @"SELECT MenuItems.category,
                     SUM(OrderDetails.orderQty) AS totalQty,
                     SUM(OrderDetails.orderQty * MenuItems.price) AS totalRevenue
                     FROM (OrderDetails
                     INNER JOIN MenuItems ON OrderDetails.itemID = MenuItems.itemID)
                     INNER JOIN Orders ON OrderDetails.orderID = Orders.orderID
                     WHERE Orders.[status] = 'Completed'
                     GROUP BY MenuItems.category
                     ORDER BY SUM(OrderDetails.orderQty * MenuItems.price) DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // ── Recent Orders ─────────────────────────────────────
        public DataTable GetRecentOrders(int count = 10)
        {
            string query = $@"SELECT TOP {count} orderID, orderDate, totalAmount, [status]
                              FROM Orders 
                              ORDER BY orderDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // ── Average Order Value ───────────────────────────────
        public double GetAverageOrderValue()
        {
            string query = "SELECT AVG(totalAmount) FROM Orders WHERE [status] = 'Completed'";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToDouble(result);
        }

        // ── Total Customers ───────────────────────────────────
        public int GetTotalCustomers()
        {
            // Access doesn't support COUNT(DISTINCT); use subquery without alias
            string query = "SELECT COUNT(*) FROM (SELECT DISTINCT userID FROM Orders)";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }

        // ── Daily sales for last 7 days ───────────────────────
        public DataTable GetDailySalesLast7Days()
        {
            string query = $@"SELECT Format(orderDate,'yyyy-mm-dd') AS saleDate, 
                             SUM(totalAmount) AS dailyTotal
                             FROM Orders
                             WHERE [status] = 'Completed'
                             AND orderDate >= {D(DateTime.Today.AddDays(-6))}
                             GROUP BY Format(orderDate,'yyyy-mm-dd')
                             ORDER BY Format(orderDate,'yyyy-mm-dd')";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
