using System;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Business.Login {
    public partial class UpdatePasswordPage : Page {

        public EventHandler<LoginEventArgs> UpdatePasswordEvent;

        public string Login { get; set; }

        public UpdatePasswordPage() {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            LoginEventArgs args = new LoginEventArgs() {
                Login = Login,
                Password = PasswordBox.Password,
                ConfirmPassword = ConfirmPasswordBox.Password
            };

            UpdatePasswordEvent(this, args);
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password?.Length > 5 && ConfirmPasswordBox.Password.Length > 5)
                UpdateButton.IsEnabled = true;
            else
                UpdateButton.IsEnabled = false;
                    
        }
    }
}
