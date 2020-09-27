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

        private LoginPage _loginPage;
        private ChangePasswordPage _changePasswordPage;
        private RequestResetPasswordPage _requestResetPasswordPage;
        //private readonly RequestResetPasswordPage _requestResetPasswordPage;

        private readonly UserRequestHandler _handler;

        public LoginWindow() {
            InitializeComponent();

            //This needs local memory, perhaps to a file? or xml file? 
            Settings.Url = @"https://localhost:44345";


            //need to check if url is empty, if empty pop a window user enters url

            _handler = new UserRequestHandler();

            _changePasswordPage = new ChangePasswordPage();
            _changePasswordPage.ChangePasswordEvent += StartMainWindow;

            NavigateLoginEvent(this, LoginEventArgs.Empty);
        }

        void NavigateChangePasswordEvent(object sender, LoginEventArgs args) {
            LoginFrame.Content = _changePasswordPage;
        }

        void NavigateRequestResetPasswordEvent(object sender, LoginEventArgs args) {
            _requestResetPasswordPage = new RequestResetPasswordPage();
            _requestResetPasswordPage.ResetPasswordEvent += RequestNewPasswordEvent;
            _requestResetPasswordPage.NavigateToLoginEvent += NavigateLoginEvent;

            _requestResetPasswordPage.LoginBox.Text = args.Login;

            LoginFrame.Content = _requestResetPasswordPage;
        }

        void NavigateLoginEvent(object sender, LoginEventArgs args) {
            _loginPage = new LoginPage();
            _loginPage.LoginEvent += LaunchLoginEvent;
            _loginPage.ResetPasswordEvent += NavigateRequestResetPasswordEvent;

            _loginPage.LoginBox.Text = args.Login;
            //_loginPage.Login = args.Login;

            LoginFrame.Content = _loginPage;
        }

        void RequestNewPasswordEvent(object sender, LoginEventArgs args) {
            string login = args.Login;
            //TODO: PASS LOGIN

            try {
                _handler.RequestPasswordReset(args.Login);
            } catch (Exception) {
                MessageBox.Show("Wystapił bład, skontaktuj się z administratorem", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void StartMainWindow(object sender, LoginEventArgs args) {
            string pw1 = args.Password;
            string pw2 = args.ConfirmPassword;

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        void LaunchLoginEvent(object sender, LoginEventArgs args) {
            //to nie powinno byc w evencie - metoda

            bool result = false;
            try {
                result = Login(args.Login, args.Password);
                if (result) {
                    StartMainWindow(this, LoginEventArgs.Empty);
                } else {
                    NavigateChangePasswordEvent(this, args);
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
