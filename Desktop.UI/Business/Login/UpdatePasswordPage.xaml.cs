using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core.Logic;
using Desktop.UI.Core.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Business.Login {
    public partial class UpdatePasswordPage : Page {

        private readonly UserRequestHandler _handler;
        private readonly Frame _frame;

        public string Login { get; set; }

        public UpdatePasswordPage(Frame frame, string login) {
            _handler = new UserRequestHandler();
            _frame = frame;
            Login = login;
            this.DataContext = this;
            InitializeComponent();
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            await UpdatePassword(Login, PasswordBox.Password, ConfirmPasswordBox.Password);
        }

        private async Task UpdatePassword(string login, string password, string confirmPassword) {
            try {
                if (password != confirmPassword) {
                    MessageBox.Show("Podane hasła muszą być identyczne.", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                } else {
                    string hashedPassword = PasswordManager.EncryptPassword(password);

                    await _handler.UpdatePasswordAsync(login, hashedPassword);
                    MessageBox.Show("Hasło zostało zaktualizowane.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoginWindow.StartMainWindow();
                }
            } catch (Exception ex) {
                string exceptionMsg = ExceptionHelper.GenerateExceptionMsg(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) {
            if (!string.IsNullOrEmpty(PasswordBox.Password) && !string.IsNullOrEmpty(ConfirmPasswordBox.Password))
                UpdateButton.IsEnabled = true;
            else
                UpdateButton.IsEnabled = false;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password?.Length < 6)
                LengthTextBlock.Visibility = Visibility.Visible;
            else
                LengthTextBlock.Visibility = Visibility.Collapsed;
        }

        private void ConfirmPasswordBox_LostFocus(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password?.Length > 5 && PasswordBox.Password != ConfirmPasswordBox.Password)
                DifferentPasswordsTextBlock.Visibility = Visibility.Visible;
            else
                DifferentPasswordsTextBlock.Visibility = Visibility.Collapsed;
        }
    }
}
