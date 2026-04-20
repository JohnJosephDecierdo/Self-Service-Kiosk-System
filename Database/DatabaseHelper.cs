using System;
using System.Data;
using System.Data.OleDb;

namespace OOP_FINAL_PROJECT.Database
{
    public class DatabaseHelper
    {
        private static readonly string ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\KioskDB.accdb;Persist Security Info=False;";

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