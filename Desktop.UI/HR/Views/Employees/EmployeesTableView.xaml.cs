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

namespace Desktop.UI.HR.Views.Employees {
    /// <summary>
    /// Interaction logic for EmployeesTableView.xaml
    /// </summary>
    public partial class EmployeesTableView : Page {

        private readonly EmployeeRequestHandler _handler;

        public EmployeesTableView() {
            _handler = new EmployeeRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            EmployeeFormView form = new EmployeeFormView();
            form.ShowDialog();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            await ViewHelper.DeleteRow(_handler, DataGrid);
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Employee employee = item as Employee;

            if (string.IsNullOrEmpty(input))
                return true;

            return employee.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.Profession.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.ForemanFullName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.LocationName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.PhoneNo.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || employee.Nationality.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }


        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }


        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }
        private void EditRow() {
            Employee employee = (Employee)DataGrid.SelectedItem;
            EmployeeFormView form = new EmployeeFormView(employee.Id);
            form.ShowDialog();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
