using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
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
    //TODO: I WANT LOGIC HERE FOR LOGIN
    public partial class LoginWindow : Window {

        private readonly LoginPage _loginPage;
        private readonly ChangePasswordPage _changePasswordPage;
        private readonly RequestResetPasswordPage _requestResetPasswordPage;

        public LoginWindow() {
            InitializeComponent();

            //This needs local memory, perhaps to a file? or xml file? 
            Settings.Url = @"https://localhost:44345";

            //need to check if url is empty, if empty pop a window user enters url

            _loginPage = new LoginPage();
            //_loginPage.LoginEvent += NavigateChangePasswordEvent;
            _loginPage.LoginEvent += LaunchLoginEvent;
            _loginPage.ResetPasswordEvent += NavigateRequestResetPasswordEvent;

            _changePasswordPage = new ChangePasswordPage();
            _changePasswordPage.ChangePasswordEvent += StartMainWindow;

            _requestResetPasswordPage = new RequestResetPasswordPage();
            _requestResetPasswordPage.ResetPasswordEvent += NavigateLoginEvent;

            NavigateLoginEvent(this, LoginEventArgs.Empty);
        }

        //Rename 'e' to args
        void NavigateChangePasswordEvent(object sender, LoginEventArgs e) {
            LoginFrame.Content = _changePasswordPage;
        }

        void NavigateRequestResetPasswordEvent(object sender, LoginEventArgs e) {
            _requestResetPasswordPage.LoginBox.Text = e.Login;

            LoginFrame.Content = _requestResetPasswordPage;
        }

        void NavigateLoginEvent(object sender, LoginEventArgs e) {
            LoginFrame.Content = _loginPage;
        }

        void StartMainWindow(object sender, LoginEventArgs e) {
            string pw1 = e.Password;
            string pw2 = e.PasswordRepeat;

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        void LaunchLoginEvent(object sender, LoginEventArgs e) {
            //to nie powinno byc w evencie - metoda

            bool result = false;
            try {
                result = Login(e.Login, e.Password);
                if (result) {
                    StartMainWindow(this, LoginEventArgs.Empty);
                } else {
                    NavigateChangePasswordEvent(this, e);
                }

            } catch (Exception ex) {
                //message is not cool
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public bool Login(string login, string password) {
            UserRequestHandler handler = new UserRequestHandler();
            var response = handler.Login(login, password);
            Settings.Token = response.Token;
            return !string.IsNullOrEmpty(response.Token);
        }
    }
}
