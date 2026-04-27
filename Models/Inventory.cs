using System;
using System.Data;
using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    // ══════════════════════════════════════════════════════════
    //  OOP: ABSTRACTION + ENCAPSULATION
    //  InventoryItem encapsulates all non-food item properties.
    //  InventoryRepository abstracts all DB operations for inventory.
    // ══════════════════════════════════════════════════════════

    public class InventoryItem
    {
        public int    ItemID      { get; set; }
        public string Name        { get; set; }
        public string Category    { get; set; }  // Utensils, Furniture, Equipment
        public int    Quantity    { get; set; }
        public int    MinStock    { get; set; }  // alert threshold
        public string Condition   { get; set; }  // Good, Damaged, Lost
        public string Location    { get; set; }  // Kitchen, Dining Area, Storage
        public string Notes       { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Computed — no DB column needed
        public bool IsLowStock => Quantity <= MinStock;
        public string StatusBadge => IsLowStock ? "⚠ Low Stock" : "✔ OK";
    }

    public class InventoryLog
    {
        public int      LogID     { get; set; }
        public int      ItemID    { get; set; }
        public string   ItemName  { get; set; }
        public string   Action    { get; set; }  // Check In, Check Out, Damaged, Lost, Adjusted
        public int      Quantity  { get; set; }
        public string   Remarks   { get; set; }
        public string   LoggedBy  { get; set; }
        public DateTime LogDate   { get; set; } = DateTime.Now;
    }

    public class InventoryRepository
    {
        // ── ITEMS CRUD ─────────────────────────────────────────
        public DataTable GetAll()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Inventory ORDER BY itemID ASC");
        }

        public DataTable GetByCategory(string category)
        {
            string query = "SELECT * FROM Inventory WHERE category = ? ORDER BY itemID ASC";
            OleDbParameter[] p = { new OleDbParameter("@c", category) };
            return DatabaseHelper.ExecuteQuery(query, p);
        }

        public DataTable GetLowStock()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Inventory WHERE quantity <= minStock ORDER BY itemID ASC");
        }

        public DataTable GetDamagedOrLost()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Inventory WHERE [condition] IN ('Damaged','Lost') ORDER BY itemID ASC");
        }

        public bool Add(InventoryItem item)
        {
            string query = @"INSERT INTO Inventory
                (name, category, quantity, minStock, [condition], location, notes, lastUpdated)
                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@n",  item.Name),
                new OleDbParameter("@c",  item.Category),
                new OleDbParameter("@q",  item.Quantity),
                new OleDbParameter("@m",  item.MinStock),
                new OleDbParameter("@cd", item.Condition),
                new OleDbParameter("@l",  item.Location),
                new OleDbParameter("@nt", item.Notes ?? ""),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Update(InventoryItem item)
        {
            string query = @"UPDATE Inventory SET
                name=?, category=?, quantity=?, minStock=?,
                [condition]=?, location=?, notes=?, lastUpdated=?
                WHERE itemID=?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@n",  item.Name),
                new OleDbParameter("@c",  item.Category),
                new OleDbParameter("@q",  item.Quantity),
                new OleDbParameter("@m",  item.MinStock),
                new OleDbParameter("@cd", item.Condition),
                new OleDbParameter("@l",  item.Location),
                new OleDbParameter("@nt", item.Notes ?? ""),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", item.ItemID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Delete(int itemID)
        {
            string query = "DELETE FROM Inventory WHERE itemID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        // ── CHECK IN / CHECK OUT ───────────────────────────────
        public bool CheckIn(int itemID, int qty, string remarks, string loggedBy)
        {
            string upd = "UPDATE Inventory SET quantity = quantity + ?, lastUpdated = ? WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Check In", qty, remarks, loggedBy);
            return ok;
        }

        public bool CheckOut(int itemID, int qty, string remarks, string loggedBy)
        {
            // Prevent going below zero
            string check = "SELECT quantity FROM Inventory WHERE itemID = ?";
            OleDbParameter[] pc = { new OleDbParameter("@id", itemID) };
            int current = Convert.ToInt32(DatabaseHelper.ExecuteScalar(check, pc));
            if (current < qty) return false;

            string upd = "UPDATE Inventory SET quantity = quantity - ?, lastUpdated = ? WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Check Out", qty, remarks, loggedBy);
            return ok;
        }

        // ── DAMAGE / LOSS TRACKING ────────────────────────────
        public bool ReportDamage(int itemID, int qty, string remarks, string loggedBy)
        {
            string upd = @"UPDATE Inventory SET
                quantity = quantity - ?, [condition] = 'Damaged', lastUpdated = ?
                WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Damaged", qty, remarks, loggedBy);
            return ok;
        }

        public bool ReportLoss(int itemID, int qty, string remarks, string loggedBy)
        {
            string upd = @"UPDATE Inventory SET
                quantity = quantity - ?, [condition] = 'Lost', lastUpdated = ?
                WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Lost", qty, remarks, loggedBy);
            return ok;
        }

        public bool RestoreCondition(int itemID, int qty, string remarks, string loggedBy = "manager")
        {
            string upd = "UPDATE Inventory SET quantity = quantity + ?, [condition] = 'Good', lastUpdated = ? WHERE itemID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p) > 0;
            if (ok) AddLog(itemID, "Restored", qty, string.IsNullOrWhiteSpace(remarks) ? "Condition restored to Good" : remarks, loggedBy);
            return ok;
        }

        // ── LOGS ──────────────────────────────────────────────
        private void AddLog(int itemID, string action, int qty, string remarks, string loggedBy)
        {
            string q = @"INSERT INTO InventoryLog
                (itemID, [action], [quantity], remarks, loggedBy, logDate)
                VALUES (?, ?, ?, ?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@i",  itemID),
                new OleDbParameter("@a",  action),
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@r",  remarks ?? ""),
                new OleDbParameter("@lb", loggedBy),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))
            };
            DatabaseHelper.ExecuteNonQuery(q, p);
        }

        public DataTable GetLogs(int itemID = 0)
        {
            if (itemID > 0)
            {
                string q = @"SELECT il.logID, il.action, il.quantity, il.remarks,
                             il.loggedBy, il.logDate, i.name AS itemName
                             FROM InventoryLog il
                             INNER JOIN Inventory i ON il.itemID = i.itemID
                             WHERE il.itemID = ?
                             ORDER BY il.logDate DESC";
                OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
                return DatabaseHelper.ExecuteQuery(q, p);
            }
            else
            {
                string q = @"SELECT il.logID, i.name AS itemName, il.action,
                             il.quantity, il.remarks, il.loggedBy, il.logDate
                             FROM InventoryLog il
                             INNER JOIN Inventory i ON il.itemID = i.itemID
                             ORDER BY il.logDate DESC";
                return DatabaseHelper.ExecuteQuery(q);
            }
        }

        // ── SUMMARY STATS ─────────────────────────────────────
        public int GetTotalItems()
        {
            object r = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Inventory");
            return r == null ? 0 : Convert.ToInt32(r);
        }

        public int GetLowStockCount()
        {
            object r = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Inventory WHERE quantity <= minStock");
            return r == null ? 0 : Convert.ToInt32(r);
        }

        public int GetDamagedCount()
        {
            object r = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Inventory WHERE [condition] = 'Damaged'");
            return r == null ? 0 : Convert.ToInt32(r);
        }

        public int GetLostCount()
        {
            object r = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Inventory WHERE [condition] = 'Lost'");
            return r == null ? 0 : Convert.ToInt32(r);
        }
    }
}
