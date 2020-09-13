using System;

namespace Desktop.UI.Business.Login {
    public class LoginEventArgs : EventArgs {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public static new LoginEventArgs Empty => new LoginEventArgs();
    }
}
