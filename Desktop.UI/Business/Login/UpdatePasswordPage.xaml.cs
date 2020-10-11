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

        public UpdatePasswordPage(Frame frame) {
            _handler = new UserRequestHandler();
            _frame = frame;
            InitializeComponent();
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            await UpdatePassword(Login, PasswordBox.Password, ConfirmPasswordBox.Password);
        }

        private async Task UpdatePassword(string login, string password, string confirmPassword) {
            try {
                if (password != confirmPassword) {
                    MessageBox.Show("Podane hasła muszą być identyczne. Wprowadż ponownie.", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    ClearPasswords();
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
            if (PasswordBox.Password?.Length > 5 && ConfirmPasswordBox.Password.Length > 5)
                UpdateButton.IsEnabled = true;
            else
                UpdateButton.IsEnabled = false;
        }

        private void ClearPasswords() {
            PasswordBox.Password = string.Empty;
            ConfirmPasswordBox.Password = string.Empty;
        }
    }
}
