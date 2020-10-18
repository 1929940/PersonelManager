using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
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

namespace Desktop.UI.HR.Views.Employees.Tabs {
    /// <summary>
    /// Interaction logic for GeneralTab.xaml
    /// </summary>
    public partial class GeneralTab : Page {

        public bool IsHistoryView { get; set; }
        public Employee Employee { get; set; }
        public Employee HistoryEmployee { get; set; }


        public GeneralTab(Employee employee, bool EditMode, bool historyView = false) {
            InitializeComponent();
            IsHistoryView = historyView;
            Employee = employee;

            this.DataContext = employee;

            if (historyView)
                ShowHistoryControls();

            if (!EditMode || !AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();

            BindComboboxes();
        }

        private void ShowHistoryControls() {
            HistoryComboBox.Visibility = Visibility.Visible;
            HistoryTextBlock.Visibility = Visibility.Visible;
        }

        private void HideMetaDataRows() {
            CreatedRow.Height = new GridLength(0);
            UpdatedRow.Height = new GridLength(0);
            this.Height -= 50;
        }

        private void GeneralTabPage_Loaded(object sender, RoutedEventArgs e) {
            if (IsHistoryView || Employee.IsArchived)
                ControlsHelper.DisableControls(this, new string[] { HistoryComboBox.Name, IsArchiveCheckBox.Name });
        }

        private void BindComboboxes() {
            LocationCombobox.ItemsSource = ViewHelper.GetLocations();
            LocationCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Employee.LocationId ?? 0, LocationCombobox);

            BindForemanComboboxes((int)LocationCombobox.SelectedValue);

            if (IsHistoryView) {
                HistoryComboBox.ItemsSource = new EmployeeRequestHandler().GetEmployeeHistory(Employee.Id);
                HistoryComboBox.SelectedIndex = 0;
            }
        }

        private void BindForemanComboboxes(int locationId) {
            ForemanCombobox.ItemsSource = ViewHelper.GetForemen(locationId);
            ForemanCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Employee.ForemanId ?? 0, ForemanCombobox);
        }

        private void ForemanCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (ForemanCombobox.SelectedValue != null)
                Employee.ForemanId = (int)ForemanCombobox.SelectedValue;
        }

        private void LocationCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int selectedValue = (int)LocationCombobox.SelectedValue;
            Employee.LocationId = selectedValue;
            Employee.ForemanId = 0;

            BindForemanComboboxes(selectedValue);
        }

        private void HistoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (IsHistoryView) {
                HistoryEmployee = (Employee)HistoryComboBox.SelectedValue;
                this.DataContext = HistoryEmployee;
            }
        }
    }
}
