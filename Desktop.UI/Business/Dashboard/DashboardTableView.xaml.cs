using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Business.Models;
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
using System.Windows.Shapes;

namespace Desktop.UI.Business.Dashboard {
    /// <summary>
    /// Interaction logic for DashboardTableView.xaml
    /// </summary>
    public partial class DashboardTableView : Page {
        private readonly DashboardRequestHandler _handler;

        public DashboardTableView() {
            _handler = new DashboardRequestHandler();

            InitializeComponent();
            InitDatePickers();
            InitDataGrid();
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            CommunicationLibrary.Business.Models.Dashboard dashboard = item as CommunicationLibrary.Business.Models.Dashboard;

            bool result = dashboard.EmployeeFullName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || dashboard.Profession.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || dashboard.LocalizationName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || dashboard.ForemanName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || dashboard.ContractNumber.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;

            return result;
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void FilterByDatesButton_Click(object sender, RoutedEventArgs e) {
            InitDataGrid();
        }

        private void InitDatePickers() {
            var billingPeriod = DateHelper.GetBillingPeriod();

            FilterFromDatePicker.SelectedDate = billingPeriod.From;
            FilterToDatePicker.SelectedDate = billingPeriod.To;
        }

        private void InitDataGrid() {
            DataGrid.ItemsSource = _handler.GetDashboard((DateTime)FilterFromDatePicker.SelectedDate, (DateTime)FilterToDatePicker.SelectedDate);
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
