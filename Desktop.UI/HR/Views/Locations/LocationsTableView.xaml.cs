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

namespace Desktop.UI.HR.Views.Locations {
    /// <summary>
    /// Interaction logic for LocationsTableView.xaml
    /// </summary>
    public partial class LocationsTableView : Page {

        private readonly LocationRequestHandler _handler;

        public LocationsTableView() {
            _handler = new LocationRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e) {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {

        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            await ViewHelper.DeleteRow(_handler, DataGrid);
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Location location = item as Location;

            if (string.IsNullOrEmpty(input))
                return true;

            return location.Name.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.Country.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.Region.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.City.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.Name.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.Street.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || location.Number.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

        }
    }
}
