using CommunicationLibrary.Business.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Business.Login {
    public partial class RequestResetPasswordPage : Page {

        private readonly UserRequestHandler _handler;
        private readonly Frame _frame;

        public string Login { get; set; }

        public RequestResetPasswordPage(Frame frame) {
            _handler = new UserRequestHandler();
            _frame = frame;
            this.DataContext = this;
            InitializeComponent();
        }

        private async void GenerateButton_Click(object sender, RoutedEventArgs e) {
            LoginBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (Validation.GetHasError(LoginBox))
                return;

            await ResetPassword(Login);
        }

        private async Task ResetPassword(string login) {
            try {
                await _handler.RequestPasswordResetAsync(login);
                string successMsg = string.Format($"Na adres {login} została wysłana wiadomość z hasłem jednorazowego logowania. " +
                    $"Zaloguj się za jego pomocą. Po czym zostaniesz poproszony o podanie nowego stałego hasła.");
                MessageBox.Show(successMsg, "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                _frame.Navigate(new LoginPage(_frame));
            } catch (Exception ex) {
                string exceptionMsg = GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            _frame.Navigate(new LoginPage(_frame));
        }

        private string GenerateExceptionMsg(Exception ex) {
            if (ex?.InnerException is HttpRequestException)
                return "Nie można nawiązać połączenia z serwerem. Spróbuj ponownie później. Jesli problem będzie się powtarzał skontaktuj się z administratorem.";
            return ex.InnerException?.Message ?? ex.Message;
        }
    }
}
