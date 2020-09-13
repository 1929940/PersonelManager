using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop.UI.Business.Login {
    public partial class LoginPage : Page {

        public EventHandler<LoginEventArgs> ResetPasswordEvent;
        public EventHandler<LoginEventArgs> LoginEvent;

        public string Login { get; set; }

        public LoginPage() {
            //Login = login;
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
    }
}
