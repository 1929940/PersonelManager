﻿using CommunicationAndCommonsLibrary.Business.Logic;
using CommunicationAndCommonsLibrary.Business.Requests;
using CommunicationAndCommonsLibrary.Core.Logic;
using Desktop.UI.Core.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop.UI.Business.Login {
    public partial class LoginPage : Page {

        private readonly UserRequestHandler _handler;

        private readonly Frame _frame;

        public string Login { get; set; }

        public LoginPage(Frame frame, string login) {
            Login = login;
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
            _frame.Navigate(new ForgotPasswordPage(_frame, LoginBox.Text));
        }

        private void FormFilled_TextChanged(object sender, RoutedEventArgs e) {
            if (LoginButton == null)
                return;

            if (!string.IsNullOrEmpty(PasswordBox?.Password) && !string.IsNullOrEmpty(LoginBox?.Text))
                LoginButton.IsEnabled = true;
            else
                LoginButton.IsEnabled = false;
        }

        private async Task AttemptLogin(string login, string password) {
            try {
                var response = await _handler.LoginAsync(login, password);
                ConnectionManager.Login(response);
                if (response.RequestedPasswordReset) {
                    _frame.Navigate(new UpdatePasswordPage(_frame, Login));
                } else {
                    LoginWindow.StartMainWindow();
                }
            } catch (UnauthorizedAccessException) {
                string exceptionMsg = "Niepoprawny login lub hasło.";
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            } catch (Exception ex) {
                string exceptionMsg = ExceptionHelper.GetMessage(ex);
                MessageBox.Show(exceptionMsg, "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
