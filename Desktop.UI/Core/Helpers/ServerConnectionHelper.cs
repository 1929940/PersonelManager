using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;

namespace Desktop.UI.Core.Helpers {
    class ServerConnectionHelper {
        public static void SetLoginData(AuthenticationReponse response) {
            ServerConnectionData.Token = response.Token;
            ServerConnectionData.Role = response.Role;
        }
    }
}
