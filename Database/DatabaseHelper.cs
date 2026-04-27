using System;
using System.Data;
using System.Data.OleDb;

namespace OOP_FINAL_PROJECT.Database
{
    public class DatabaseHelper
    {
        // ── Auto-detect Access provider (works on Access 2010, 2013, 2016, 2019) ──
        private static readonly string ConnectionString = BuildConnectionString();

        private static string BuildConnectionString()
        {
            // Try newer provider first (Access 2016/2019), fall back to older (Access 2010/2013)
            string[] providers = {
                "Microsoft.ACE.OLEDB.16.0",
                "Microsoft.ACE.OLEDB.12.0"
            };

            foreach (string provider in providers)
            {
                try
                {
                    string testConn = $@"Provider={provider};Data Source=|DataDirectory|\KioskDB.accdb;Persist Security Info=False;";
                    using (var conn = new OleDbConnection(testConn))
                    {
                        conn.Open();
                        conn.Close();
                    }
                    return testConn; // this provider works — use it
                }
                catch { /* try next provider */ }
            }

            // Last resort — use 12.0 (most widely installed)
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\KioskDB.accdb;Persist Security Info=False;";
        }

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        public static DataTable ExecuteQuery(string query, OleDbParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}