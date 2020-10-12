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

namespace PersonalManagerDesktop {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Console.WriteLine("h3h3");
        }

        private void TreeViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            TreeViewItem tvi = (TreeViewItem)sender;

            if (tvi.Header is StackPanel panel) {
                switch (panel.Name) {
                    case "Desktop_Panel":
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
                    case "Settings_Panel":
                        break;
                    default:
                        break;
                }
            }
            e.Handled = true;
        }
    }
}
