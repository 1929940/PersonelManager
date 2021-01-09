using System;
using System.Security.Cryptography;
using System.Text;

namespace CommunicationAndCommonsLibrary.Core.Logic {
    public static class PasswordManager {
        public static string Encrypt(string input) {
            using (var sha256 = new SHA256Managed()) {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", string.Empty);
            }
        }
    }
}
