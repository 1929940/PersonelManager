using CommunicationLibrary.Core;
using static Desktop.UI.Core.Helpers.Enums;

namespace Desktop.UI.Core.Helpers {
    public static class AuthorizationHelper {
        public static bool Authorize(Roles role) {
            if (role.ToString() == ServerConnectionData.Role || ServerConnectionData.Role == Roles.Administrator.ToString())
                return true;
            return false;
        }
    }
}
