using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Business.Login {
    public partial class RequestResetPasswordPage : Page {

        public EventHandler<LoginEventArgs> ResetPasswordEvent;
        public EventHandler<LoginEventArgs> NavigateToLoginEvent;

        public string Login { get; set; }

        public RequestResetPasswordPage() {
            this.DataContext = this;
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e) {
            LoginBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (Validation.GetHasError(LoginBox))
                return;

            ResetPasswordEvent(this, new LoginEventArgs() { Login = LoginBox.Text });
            NavigateToLoginEvent(this, new LoginEventArgs() { Login = LoginBox.Text });
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {

            NavigateToLoginEvent(this, new LoginEventArgs() { Login = LoginBox.Text });
        }
    }
}
