using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using Desktop.UI.Core;
using Desktop.UI.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop.UI.Business.Users {
    /// <summary>
    /// Interaction logic for UserManagmentPage.xaml
    /// </summary>
    public partial class UsersTableView : Page {

        private readonly UserRequestHandler _handler;

        //TODO: ERMOVE
        public IEnumerable<User> Users { get; set; }

        public UsersTableView() {
            _handler = new UserRequestHandler();
            InitializeComponent();
            UsersDataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(UsersDataGrid.ItemsSource).Filter = Filter;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e) {
            UserFormView userWindow = new UserFormView();
            userWindow.ShowDialog();
            UsersDataGrid.ItemsSource = _handler.Get();
        }

        private async void DeleteUser_Click(object sender, RoutedEventArgs e) {
            await ViewHelper.DeleteRow(_handler, UsersDataGrid);
        }

        private void EditUser_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(UsersDataGrid.ItemsSource).Refresh();
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            User user = item as User;

            if (string.IsNullOrEmpty(input))
                return true;

            return user.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || user.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || user.Email.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || user.Role.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void UsersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }


        private void EditRow() {
            User user = (User)UsersDataGrid.SelectedItem;
            UserFormView userWindow = new UserFormView(user.Id);
            userWindow.ShowDialog();
            UsersDataGrid.ItemsSource = _handler.Get();
        }
    }
}
