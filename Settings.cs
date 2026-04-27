using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    public class SettingsRepository
    {
        public string GetSetting(string key)
        {
            string query = "SELECT settingValue FROM Settings WHERE settingKey = ?";
            OleDbParameter[] p = { new OleDbParameter("@k", key) };
            object result = DatabaseHelper.ExecuteScalar(query, p);
            return result?.ToString();
        }

        public bool UpdateSetting(string key, string value)
        {
            string query = "UPDATE Settings SET settingValue = ? WHERE settingKey = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@v", value),
                new OleDbParameter("@k", key)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool ValidatePIN(string pin)
        {
            string stored = GetSetting("ManagerPIN");
            return stored != null && stored == pin;
        }
    }
}
