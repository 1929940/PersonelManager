using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.HR.Views.Employees.Tabs;
using Desktop.UI.HR.Views.MedicalCheckups;
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
using System.Windows.Shapes;

namespace Desktop.UI.HR.Views.Employees {
    /// <summary>
    /// Interaction logic for EmployeeFormView.xaml
    /// </summary>
    public partial class EmployeeFormView : Window {
        public Employee Employee { get; set; }
        private readonly EmployeeRequestHandler _handler;

        public EmployeeFormView() {
            _handler = new EmployeeRequestHandler();
            Employee = new Employee();
            InitializeComponent();
            GeneralTab.IsSelected = true;
        }

        public EmployeeFormView(int id) {
            _handler = new EmployeeRequestHandler();
            Employee = _handler.Get(id);
            InitializeComponent();
            GeneralTab.IsSelected = true;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            TabControl tabControl = sender as TabControl;
            switch ((tabControl.SelectedItem as TabItem).Name) {
                case "GeneralTab":
                    TabFrame.Navigate(new GeneralTab(Employee));
                    break;
                case "AbsencesTab":
                case "MedicalCheckupTab":
                    TabFrame.Navigate(new MedicalCheckupFormView(Employee.Id));
                    break;
                case "SecurityTrainingTab":
                case "CertificationTab":
                case "HistoryDataTab":
                    TabFrame.Navigate(new GeneralTab(Employee, true));
                    break;
                default:
                    break;
            }


            Console.WriteLine("hehe");

        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {

        }
        private void Close_Click(object sender, RoutedEventArgs e) {

        }
    }
}
