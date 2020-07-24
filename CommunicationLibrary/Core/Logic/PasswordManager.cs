using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CommunicationLibrary.Core.Logic {
    public static class PasswordManager {
        public static string EncryptPassword(string password) {
            if (password.Length == 4)
                return password;
            return Encrypt(password);
        }

        //TODO: This could be texted if it always returns the same result
        private static string Encrypt(string input) {
            using (var sha256 = new SHA256Managed()) {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", string.Empty);
            }
        }
    }
}
