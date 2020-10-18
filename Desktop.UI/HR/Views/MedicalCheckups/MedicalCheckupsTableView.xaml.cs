using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Bufor;
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

        public Bufor<PersonelDocument> Bufor { get; set; }
        public bool UseBufor { get => Bufor != null; }

        public MedicalCheckupsTableView() {
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get().ToList();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        public MedicalCheckupsTableView(Employee employee, Bufor<PersonelDocument> bufor) {
            Employee = employee;
            Bufor = bufor;
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            InitializeEmployeeView();
            BindDisplayData();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            MedicalCheckupFormView form = new MedicalCheckupFormView(out PersonelDocument doc, Bufor);
            form.ShowDialog();

            if (UseBufor) {
                if (Bufor.TransactionBufor.Contains(doc)) {
                    Bufor.DisplayBufor.Add(doc);
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
            PersonelDocument doc = (PersonelDocument)DataGrid.SelectedItem;
            if (UseBufor) {
                Bufor.TransactionBufor.Remove(doc);
                Bufor.DisplayBufor.Remove(doc);
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
            } else if (DialogHelper.Delete() ){
                await _handler.DeleteAsync(doc.Id);
                DataGrid.ItemsSource = _handler.Get();
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
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
            MedicalCheckupFormView form = new MedicalCheckupFormView(doc, Bufor);
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

        private void BindDisplayData() {
            if (Bufor.DisplayBufor == null || (!Bufor.DisplayBufor.Any() && !Bufor.TransactionBufor.AnyQueuedRemovals()))
                Bufor.DisplayBufor.AddRange(_handler.GetEmployeeMedicalCheckups(Employee?.Id ?? 0));
            DataGrid.ItemsSource = Bufor.DisplayBufor;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
