using CommunicationLibrary.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.UI.Core.Helpers {
    class SettingsHelper {
        public static void SetToken(string token) => Settings.Token = token;
    }
}
