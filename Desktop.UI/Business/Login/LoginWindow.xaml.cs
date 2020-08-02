using PersonalManagerDesktop;
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
using System.Windows.Shapes;

namespace Desktop.UI.Business.Login {
    /// <summary>
    /// Interaction logic for LoginMainFrame.xaml
    /// </summary>
    public partial class LoginWindow : Window {

        private LoginPage _loginPage;
        private ChangePasswordPage _changePasswordPage;
        private RequestResetPasswordPage _requestResetPasswordPage;

        public LoginWindow() {
            InitializeComponent();

            _loginPage = new LoginPage();
            _loginPage.LoginEvent += NavigateChangePasswordEvent;
            _loginPage.ResetPasswordEvent += NavigateRequestResetPasswordEvent;

            _changePasswordPage = new ChangePasswordPage();
            _changePasswordPage.ChangePasswordEvent += StartMainWindow;



            _requestResetPasswordPage = new RequestResetPasswordPage();
            //_requestResetPasswordPage.ResetPasswordEvent += NavigateLoginEvent;


            NavigateLoginEvent(this, EventArgs.Empty);
        }



        void NavigateChangePasswordEvent(object sender, EventArgs e) {
            LoginFrame.Content = _changePasswordPage;
        }

        void NavigateRequestResetPasswordEvent(object sender, EventArgs e) {
            LoginFrame.Content = _requestResetPasswordPage;
        }

        void NavigateLoginEvent(object sender, EventArgs e) {
            LoginFrame.Content = _loginPage;
        }

        void StartMainWindow(object sender, EventArgs e) {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
