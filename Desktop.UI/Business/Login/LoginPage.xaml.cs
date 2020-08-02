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
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page {
        public string Login { get; set; }
        public string Password { get; set; }

        public EventHandler ResetPasswordEvent;
        public EventHandler LoginEvent;

        public LoginPage() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            //Login = LoginTxtBox.Text;
            //Password = PasswordBox.Password;

            //ChangePasswordPage page = new ChangePasswordPage();


            //this.MyEvent(this, EventArgs.Empty);
            this.LoginEvent(this, EventArgs.Empty);

        }

        private void ForgotPasswordLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.ResetPasswordEvent(this, EventArgs.Empty);
        }
    }
}
