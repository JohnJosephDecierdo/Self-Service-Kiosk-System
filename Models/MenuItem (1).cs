using System;
using System.Data;
using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    // ── Model ──────────────────────────────────────────────
    public class MenuItem
    {
        public int    ItemID      { get; set; }
        public string Name        { get; set; }
        public double Price       { get; set; }
        public string Category    { get; set; }
        public bool   IsAvailable { get; set; } = true;  // NEW — Cook can mark unavailable

        public string GetDetails() => $"{Name} - ₱{Price:F2} [{Category}]";
    }

    // ── Repository ─────────────────────────────────────────
    public class MenuItemRepository
    {
        public DataTable GetAll()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM MenuItems ORDER BY category, name");
        }

        public DataTable GetByCategory(string category)
        {
            string query = "SELECT * FROM MenuItems WHERE category = ? ORDER BY name";
            OleDbParameter[] p = { new OleDbParameter("@c", category) };
            return DatabaseHelper.ExecuteQuery(query, p);
        }

        // Only returns items that are available — used by CustomerForm
        public DataTable GetAllAvailable()
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM MenuItems WHERE isAvailable = TRUE ORDER BY category, name");
        }

        public DataTable GetAvailableByCategory(string category)
        {
            string query = "SELECT * FROM MenuItems WHERE category = ? AND isAvailable = TRUE ORDER BY name";
            OleDbParameter[] p = { new OleDbParameter("@c", category) };
            return DatabaseHelper.ExecuteQuery(query, p);
        }

        // Cook calls this to toggle availability
        public bool SetAvailability(int itemID, bool isAvailable)
        {
            string query = "UPDATE MenuItems SET isAvailable = ? WHERE itemID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@a",  isAvailable),
                new OleDbParameter("@id", itemID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Add(MenuItem item)
        {
            string query = "INSERT INTO MenuItems (name, price, category, isAvailable) VALUES (?, ?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@n", item.Name),
                new OleDbParameter("@p", item.Price),
                new OleDbParameter("@c", item.Category),
                new OleDbParameter("@a", true)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Update(MenuItem item)
        {
            string query = "UPDATE MenuItems SET name = ?, price = ?, category = ? WHERE itemID = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@n",  item.Name),
                new OleDbParameter("@p",  item.Price),
                new OleDbParameter("@c",  item.Category),
                new OleDbParameter("@id", item.ItemID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool Delete(int itemID)
        {
            string query = "DELETE FROM MenuItems WHERE itemID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", itemID) };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }
    }
}