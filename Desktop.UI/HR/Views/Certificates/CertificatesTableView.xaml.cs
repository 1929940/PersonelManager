using CommunicationLibrary.Business.Models;
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

namespace Desktop.UI.HR.Views.Certificates {
    /// <summary>
    /// Interaction logic for CertificatesTableView.xaml
    /// </summary>
    public partial class CertificatesTableView : Page {

        private readonly CertificateRequestHandler _handler;
        public Employee Employee { get; set; }
        public bool UseBufor { get; set; }
        public List<PersonelDocument> DisplayData { get; set; }

        public CertificatesTableView() {
            _handler = new CertificateRequestHandler();

            InitializeComponent();
            DisplayData = _handler.Get().ToList();
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        public CertificatesTableView(Employee employee, List<PersonelDocument> displayData) {
            Employee = employee;
            UseBufor = true;
            _handler = new CertificateRequestHandler();
            InitializeComponent();
            InitializeEmployeeView();
            BindDisplayData(displayData);
        }


        private void AddButton_Click(object sender, RoutedEventArgs e) {
            CertificateFormView form = new CertificateFormView(out PersonelDocument doc, UseBufor);
            form.ShowDialog();

            if (UseBufor) {
                if (EmployeeFormView.CertificateBufor.Contains(doc)) {
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
                    EmployeeFormView.CertificateBufor.Remove(doc);
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
            CertificateFormView form = new CertificateFormView(doc, UseBufor);
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

        private void BindDisplayData(List<PersonelDocument> displayData) {
            if (displayData == null || !displayData.Any())
                displayData.AddRange(_handler.GetEmployeeCertificates(Employee?.Id ?? 0));
            DisplayData = displayData;
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
