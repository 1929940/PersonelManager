using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
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

        public static Bufor<Leave> LeaveBufor { get; set; }
        public static Bufor<PersonelDocument> MedicalCheckupBufor { get; set; }
        public static Bufor<PersonelDocument> SafetyTrainingBufor { get; set; }
        public static Bufor<PersonelDocument> CertificateBufor { get; set; }

        public List<Leave> LeavesStorage { get; set; }
        public List<PersonelDocument> MedicalCheckupsStorage { get; set; }
        public List<PersonelDocument> SafetyTrainingsStorage { get; set; }
        public List<PersonelDocument> CertificatesStorage { get; set; }


        public EmployeeFormView() {
            _handler = new EmployeeRequestHandler();
            Employee = new Employee();
            InitializeComponent();
            InitializeUI();
            InitializeBufors();
            InitializeTabStorage();
        }

        public EmployeeFormView(int id) {
            _handler = new EmployeeRequestHandler();
            Employee = _handler.Get(id);
            EditMode = true;
            InitializeComponent();
            InitializeUI();
            InitializeBufors();
            InitializeTabStorage();
        }

        private void InitializeUI() {
            GeneralTab.IsSelected = true;
            if (EditMode) {
                UpdateButton.Visibility = Visibility.Visible;
            } else {
                AddButton.Visibility = Visibility.Visible;
                HistoryDataTab.Visibility = Visibility.Collapsed;
            }
        }

        private void InitializeBufors() {
            LeaveBufor = new Bufor<Leave>(new LeaveRequestHandler());
            MedicalCheckupBufor = new Bufor<PersonelDocument>(new MedicalCheckupRequestHandler());
            SafetyTrainingBufor = new Bufor<PersonelDocument>(new SafetyTrainingRequestHandler());
            CertificateBufor = new Bufor<PersonelDocument>(new CertificateRequestHandler());
        }

        private void InitializeTabStorage() {
            LeavesStorage = new List<Leave>();
            MedicalCheckupsStorage = new List<PersonelDocument>();
            SafetyTrainingsStorage = new List<PersonelDocument>();
            CertificatesStorage = new List<PersonelDocument>();
        }

        private async Task FlushBuforsAsync(int id) {
            await LeaveBufor.FlushAsync(id);
            await MedicalCheckupBufor.FlushAsync(id);
            await SafetyTrainingBufor.FlushAsync(id);
            await CertificateBufor.FlushAsync(id);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            TabControl tabControl = sender as TabControl;
            switch ((tabControl.SelectedItem as TabItem).Name) {
                case "GeneralTab":
                    TabFrame.Navigate(new GeneralTab(Employee, EditMode));
                    break;
                case "AbsencesTab":
                    TabFrame.Navigate(new AbsencesTab(Employee, LeavesStorage));
                    break;
                case "MedicalCheckupTab":
                    TabFrame.Navigate(new MedicalCheckupsTableView(Employee, MedicalCheckupsStorage));
                    break;
                case "SecurityTrainingTab":
                    TabFrame.Navigate(new SafetyTrainingsTableView(Employee, SafetyTrainingsStorage));
                    break;
                case "CertificationTab":
                    TabFrame.Navigate(new CertificatesTableView(Employee, CertificatesStorage));
                    break;
                case "HistoryDataTab":
                    TabFrame.Navigate(new GeneralTab(Employee, true, true));
                    break;
                default:
                    break;
            }
        }

        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                Employee created = await _handler.CreateAsync(Employee);
                await FlushBuforsAsync(created.Id);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(Employee.Id, Employee);
                await FlushBuforsAsync(Employee.Id);
                this.Close();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }
    }
}
