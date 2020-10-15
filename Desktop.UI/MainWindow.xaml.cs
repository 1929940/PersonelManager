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
using Desktop.UI.HR.Views.Employees;
using Desktop.UI.HR.Views.MedicalCheckups;
using Desktop.UI.HR.Views.SafetyTrainings;
using Desktop.UI.HR.Views.Certificates;
using Desktop.UI.HR.Views.Locations;
using Desktop.UI.HR.Views.Foremen;
using Desktop.UI.Payroll.Views.Contracts;
using Desktop.UI.Payroll.Views.Payments;
using Desktop.UI.Payroll.Views.Advances;

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
            ServerConnectionHelper.SetLoginData(new UserRequestHandler().Login("1929940@gmail.com", "1111"));

            //KIEROWNIK
            //ServerConnectionHelper.SetLoginData(new UserRequestHandler().Login("Witkowski@poczta.pl", "2897"));


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
                        ContentFrame.Navigate(new EmployeesTableView());
                        break;
                    case "MedicalCheckups_Panel":
                        ContentFrame.Navigate(new MedicalCheckupsTableView());
                        break;
                    case "SafetyTrainings_Panel":
                        ContentFrame.Navigate(new SafetyTrainingsTableView());
                        break;
                    case "Certficates_Panel":
                        ContentFrame.Navigate(new CertificatesTableView());
                        break;
                    case "Localizations_Panel":
                        ContentFrame.Navigate(new LocationsTableView());
                        break;
                    case "Foremen_Panel":
                        ContentFrame.Navigate(new ForemenTableView());
                        break;
                    case "Contracts_Panel":
                        ContentFrame.Navigate(new ContractsTableView());
                        break;
                    case "Pay_Panel":
                        ContentFrame.Navigate(new PaymentsTableView());
                        break;
                    case "Advances_Panel":
                        ContentFrame.Navigate(new AdvancesTableView());
                        break;
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
