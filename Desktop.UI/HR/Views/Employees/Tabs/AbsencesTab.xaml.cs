using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Absences;
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

namespace Desktop.UI.HR.Views.Employees.Tabs {
    /// <summary>
    /// Interaction logic for AbsencesTab.xaml
    /// </summary>
    public partial class AbsencesTab : Page {

        public Employee Employee { get; set; }
        public List<Leave> DisplayData { get; set; }

        private readonly LeaveRequestHandler _handler;

        public AbsencesTab(Employee employee, List<Leave> displayData) {
            Employee = employee;
            _handler = new LeaveRequestHandler();

            InitializeComponent();
            BindDisplayData(displayData);
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Leave leave = item as Leave;

            if (string.IsNullOrEmpty(input))
                return true;

            return leave?.Type.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || leave?.Comment.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e) {
            AbsenceFormView form = new AbsenceFormView(out Leave leave);
            form.ShowDialog();
            if (EmployeeFormView.LeaveBufor.Contains(leave)) {
                DisplayData.Add(leave);
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Delete()) {
                Leave leave = (Leave)DataGrid.SelectedItem;
                EmployeeFormView.LeaveBufor.Remove(leave);
                DisplayData.Remove(leave);
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
            }
        }


        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void EditRow() {
            Leave leave = (Leave)DataGrid.SelectedItem;
            AbsenceFormView form = new AbsenceFormView(leave);
            form.ShowDialog();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void BindDisplayData(List<Leave> displayData) {
            if (displayData == null || !displayData.Any())
                displayData.AddRange(_handler.GetEmployeeLeaves(Employee?.Id ?? 0));
            DisplayData = displayData;
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
