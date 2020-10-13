using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
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

namespace Desktop.UI.Business.UserManagment {
    /// <summary>
    /// Interaction logic for UserManagmentPage.xaml
    /// </summary>
    public partial class UserManagmentPage : Page {

        private readonly UserRequestHandler _handler;
        public ObservableCollection<User> Users { get; set; }

        public UserManagmentPage() {
            _handler = new UserRequestHandler();
            //Users = new ObservableCollection<User>();
            var users = _handler.Get();
            Users = new ObservableCollection<User>(users);
            InitializeComponent();
            UsersDataGrid.ItemsSource = Users;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e) {
            var users = _handler.Get();
            UsersDataGrid.ItemsSource = users;
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e) {
            var users = _handler.Get();
            Users = new ObservableCollection<User>(users);
        }

        private void EditUser_Click(object sender, RoutedEventArgs e) {

        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void UsersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

        }
    }
}
