using System;
using System.Collections.Generic;
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
using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Business.Requests;
using Desktop.UI.Business.Login;
using Desktop.UI.Business.Users;
using System.Globalization;
using System.Threading;
using Desktop.UI.Business.Configuration;
using Desktop.UI.Core.Helpers;

namespace PersonalManagerDesktop {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {

            //TODO: REMOVE
            ServerConnectionData.Url = @"https://localhost:44345";


            //Settings.Token = new UserRequestHandler().Login("1929940@gmail.com", "1111").Token;

            //ADMIN
            //ServerConnectionHelper.SetLoginData(new UserRequestHandler().Login("1929940@gmail.com", "1111"));

            //KIEROWNIK
            ServerConnectionHelper.SetLoginData(new UserRequestHandler().Login("Witkowski@poczta.pl", "2897"));


            //PRACOWNIK
            //ServerConnectionHelper.SetLoginData(new UserRequestHandler().Login("wnuda@wp.pl", "5572"));


            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");


            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Console.WriteLine("h3h3");
        }

        private void TreeViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            TreeViewItem tvi = (TreeViewItem)sender;

            if (tvi.Header is StackPanel panel) {
                switch (panel.Name) {
                    case "Dashboard_Panel":
                    case "Employees_Panel":
                    case "MedicalCheckups_Panel":
                    case "SafetyTrainings_Panel":
                    case "Certficates_Panel":
                    case "Localizations_Panel":
                    case "Foremen_Panel":
                    case "Contracts_Panel":
                    case "Pay_Panel":
                    case "Advances_Panel":
                    case "Users_Panel":
                        ContentFrame.Navigate(new UsersTableView());
                        break;
                    case "Settings_Panel":
                        ContentFrame.Navigate(new ConfigurationView());
                        break;
                    default:
                        break;
                }
            }
            e.Handled = true;
        }

        private void AdminTreeViewItem_Loaded(object sender, RoutedEventArgs e) {
            AdminTreeViewItem.Visibility = (AuthorizationHelper.Authorize(Enums.Roles.Kierownik)) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
