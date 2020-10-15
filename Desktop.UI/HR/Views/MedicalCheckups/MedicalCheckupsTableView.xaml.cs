using CommunicationLibrary.HR.Requests;
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
    /// <summary>
    /// Interaction logic for MedicalCheckupsTableView.xaml
    /// </summary>
    public partial class MedicalCheckupsTableView : Page {

        private readonly MedicalCheckupRequestHandler _handler;

        public MedicalCheckupsTableView() {
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            DataGrid.ItemsSource = _handler.Get();
            //CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {

        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

        }
    }
}
