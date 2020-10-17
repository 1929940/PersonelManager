using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
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
        public bool EditMode { get; set; }
        private readonly EmployeeRequestHandler _handler;

        public EmployeeFormView() {
            _handler = new EmployeeRequestHandler();
            Employee = new Employee();
            InitializeComponent();
            GeneralTab.IsSelected = true;
            AddButton.Visibility = Visibility.Visible;
            HistoryDataTab.Visibility = Visibility.Collapsed;
        }

        public EmployeeFormView(int id) {
            _handler = new EmployeeRequestHandler();
            Employee = _handler.Get(id);
            EditMode = true;
            InitializeComponent();
            GeneralTab.IsSelected = true;
            UpdateButton.Visibility = Visibility.Visible;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            TabControl tabControl = sender as TabControl;
            switch ((tabControl.SelectedItem as TabItem).Name) {
                case "GeneralTab":
                    TabFrame.Navigate(new GeneralTab(Employee, EditMode));
                    break;
                case "AbsencesTab":
                    TabFrame.Navigate(new AbsencesTab(Employee, EditMode));
                    break;
                case "MedicalCheckupTab":
                case "SecurityTrainingTab":
                case "CertificationTab":
                case "HistoryDataTab":
                    TabFrame.Navigate(new GeneralTab(Employee, true, true));
                    break;
                default:
                    break;
            }
        }

        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(Employee);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(Employee.Id, Employee);
                this.Close();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }
    }
}
