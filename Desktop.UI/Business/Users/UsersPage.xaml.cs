using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using Desktop.UI.Core;
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
    public partial class UsersPage : Page {

        private readonly UserRequestHandler _handler;
        public IEnumerable<User> Users { get; set; }

        public UsersPage() {
            _handler = new UserRequestHandler();
            InitializeComponent();
            UsersDataGrid.ItemsSource = _handler.Get();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e) {
            UserWindow userWindow = new UserWindow();
            userWindow.ShowDialog();
            UsersDataGrid.ItemsSource = _handler.Get();
        }

        private async void DeleteUser_Click(object sender, RoutedEventArgs e) {
            User user = (User)UsersDataGrid.SelectedItem;
            await _handler.DeleteAsync(user.Id);
            UsersDataGrid.ItemsSource = _handler.Get();
            //if successful show ok, update list
            //if fail do nothing

            //what if row was already removed?
            //what if connection failed?
        }

        private void EditUser_Click(object sender, RoutedEventArgs e) {
            User user = (User)UsersDataGrid.SelectedItem;
            UserWindow userWindow = new UserWindow(user.Id);
            userWindow.ShowDialog();
            UsersDataGrid.ItemsSource = _handler.Get();
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void UsersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            User user = (User)UsersDataGrid.SelectedItem;
            UserWindow userWindow = new UserWindow(user.Id);
            userWindow.ShowDialog();
            UsersDataGrid.ItemsSource = _handler.Get();
        }
    }
}
