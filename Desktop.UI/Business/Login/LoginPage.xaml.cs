using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop.UI.Business.Login {
    public partial class LoginPage : Page {

        public EventHandler<LoginEventArgs> ResetPasswordEvent;
        public EventHandler<LoginEventArgs> LoginEvent;

        public string Login { get; set; }

        public LoginPage() {
            this.DataContext = this;
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            LoginBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (Validation.GetHasError(LoginBox))
                return;

            LoginEventArgs args = new LoginEventArgs() {
                Login = Login,
                Password = PasswordBox.Password
            };

            this.LoginEvent(this, args);
        }

        private void ForgotPasswordLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            LoginEventArgs args = new LoginEventArgs() {
                Login = LoginBox.Text,
            };

            this.ResetPasswordEvent(this, args);
        }

        private void FormFilled_TextChanged(object sender, RoutedEventArgs e) {

            if (!string.IsNullOrEmpty(PasswordBox?.Password) && !string.IsNullOrEmpty(LoginBox?.Text))
                LoginButton.IsEnabled = true;
            else
                LoginButton.IsEnabled = false;
        }
    }
}
