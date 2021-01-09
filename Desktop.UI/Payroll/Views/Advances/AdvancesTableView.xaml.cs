using CommunicationAndCommonsLibrary.Business.Logic;
using CommunicationAndCommonsLibrary.Business.Models;
using CommunicationAndCommonsLibrary.Payroll.Models;
using CommunicationAndCommonsLibrary.Payroll.Requests;
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

namespace Desktop.UI.Payroll.Views.Advances {
    /// <summary>
    /// Interaction logic for AdvancesTableView.xaml
    /// </summary>
    public partial class AdvancesTableView : Page {

        private readonly AdvanceRequestHandler _handler;

        public AdvancesTableView() {
            _handler = new AdvanceRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Advance advance = item as Advance;

            bool result = advance.Employee.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || advance.Employee.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || advance.Contract.Number.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;

            if (ShowPaidCheckBox.IsChecked != true)
                result &= advance.PaidOn == null;

            return result;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            AdvancesFormView form = new AdvancesFormView(out _);
            form.ShowDialog();

            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private async  void DeleteButton_Click(object sender, RoutedEventArgs e) {
            Advance advance = (Advance)DataGrid.SelectedItem;
            if (advance == null)
                return;

            if (advance.PaidOn == null && !ConnectionManager.IsUserAuthorized(Roles.Administrator)) {
                MessageBox.Show("Nie można usuwać wypłaconych zaliczek", "Niedozwolona akcja", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (DialogHelper.Delete()) {
                await _handler.DeleteAsync(advance.Id);

                DataGrid.ItemsSource = _handler.Get();
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
            }
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void ShowPaidCheckbox_Changed(object sender, RoutedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void EditRow() {
            Advance advance = (Advance)DataGrid.SelectedItem;
            AdvancesFormView form = new AdvancesFormView(advance.Id);
            form.ShowDialog();

            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
