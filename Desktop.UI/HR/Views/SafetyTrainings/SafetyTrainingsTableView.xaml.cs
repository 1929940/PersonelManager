using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Employees;
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

namespace Desktop.UI.HR.Views.SafetyTrainings {
    public partial class SafetyTrainingsTableView : Page {

        private readonly SafetyTrainingRequestHandler _handler;
        public Employee Employee { get; set; }
        public bool UseBufor { get; set; }
        public List<PersonelDocument> DisplayData { get; set; }

        public SafetyTrainingsTableView() {
            _handler = new SafetyTrainingRequestHandler();

            InitializeComponent();
            DisplayData = _handler.Get().ToList();
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        public SafetyTrainingsTableView(Employee employee) {
            Employee = employee;
            UseBufor = true;
            _handler = new SafetyTrainingRequestHandler();
            InitializeComponent();
            InitializeEmployeeView();
            DisplayData = _handler.GetEmployeeSafetyTrainings(employee.Id).ToList();
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            SafetyTrainingFormView form = new SafetyTrainingFormView(out PersonelDocument doc, UseBufor);
            form.ShowDialog();

            if (UseBufor) {
                if (EmployeeFormView.SafetyTrainingBufor .Contains(doc)) {
                    DisplayData.Add(doc);
                    CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
                }
            } else {
                DataGrid.ItemsSource = _handler.Get();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Delete()) {
                PersonelDocument doc = (PersonelDocument)DataGrid.SelectedItem;
                if (UseBufor) {
                    EmployeeFormView.SafetyTrainingBufor.Remove(doc);
                    DisplayData.Remove(doc);
                    CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
                } else {
                    await _handler.DeleteAsync(doc.Id);
                    DataGrid.ItemsSource = _handler.Get();
                    CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
                }
            }
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private bool Filter(object item) {
            return ViewHelper.IsDocWithinSearchParams(FilterBox.Text, item);
        }
    

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void EditRow() {
            PersonelDocument doc = (PersonelDocument)DataGrid.SelectedItem;
            SafetyTrainingFormView form = new SafetyTrainingFormView(doc, UseBufor);
            form.ShowDialog();

            if (UseBufor) {
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
            } else {
                DataGrid.ItemsSource = _handler.Get();
            }
        }

        private void InitializeEmployeeView() {
            HeaderTextBox.Visibility = Visibility.Collapsed;
            LastNameColumn.Visibility = Visibility.Collapsed;
            FirstNameColumn.Visibility = Visibility.Collapsed;
            ProfessionColumn.Visibility = Visibility.Collapsed;
        }
    }
}
