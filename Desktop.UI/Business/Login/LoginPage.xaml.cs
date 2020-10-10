using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;
using PersonalManagerDesktop;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop.UI.Business.Login {
    public partial class LoginPage : Page {

        private readonly UserRequestHandler _handler;

        private readonly Frame _frame;

        public string Login { get; set; }

        public LoginPage(Frame frame) {
            _handler = new UserRequestHandler();
            _frame = frame;
            this.DataContext = this;
            InitializeComponent();

        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e) {
            LoginBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (Validation.GetHasError(LoginBox))
                return;

            await AttemptLogin(Login, PasswordBox.Password);
        }

        private void ForgotPasswordLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            _frame.Navigate(new RequestResetPasswordPage(_frame));
        }

        private void FormFilled_TextChanged(object sender, RoutedEventArgs e) {

            if (!string.IsNullOrEmpty(PasswordBox?.Password) && !string.IsNullOrEmpty(LoginBox?.Text))
                LoginButton.IsEnabled = true;
            else
                LoginButton.IsEnabled = false;
        }

        private async Task AttemptLogin(string login, string password) {
            try {
                string hashedPassword = PasswordManager.EncryptPassword(password);

                var response = await _handler.LoginAsync(login, hashedPassword);
                SetToken(response.Token);
                if (response.RequestedPasswordReset) {
                    _frame.Navigate(new UpdatePasswordPage(_frame) { Login = Login});
                } else {
                    LoginWindow.StartMainWindow();
                }
            } catch (UnauthorizedAccessException) {
                string exceptionMsg = "Niepoprawny login lub hasło.";
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            } catch (Exception ex) {
                string exceptionMsg = GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //TODO: MOVE SOMEWHERE ELSE

        private string GenerateExceptionMsg(Exception ex) {
            if (ex?.InnerException is HttpRequestException)
                return "Nie można nawiązać połączenia z serwerem. Spróbuj ponownie później. Jesli problem będzie się powtarzał skontaktuj się z administratorem.";
            return ex.InnerException?.Message ?? ex.Message;
        }

        private void SetToken(string token) => Settings.Token = token;
    }
}
