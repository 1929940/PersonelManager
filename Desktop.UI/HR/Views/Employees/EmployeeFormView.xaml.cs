using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Helper;
using Desktop.UI.HR.Views.Certificates;
using Desktop.UI.HR.Views.Employees.Tabs;
using Desktop.UI.HR.Views.MedicalCheckups;
using Desktop.UI.HR.Views.SafetyTrainings;
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
    public partial class EmployeeFormView : Window {
        public Employee Employee { get; set; }
        public bool EditMode { get; set; }
        private readonly EmployeeRequestHandler _handler;
        public EmployeeBufor Bufor { get; set; }

        public EmployeeFormView() {
            _handler = new EmployeeRequestHandler();
            Employee = new Employee();
            Bufor = new EmployeeBufor();
            InitializeComponent();
            InitializeUI();
        }

        public EmployeeFormView(int id) {
            _handler = new EmployeeRequestHandler();
            Employee = _handler.Get(id);
            Bufor = new EmployeeBufor();
            EditMode = true;
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            GeneralTab.IsSelected = true;
            if (!EditMode)
                HistoryDataTab.Visibility = Visibility.Collapsed;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            TabControl tabControl = sender as TabControl;
            switch ((tabControl.SelectedItem as TabItem).Name) {
                case "GeneralTab":
                    TabFrame.Navigate(new GeneralTab(Employee, EditMode));
                    break;
                case "AbsencesTab":
                    TabFrame.Navigate(new LeavesTab(Employee, Bufor.LeaveBufor));
                    break;
                case "MedicalCheckupTab":
                    TabFrame.Navigate(new MedicalCheckupsTableView(Employee, Bufor.MedicalCheckupBufor));
                    break;
                case "SecurityTrainingTab":
                    TabFrame.Navigate(new SafetyTrainingsTableView(Employee, Bufor.SafetyTrainingBufor));
                    break;
                case "CertificationTab":
                    TabFrame.Navigate(new CertificatesTableView(Employee, Bufor.CertificateBufor));
                    break;
                case "HistoryDataTab":
                    TabFrame.Navigate(new GeneralTab(Employee, true, true));
                    break;
                default:
                    break;
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _handler.UpdateAsync(Employee.Id, Employee);
                    await Bufor.FlushBuforsAsync(Employee.Id);
                } else {
                    Employee created = await _handler.CreateAsync(Employee);
                    await Bufor.FlushBuforsAsync(created.Id);
                }
                this.Close();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }
    }
}
