using CommunicationLibrary.Business.Requests;
using Desktop.UI.Core.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Business.Login {
    public partial class ForgotPasswordPage : Page {

        private readonly UserRequestHandler _handler;
        private readonly Frame _frame;

        public string Login { get; set; }

        public ForgotPasswordPage(Frame frame, string login) {
            Login = login;
            _handler = new UserRequestHandler();
            _frame = frame;
            this.DataContext = this;
            InitializeComponent();
        }

        private async void ResetButton_Click(object sender, RoutedEventArgs e) {
            LoginBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (Validation.GetHasError(LoginBox))
                return;

            await ResetPassword(Login);
        }

        private async Task ResetPassword(string login) {
            try {
                await _handler.RequestPasswordResetAsync(login);
                MessageBox.Show("Hasło zostało wysłane. Sprawdź skrzynke odbiorczą.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                _frame.Navigate(new LoginPage(_frame, login));
            } catch (Exception ex) {
                string exceptionMsg = ExceptionHelper.GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            _frame.Navigate(new LoginPage(_frame, Login));
        }
    }
}
