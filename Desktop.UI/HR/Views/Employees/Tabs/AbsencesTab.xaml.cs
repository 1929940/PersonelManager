using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Absences;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Desktop.UI.HR.Views.Employees.Tabs {
    /// <summary>
    /// Interaction logic for AbsencesTab.xaml
    /// </summary>
    public partial class AbsencesTab : Page {

        public Employee Employee { get; set; }
        public bool EditMode { get; set; }
        public List<Leave> OriginalData { get; set; }
        public List<Leave> CurrentData { get; set; }

        //TODO: STORE DATA THAT WAS CHANGED AND STATUS ADDED MODIFIED DELETED
        //COMMUNICATION LIBRARY

        // OF T : WHERE T is BASE ENTITY
        // T value ALLOWS TO ADD EVERYTHING
        // METHODS ADDDATA/REMOVEDATA/MODIFYDATA
        // EXECUTE or SYNC OR FLUSH!


        private readonly LeaveRequestHandler _handler;

        public AbsencesTab(Employee employee, bool editMode) {
            Employee = employee;
            EditMode = editMode;
            _handler = new LeaveRequestHandler();
            OriginalData = CurrentData = _handler.GetEmployeeLeaves(Employee.Id).ToList();

            InitializeComponent();

            DataGrid.ItemsSource = CurrentData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e) {
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private bool Filter(object item) {
            string input = FilterBox.Text;
            Leave leave = item as Leave;

            if (string.IsNullOrEmpty(input))
                return true;

            return leave?.Type.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || leave?.Comment.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e) {
            AbsenceFormView form = new AbsenceFormView();
            form.ShowDialog();
            //DataGrid.ItemsSource = _handler.Get();
            //CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }
        private async void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (EditMode) {
                await ViewHelper.DeleteRowAsync(_handler, DataGrid);
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
            }
        }


        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void EditRow() {
            Leave leave = (Leave)DataGrid.SelectedItem;
            AbsenceFormView form = new AbsenceFormView(leave);
            form.ShowDialog();
            //This needs to update but with current data
            //DataGrid.ItemsSource = _handler.Get();
            //CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
