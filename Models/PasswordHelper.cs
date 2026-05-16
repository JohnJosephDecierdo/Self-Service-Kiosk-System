using System;
using System.Security.Cryptography;
using System.Text;

namespace OOP_FINAL_PROJECT.Models
{
    // ══════════════════════════════════════════════════════════
    //  OOP: ABSTRACTION
    //  PasswordHelper hides the complexity of SHA256 hashing.
    //  Other classes just call Hash() and Verify() without
    //  knowing how the hashing algorithm works internally.
    // ══════════════════════════════════════════════════════════
    public static class PasswordHelper
    {
        /// <summary>
        /// Converts a plain text password into a SHA256 hash string.
        /// Example: "admin123" → "240be518..."
        /// </summary>
        public static string Hash(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2")); // convert to hex string

                return sb.ToString();
            }
        }

        /// <summary>
        /// Checks if a plain text password matches a stored hash.
        /// </summary>
        public static bool Verify(string plainText, string storedHash)
        {
            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(storedHash))
                return false;

            string hashOfInput = Hash(plainText);
            return string.Equals(hashOfInput, storedHash, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Checks if a string is already a SHA256 hash (64 hex characters).
        /// Used to avoid double-hashing existing passwords.
        /// </summary>
        public static bool IsHashed(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            return value.Length == 64 &&
                   System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-fA-F0-9]{64}$");
        }
    }
}
