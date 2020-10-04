using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;
using PersonalManagerDesktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        private UpdatePasswordPage _updatePasswordPage;
        private RequestResetPasswordPage _requestResetPasswordPage;

        private readonly UserRequestHandler _handler;

        public LoginWindow() {
            InitializeComponent();

            //This needs local memory, perhaps to a file? or xml file? 
            Settings.Url = @"https://localhost:44345";
            //need to check if url is empty, if empty pop a window user enters url

            _handler = new UserRequestHandler();
            NavigateLoginEvent(this, LoginEventArgs.Empty);
        }

        void NavigateLoginEvent(object sender, LoginEventArgs args) {
            _loginPage = new LoginPage();
            _loginPage.LoginEvent += LoginEvent;

            _loginPage.ResetPasswordEvent -= NavigateRequestResetPasswordEvent;
            _loginPage.ResetPasswordEvent += NavigateRequestResetPasswordEvent;

            _loginPage.LoginBox.Text = args.Login;

            LoginFrame.Content = _loginPage;
        }

        void NavigateRequestResetPasswordEvent(object sender, LoginEventArgs args) {
            _requestResetPasswordPage = new RequestResetPasswordPage();

            _requestResetPasswordPage.ResetPasswordEvent -= RequestResetPasswordEvent;
            _requestResetPasswordPage.ResetPasswordEvent += RequestResetPasswordEvent;

            _requestResetPasswordPage.NavigateToLoginEvent -= NavigateLoginEvent;
            _requestResetPasswordPage.NavigateToLoginEvent += NavigateLoginEvent;

            _requestResetPasswordPage.LoginBox.Text = args.Login;

            LoginFrame.Content = _requestResetPasswordPage;
        }

        void NavigateUpdatePasswordEvent(object sender, LoginEventArgs args) {
            _updatePasswordPage = new UpdatePasswordPage();
            _updatePasswordPage.Login = args.Login;

            _updatePasswordPage.ChangePasswordEvent -= UpdatePasswordEvent;
            _updatePasswordPage.ChangePasswordEvent += UpdatePasswordEvent;

            LoginFrame.Content = _updatePasswordPage;
        }

        void StartMainWindow(object sender, LoginEventArgs args) {

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        //Jan.Nowak@PersonelManager.pl
        //2820

        void LoginEvent(object sender, LoginEventArgs args) {
            Login(args);
        }

        void RequestResetPasswordEvent(object sender, LoginEventArgs args) {
            ResetPassword(args);
        }
        void UpdatePasswordEvent(object sender, LoginEventArgs args) {
            UpdatePassword(args);
        }

        private void Login(LoginEventArgs args) {
            try {
                string hashedPassword = PasswordManager.EncryptPassword(args.Password);

                var response = _handler.Login(args.Login, hashedPassword);
                SetToken(response.Token);
                if (response.RequestedPasswordReset) {
                    NavigateUpdatePasswordEvent(this, args);
                } else {
                    StartMainWindow(this, LoginEventArgs.Empty);
                }
            } catch (UnauthorizedAccessException) {
                string exceptionMsg = "Niepoprawny login lub hasło.";
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            } catch (Exception ex) {
                string exceptionMsg = GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetPassword(LoginEventArgs args) {
            try {
                _handler.RequestPasswordReset(args.Login);
                string successMsg = string.Format($"Na adres {args.Login} została wysłana wiadomość z hasłem jednorazowego logowania. " +
                    $"Zaloguj się za jego pomocą. Po czym zostaniesz poproszony o podanie nowego stałego hasła.");
                MessageBox.Show(successMsg, "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigateLoginEvent(this, args);
            } catch (Exception ex) {
                string exceptionMsg = GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void UpdatePassword(LoginEventArgs args) {
            try {
                if (args.Password != args.ConfirmPassword)
                    MessageBox.Show("Podane hasła muszą być identyczne. Wprowadż ponownie.", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                //TODO: Clear passwords
                else {
                    string hashedPassword = PasswordManager.EncryptPassword(args.Password);

                    _handler.UpdatePassword(args.Login, hashedPassword);
                    MessageBox.Show("Hasło zostało zaktualizowane.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                    StartMainWindow(this, LoginEventArgs.Empty);
                }
            } catch (Exception ex) {
                string exceptionMsg = GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //TODO: This needs to be moved somewhere? AppConfig class?
        private void SetToken(string token) => Settings.Token = token;

        //TODO: This needs to be somewhere else
        private string GenerateExceptionMsg(Exception ex) {
            if (ex?.InnerException is HttpRequestException)
                return "Nie można nawiązać połączenia z serwerem. Spróbuj ponownie później. Jesli problem będzie się powtarzał skontaktuj się z administratorem.";
            return ex.InnerException?.Message ?? ex.Message;
        }
    }
}
