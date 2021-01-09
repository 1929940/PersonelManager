using System;
using CommunicationAndCommonsLibrary.Business.Models;

namespace CommunicationAndCommonsLibrary.Business.Logic {
    public static class ConnectionManager {
        public static string Url { get; set; }
        public static string Token { get; set; }
        public static Roles Role { get; set; }

        static ConnectionManager() {
            Url = @"https://localhost:44345";
        }

        public static void Login(AuthenticationReponse response) {
            Token = response.Token;
            Role = (Roles)Enum.Parse(typeof(Roles), response.Role, true);
        }

        public static bool IsUserAuthorized(Roles role) =>
            Role == role || Role == Roles.Administrator;
    }
}
