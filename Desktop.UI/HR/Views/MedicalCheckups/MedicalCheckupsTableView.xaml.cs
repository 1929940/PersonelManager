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

namespace Desktop.UI.HR.Views.MedicalCheckups {
    public partial class MedicalCheckupsTableView : Page {

        private readonly MedicalCheckupRequestHandler _handler;
        public Employee Employee { get; set; }
        public bool UseBufor { get; set; }
        public List<PersonelDocument> DisplayData { get; set; }


        public MedicalCheckupsTableView() {
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            DisplayData = _handler.Get().ToList();
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        public MedicalCheckupsTableView(Employee employee) {
            Employee = employee;
            UseBufor = true;
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            InitializeEmployeeView();
            DisplayData = _handler.GetEmployeeMedicalCheckups(employee.Id).ToList();
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            MedicalCheckupFormView form = new MedicalCheckupFormView(out PersonelDocument doc, UseBufor);
            form.ShowDialog();

            if (UseBufor) {
                if (EmployeeFormView.MedicalCheckupBufor.Contains(doc)) {
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
                    EmployeeFormView.MedicalCheckupBufor.Remove(doc);
                    DisplayData.Remove(doc);
                    CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
                } else {
                    await ViewHelper.DeleteRowAsync(_handler, DataGrid);
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
            MedicalCheckupFormView form = new MedicalCheckupFormView(doc, UseBufor);
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
