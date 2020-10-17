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

namespace Desktop.UI.HR.Views.SafetyTrainings {
    /// <summary>
    /// Interaction logic for SafetyTrainingsTableView.xaml
    /// </summary>
    public partial class SafetyTrainingsTableView : Page {

        private readonly SafetyTrainingRequestHandler _handler;

        public SafetyTrainingsTableView() {
            _handler = new SafetyTrainingRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            SafetyTrainingFormView form = new SafetyTrainingFormView();
            form.ShowDialog();
            DataGrid.ItemsSource = _handler.Get();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            await ViewHelper.DeleteRowAsync(_handler, DataGrid);
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
            SafetyTrainingFormView form = new SafetyTrainingFormView(doc.Id);
            form.ShowDialog();
            DataGrid.ItemsSource = _handler.Get();
        }
    }
}
