using System;
using System.Data;
using System.Data.OleDb;
using OOP_FINAL_PROJECT.Database;

namespace OOP_FINAL_PROJECT.Models
{
    // ══════════════════════════════════════════════════════
    //  OOP: ABSTRACTION
    //  Person is an abstract base class — it defines WHAT
    //  a person should have (Name, GetInfo) without being
    //  instantiated directly. You can't do: new Person()
    // ══════════════════════════════════════════════════════
    public abstract class Person
    {
        // OOP: ENCAPSULATION
        // Name is protected — only this class and subclasses
        // can access it directly. Outside code uses GetInfo().
        protected string Name { get; set; }

        // OOP: ABSTRACTION
        // Forces every subclass to implement GetInfo()
        // their own way — each person type describes itself
        public abstract string GetInfo();

        // Shared method available to all subclasses
        public string GetName() => Name;
    }

    // ══════════════════════════════════════════════════════
    //  OOP: INHERITANCE
    //  User extends Person — it inherits Name and GetName()
    //  from Person, and adds its own UserID, Role, etc.
    //  User IS-A Person (inheritance relationship)
    // ══════════════════════════════════════════════════════
    public class User : Person
    {
        // OOP: ENCAPSULATION
        // Properties use { get; set; } — data is accessed
        // through controlled getters/setters, not directly
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }  // store hashed in production
        public string Role { get; set; }  // Customer, Cashier, Cook, Manager, Owner

        // OOP: INHERITANCE + ABSTRACTION (override)
        // User provides its OWN implementation of GetInfo()
        // which was defined as abstract in Person
        public override string GetInfo()
        {
            return $"User: {Username} | Role: {Role}";
        }

        // Sets the inherited protected Name property
        public void SetName(string name) => Name = name;
    }

    // ══════════════════════════════════════════════════════
    //  OOP: ABSTRACTION
    //  Repository hides all SQL/database complexity.
    //  Forms don't know HOW data is fetched — they just call
    //  Login(), GetAllUsers(), etc. and get results back.
    // ══════════════════════════════════════════════════════
    public class UserRepository
    {
        public User Login(string username, string password)
        {
            // Fetch user by username only — verify password in code using hash
            string query = "SELECT * FROM Users WHERE username = ?";
            OleDbParameter[] p =
            {
                new OleDbParameter("@u", username)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
            if (dt.Rows.Count == 0) return null;

            DataRow r = dt.Rows[0];
            string storedPassword = r["password"].ToString();

            // Support both plain text (old) and hashed (new) passwords
            bool passwordMatch = PasswordHelper.IsHashed(storedPassword)
                ? PasswordHelper.Verify(password, storedPassword)  // hashed
                : storedPassword == password;                        // plain text fallback

            if (!passwordMatch) return null;

            return new User
            {
                UserID = Convert.ToInt32(r["userID"]),
                Username = r["username"].ToString(),
                Role = r["role"].ToString()
            };
        }

        public bool AddUser(User user)
        {
            // Always hash the password before storing
            string hashedPassword = PasswordHelper.Hash(user.Password);

            string query = "INSERT INTO Users (username, [password], [role]) VALUES (?, ?, ?)";
            OleDbParameter[] p =
            {
                new OleDbParameter("@u", user.Username),
                new OleDbParameter("@p", hashedPassword),
                new OleDbParameter("@r", user.Role)
            };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public DataTable GetAllUsers()
        {
            return DatabaseHelper.ExecuteQuery("SELECT userID, username, [role] FROM Users");
        }

        public bool DeleteUser(int userID)
        {
            string query = "DELETE FROM Users WHERE userID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", userID) };
            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE username = ?";
            OleDbParameter[] p = { new OleDbParameter("@u", username) };
            object result = DatabaseHelper.ExecuteScalar(query, p);
            return Convert.ToInt32(result) > 0;
        }

        public bool UpdateUser(int userID, string username, string newPassword, string role)
        {
            string query;
            OleDbParameter[] p;

            if (newPassword != null)
            {
                // Hash the new password before storing
                string hashedPassword = PasswordHelper.Hash(newPassword);

                query = "UPDATE Users SET username = ?, [password] = ?, [role] = ? WHERE userID = ?";
                p = new OleDbParameter[]
                {
                    new OleDbParameter("@u",  username),
                    new OleDbParameter("@p",  hashedPassword),
                    new OleDbParameter("@r",  role),
                    new OleDbParameter("@id", userID)
                };
            }
            else
            {
                // Keep existing password — don't touch it
                query = "UPDATE Users SET username = ?, [role] = ? WHERE userID = ?";
                p = new OleDbParameter[]
                {
                    new OleDbParameter("@u",  username),
                    new OleDbParameter("@r",  role),
                    new OleDbParameter("@id", userID)
                };
            }

            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
        }

        public User GetUserByID(int userID)
        {
            string query = "SELECT * FROM Users WHERE userID = ?";
            OleDbParameter[] p = { new OleDbParameter("@id", userID) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
            if (dt.Rows.Count == 0) return null;
            DataRow r = dt.Rows[0];
            return new User
            {
                UserID = Convert.ToInt32(r["userID"]),
                Username = r["username"].ToString(),
                Role = r["role"].ToString()
            };
        }
    }
}