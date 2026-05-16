using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.Win32;

namespace OOP_FINAL_PROJECT.Database
{
    public static class DatabaseHelper
    {
        // ---------------------------------------------------------------
        //  Locate the .accdb / .mdb file automatically
        //  (keeps working whether you run from VS or the published folder)
        // ---------------------------------------------------------------
        private static readonly string DbFileName = "KioskDB.accdb"; // ← change if needed

        private static string DbPath
        {
            get
            {
                // 1. Folder next to the running .exe
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string candidate = Path.Combine(exeDir, DbFileName);
                if (File.Exists(candidate)) return candidate;

                // 2. Project root (three levels up from bin\Debug\net8.0-windows\ on .NET 8)
                string projectRoot = Path.GetFullPath(Path.Combine(exeDir, @"..\..\..\"));
                candidate = Path.Combine(projectRoot, DbFileName);
                if (File.Exists(candidate)) return candidate;

                // 3. Current working directory
                candidate = Path.Combine(Directory.GetCurrentDirectory(), DbFileName);
                if (File.Exists(candidate)) return candidate;

                throw new FileNotFoundException(
                    $"Cannot find '{DbFileName}'. Place it next to the .exe or in the project root.",
                    DbFileName);
            }
        }

        // ---------------------------------------------------------------
        //  Auto-detect the best available OLEDB provider
        //  Priority: ACE 16 → ACE 15 → ACE 14 → ACE 12 → JET 4 (mdb only)
        // ---------------------------------------------------------------
        private static string _cachedProvider = null;

        private static string DetectProvider()
        {
            if (_cachedProvider != null) return _cachedProvider;

            // Providers in preference order
            string[] aceProviders =
            {
                "Microsoft.ACE.OLEDB.16.0",   // Access 2016 / Office 365 (64-bit)
                "Microsoft.ACE.OLEDB.15.0",   // Access 2013
                "Microsoft.ACE.OLEDB.14.0",   // Access 2010
                "Microsoft.ACE.OLEDB.12.0",   // Access 2007
            };

            // Check registry: HKCR\CLSID search is slow; check OLE DB providers key instead
            const string oledbKey = @"SOFTWARE\Classes\CLSID";
            // Simpler: just try opening a dummy connection and catch the error
            foreach (string provider in aceProviders)
            {
                if (IsProviderRegistered(provider))
                {
                    _cachedProvider = provider;
                    return _cachedProvider;
                }
            }

            // Last resort: JET 4.0 — works only with .mdb (Access 97-2003)
            if (DbFileName.EndsWith(".mdb", StringComparison.OrdinalIgnoreCase) &&
                IsProviderRegistered("Microsoft.Jet.OLEDB.4.0"))
            {
                _cachedProvider = "Microsoft.Jet.OLEDB.4.0";
                return _cachedProvider;
            }

            throw new InvalidOperationException(
                "No compatible Microsoft Access Database Engine (ACE OLEDB) provider was found.\n\n" +
                "Please download and install one of the following (choose the bitness that matches your app):\n" +
                "  • Access Database Engine 2016:  https://www.microsoft.com/en-us/download/details.aspx?id=54920\n" +
                "  • Access Database Engine 2010:  https://www.microsoft.com/en-us/download/details.aspx?id=13255\n\n" +
                "If Office (32-bit) is already installed, build your project as x86 (Project → Properties → Build → Platform target = x86).");
        }

        /// <summary>
        /// Checks the registry (both 32-bit and 64-bit hives) for a given OLEDB provider.
        /// </summary>
        private static bool IsProviderRegistered(string providerName)
        {
            // OLEDB providers register under HKEY_CLASSES_ROOT or HKLM SOFTWARE\Classes
            string[] regPaths =
            {
                $@"SOFTWARE\Classes\{providerName}",
                $@"SOFTWARE\WOW6432Node\Classes\{providerName}",
                $@"CLSID",   // fallback — we'll enumerate below
            };

            // Quickest check: look for the ProgID key under HKCR
            using (RegistryKey hkcr = Registry.ClassesRoot.OpenSubKey(providerName))
            {
                if (hkcr != null) return true;
            }

            // Also try HKLM (some redistributables only write here)
            using (RegistryKey hklm = Registry.LocalMachine.OpenSubKey(
                       $@"SOFTWARE\Classes\{providerName}"))
            {
                if (hklm != null) return true;
            }

            using (RegistryKey hklmWow = Registry.LocalMachine.OpenSubKey(
                       $@"SOFTWARE\WOW6432Node\Classes\{providerName}"))
            {
                if (hklmWow != null) return true;
            }

            return false;
        }

        // ---------------------------------------------------------------
        //  Build the connection string dynamically
        // ---------------------------------------------------------------
        public static string GetConnectionString()
        {
            string provider = DetectProvider();
            string dbPath = DbPath;

            // ACE 12+ uses "Data Source"; JET uses "Data Source" too — same syntax
            return $"Provider={provider};Data Source={dbPath};Persist Security Info=False;";
        }

        // ---------------------------------------------------------------
        //  Create and open a connection (caller must dispose it)
        // ---------------------------------------------------------------
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(GetConnectionString());
        }

        // ---------------------------------------------------------------
        //  Execute a query and return a DataTable
        // ---------------------------------------------------------------
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
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // ---------------------------------------------------------------
        //  Execute a non-query (INSERT / UPDATE / DELETE) and return rows affected
        // ---------------------------------------------------------------
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

        // ---------------------------------------------------------------
        //  Execute a scalar query (COUNT, MAX, etc.)
        // ---------------------------------------------------------------
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