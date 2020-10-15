using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop.UI.Business.Users {
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserFormView : Window {

        public User User { get; set; }
        private readonly UserRequestHandler _handler;

        public UserFormView() {

            _handler = new UserRequestHandler();
            User = new User() {
                IsActive = true,
                CreatedOn = DateTime.Now,
                CreatedBy = "me"

            };
            this.DataContext = User;
            InitializeComponent();
            HeaderText.Text = "Dodaj Użytkownika";
            AddUser.Visibility = Visibility.Visible;
            InitRoleComboBox();
            HideMetaDataRows();
        }

        public UserFormView(int id) {

            _handler = new UserRequestHandler();
            User = _handler.Get(id);
            this.DataContext = User;
            InitializeComponent();
            HeaderText.Text = "Modyfikuj Użytkownika";
            UpdateUser.Visibility = Visibility.Visible;
            InitRoleComboBox();
        }

        private async void AddUser_Click(object sender, RoutedEventArgs e) {
            if (ValidationHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(User);
                this.Close();
            }
        }

        private async void UpdateUser_Click(object sender, RoutedEventArgs e) {
            if (ValidationHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(User.Id, User);
                this.Close();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private string[] GetRoles() => new string[] {
            "Pracownik",
            "Kierownik",
            "Administrator"
        };

        private void InitRoleComboBox() {
            RoleComboBox.ItemsSource = GetRoles();
            RoleComboBox.SelectedIndex = 0;
        }

        private void RoleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            User.Role = RoleComboBox.SelectedValue as string;
        }

        private void HideMetaDataRows() {
            CreatedRow.Height = new GridLength(0);
            UpdatedRow.Height = new GridLength(0);
            this.Height -= 50;
        }
    }
}
