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

namespace Desktop.UI.HR.Views.Foremen {
    /// <summary>
    /// Interaction logic for ForemenTableView.xaml
    /// </summary>
    public partial class ForemenTableView : Page {

        private readonly ForemanRequestHandler _handler;

        public ForemenTableView() {
            _handler = new ForemanRequestHandler();
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
            Foreman foreman = item as Foreman;

            if (string.IsNullOrEmpty(input))
                return true;

            return foreman.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || foreman.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || foreman.Mail.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || foreman.PhoneNo.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || foreman.Location.Name.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || foreman.Location.Country.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

        }
    }
}
