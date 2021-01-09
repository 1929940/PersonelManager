using System;
using System.Net.Http;

namespace CommunicationAndCommonsLibrary.Core.Logic {
    public class ExceptionHelper {
        public static string GetMessage(Exception ex) {
            if (ex?.InnerException is HttpRequestException)
                return "Nie można nawiązać połączenia z serwerem. Spróbuj ponownie później. Jesli problem będzie się powtarzał skontaktuj się z administratorem.";
            return ex.InnerException?.Message ?? ex.Message;
        }
    }
}
