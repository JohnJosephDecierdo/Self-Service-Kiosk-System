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
                "SELECT * FROM Inventory WHERE [condition] IN ('Damaged','Lost','Damaged & Lost') ORDER BY itemID ASC");
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
            // Prevent going below zero
            string check = "SELECT quantity, [condition] FROM Inventory WHERE itemID = ?";
            OleDbParameter[] pc = { new OleDbParameter("@id", itemID) };
            DataTable dt = DatabaseHelper.ExecuteQuery(check, pc);
            if (dt.Rows.Count == 0) return false;
            int current = Convert.ToInt32(dt.Rows[0]["quantity"]);
            string cond = dt.Rows[0]["condition"]?.ToString() ?? "Good";
            if (current < qty) return false;

            // If already Lost, upgrade to "Damaged & Lost"
            string newCond = (cond == "Lost") ? "Damaged & Lost" : "Damaged";

            string upd = @"UPDATE Inventory SET
                quantity = quantity - ?, [condition] = ?, lastUpdated = ?
                WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@c",  newCond),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Damaged", qty, remarks, loggedBy);
            return ok;
        }

        public bool ReportLoss(int itemID, int qty, string remarks, string loggedBy)
        {
            // Prevent going below zero
            string check = "SELECT quantity, [condition] FROM Inventory WHERE itemID = ?";
            OleDbParameter[] pc = { new OleDbParameter("@id", itemID) };
            DataTable dt = DatabaseHelper.ExecuteQuery(check, pc);
            if (dt.Rows.Count == 0) return false;
            int current = Convert.ToInt32(dt.Rows[0]["quantity"]);
            string cond = dt.Rows[0]["condition"]?.ToString() ?? "Good";
            if (current < qty) return false;

            // If already Damaged, upgrade to "Damaged & Lost"
            string newCond = (cond == "Damaged") ? "Damaged & Lost" : "Lost";

            string upd = @"UPDATE Inventory SET
                quantity = quantity - ?, [condition] = ?, lastUpdated = ?
                WHERE itemID = ?";
            OleDbParameter[] p1 =
            {
                new OleDbParameter("@q",  qty),
                new OleDbParameter("@c",  newCond),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, p1) > 0;
            if (ok) AddLog(itemID, "Lost", qty, remarks, loggedBy);
            return ok;
        }

        public int GetCurrentQuantity(int itemID)
        {
            string q = "SELECT quantity FROM Inventory WHERE itemID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
            object result = DatabaseHelper.ExecuteScalar(q, p);
            return result == null ? 0 : Convert.ToInt32(result);
        }

        /// <summary>
        /// Returns net damaged and lost quantities still outstanding, by replaying
        /// only the real action logs (Damaged, Lost, Restored). Informational
        /// "Remaining Damaged" / "Remaining Lost" entries are excluded.
        /// </summary>
        private (int netDmg, int netLst) GetNetDamagedAndLost(int itemID)
        {
            // Pull every real damage/loss/restore log in chronological order
            string q = @"SELECT [action], [quantity] FROM InventoryLog
                         WHERE itemID = ?
                           AND [action] IN ('Damaged','Lost','Restored','Restore Damaged','Restore Lost')
                         ORDER BY logDate ASC, logID ASC";
            OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
            DataTable dt = DatabaseHelper.ExecuteQuery(q, p);

            int dmg = 0, lst = 0;
            foreach (DataRow row in dt.Rows)
            {
                string action = row["action"]?.ToString() ?? "";
                int    qty    = Convert.ToInt32(row["quantity"]);
                switch (action)
                {
                    case "Damaged":         dmg += qty; break;
                    case "Lost":            lst += qty; break;
                    case "Restore Damaged": dmg  = Math.Max(0, dmg - qty); break;
                    case "Restore Lost":    lst  = Math.Max(0, lst - qty); break;
                    case "Restored":
                        // Generic restore: deduct from damaged first, then lost
                        int fromDmg = Math.Min(dmg, qty);
                        dmg -= fromDmg;
                        lst  = Math.Max(0, lst - (qty - fromDmg));
                        break;
                }
            }
            return (dmg, lst);
        }

        /// <summary>
        /// Returns the total restorable quantity (damaged + lost net outstanding).
        /// Falls back to current quantity if logs are empty but item is flagged.
        /// </summary>
        public int GetRestorableQuantity(int itemID)
        {
            var (netDmg, netLst) = GetNetDamagedAndLost(itemID);
            int net = netDmg + netLst;

            if (net <= 0)
            {
                // Fallback: item is still flagged but old logs are balanced
                string qItem = "SELECT quantity, [condition] FROM Inventory WHERE itemID = ?";
                OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
                DataTable dt = DatabaseHelper.ExecuteQuery(qItem, p);
                if (dt.Rows.Count > 0)
                {
                    string cond = dt.Rows[0]["condition"]?.ToString() ?? "";
                    int    qty  = Convert.ToInt32(dt.Rows[0]["quantity"]);
                    if ((cond == "Damaged" || cond == "Lost" || cond == "Damaged & Lost") && qty > 0)
                        return qty;
                }
                return 0;
            }
            return net;
        }

        public bool RestoreCondition(int itemID, int qty, string remarks, string loggedBy = "manager", string restoreType = "Both")
        {
            var (netDmg, netLst) = GetNetDamagedAndLost(itemID);

            // ── Get current condition for fallback when logs are empty ─────────
            string qCond = "SELECT quantity, [condition] FROM Inventory WHERE itemID = ?";
            OleDbParameter[] pcf = { new OleDbParameter("@id", itemID) };
            DataTable dtCond = DatabaseHelper.ExecuteQuery(qCond, pcf);
            string currentCond = dtCond.Rows.Count > 0 ? dtCond.Rows[0]["condition"]?.ToString() ?? "Good" : "Good";
            int    currentQty  = dtCond.Rows.Count > 0 ? Convert.ToInt32(dtCond.Rows[0]["quantity"]) : 0;

            // If logs empty, use current qty as the pool
            if (netDmg == 0 && netLst == 0 && currentQty > 0)
            {
                if (currentCond.Contains("Damaged")) netDmg = currentQty;
                else if (currentCond.Contains("Lost")) netLst = currentQty;
            }

            // ── Cap qty to the chosen pool ────────────────────────────────────
            // For "Both", qty applies independently to EACH type, so cap against the larger pool.
            int maxRestorable;
            if      (restoreType == "Damaged") maxRestorable = netDmg;
            else if (restoreType == "Lost")    maxRestorable = netLst;
            else                               maxRestorable = Math.Max(netDmg, netLst);

            if (qty > maxRestorable) qty = maxRestorable;
            if (qty <= 0) return false;

            // ── Recalculate remaining per type & total qty to add back ────────
            int remDmg, remLst, totalRestored;
            if (restoreType == "Damaged")
            {
                int fromDmg = Math.Min(netDmg, qty);
                remDmg = Math.Max(0, netDmg - fromDmg);
                remLst = netLst;
                totalRestored = fromDmg;
            }
            else if (restoreType == "Lost")
            {
                int fromLst = Math.Min(netLst, qty);
                remDmg = netDmg;
                remLst = Math.Max(0, netLst - fromLst);
                totalRestored = fromLst;
            }
            else // Both: qty applies to EACH type independently (1 restores 1 damaged AND 1 lost)
            {
                int fromDmg = Math.Min(netDmg, qty);
                int fromLst = Math.Min(netLst, qty);
                remDmg = Math.Max(0, netDmg - fromDmg);
                remLst = Math.Max(0, netLst - fromLst);
                totalRestored = fromDmg + fromLst;
            }

            // ── Write quantity back to DB ─────────────────────────────────────
            string upd = "UPDATE Inventory SET quantity = quantity + ?, lastUpdated = ? WHERE itemID = ?";
            OleDbParameter[] pu =
            {
                new OleDbParameter("@q",  totalRestored),
                new OleDbParameter("@d",  DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                new OleDbParameter("@id", itemID)
            };
            bool ok = DatabaseHelper.ExecuteNonQuery(upd, pu) > 0;
            if (!ok) return false;

            // ── Log the restore (separate log per type so GetNetDamagedAndLost tracks correctly) ──
            string restoreRemarks = string.IsNullOrWhiteSpace(remarks) ? "Condition restored to Good" : remarks;
            if (restoreType == "Damaged")
            {
                AddLog(itemID, "Restore Damaged", totalRestored, restoreRemarks, loggedBy);
            }
            else if (restoreType == "Lost")
            {
                AddLog(itemID, "Restore Lost", totalRestored, restoreRemarks, loggedBy);
            }
            else // Both: log each type separately so net tracking stays accurate
            {
                int fromDmgLog = Math.Min(netDmg, qty);
                int fromLstLog = Math.Min(netLst, qty);
                if (fromDmgLog > 0) AddLog(itemID, "Restore Damaged", fromDmgLog, restoreRemarks, loggedBy);
                if (fromLstLog > 0) AddLog(itemID, "Restore Lost",    fromLstLog, restoreRemarks, loggedBy);
            }

            // ── Determine new condition ───────────────────────────────────────
            string newCond;
            if      (remDmg > 0 && remLst > 0) newCond = "Damaged & Lost";
            else if (remDmg > 0)               newCond = "Damaged";
            else if (remLst > 0)               newCond = "Lost";
            else                               newCond = "Good";

            string updCond = "UPDATE Inventory SET [condition] = ? WHERE itemID = ?";
            DatabaseHelper.ExecuteNonQuery(updCond, new OleDbParameter[] {
                new OleDbParameter("@c",  newCond),
                new OleDbParameter("@id", itemID)
            });

            // ── Informational remaining logs (use neutral action so math ignores them) ──
            if (remDmg > 0)
                AddLog(itemID, "Info", remDmg, $"Remaining damaged: {remDmg} item(s) still damaged", loggedBy);
            if (remLst > 0)
                AddLog(itemID, "Info", remLst, $"Remaining lost: {remLst} item(s) still lost", loggedBy);

            return true;
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
                "SELECT COUNT(*) FROM Inventory WHERE [condition] IN ('Damaged','Damaged & Lost')");
            return r == null ? 0 : Convert.ToInt32(r);
        }

        public int GetLostCount()
        {
            object r = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Inventory WHERE [condition] IN ('Lost','Damaged & Lost')");
            return r == null ? 0 : Convert.ToInt32(r);
        }
    }
}
