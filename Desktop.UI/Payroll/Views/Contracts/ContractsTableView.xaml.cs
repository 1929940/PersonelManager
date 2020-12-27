using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
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

namespace Desktop.UI.Payroll.Views.Contracts {
    /// <summary>
    /// Interaction logic for ContractsTableView.xaml
    /// </summary>
    public partial class ContractsTableView : Page {
        private readonly ContractRequestHandler _handler;

        public ContractsTableView() {
            _handler = new ContractRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Contract contract = item as Contract;

            bool result = contract.Employee.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || contract.Employee.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || contract.ContractSubject.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || contract.Title.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || contract.Number.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;

            if (ShowRealizedCheckbox.IsChecked != true)
                result &= contract.IsRealized == false;

            return result;
        }


        private void EditRow() {
            Contract contract = (Contract)DataGrid.SelectedItem;
            ContractFormView form = new ContractFormView(contract.Id);
            form.ShowDialog();

            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }


        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e) {
            ContractFormView form = new ContractFormView();
            form.ShowDialog();

            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            Contract contract = (Contract)DataGrid.SelectedItem;
            if (contract == null)
                return;

            if (contract.IsRealized) {
                MessageBox.Show("Nie można usuwać zrealizowanych umów.", "Niedozwolona akcja", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            } 
            
            if (DialogHelper.Delete()) {
                await _handler.DeleteAsync(contract.Id);

                DataGrid.ItemsSource = _handler.Get();
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void ShowRealizedCheckbox_Changed(object sender, RoutedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }
    }
}
