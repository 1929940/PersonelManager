﻿using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Bufor;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Absences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace Desktop.UI.HR.Views.Employees.Tabs {
    public partial class AbsencesTab : Page {

        public Employee Employee { get; set; }
        public List<Leave> DisplayData { get; set; }
        public Bufor<Leave> Bufor { get; set; }

        private readonly LeaveRequestHandler _handler;

        public AbsencesTab(Employee employee, Bufor<Leave> bufor) {
            Employee = employee;
            Bufor = bufor;
            _handler = new LeaveRequestHandler();

            InitializeComponent();
            BindDisplayData(Bufor.DisplayBufor);
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
            AbsenceFormView form = new AbsenceFormView(out Leave leave, Bufor);
            form.ShowDialog();
            if (Bufor.TransactionBufor.Contains(leave)) {
                DisplayData.Add(leave);
                CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) {
            EditRow();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            Leave leave = (Leave)DataGrid.SelectedItem;
            Bufor.TransactionBufor.Remove(leave);
            DisplayData.Remove(leave);
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }


        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EditRow();
        }

        private void EditRow() {
            Leave leave = (Leave)DataGrid.SelectedItem;
            AbsenceFormView form = new AbsenceFormView(leave, Bufor);
            form.ShowDialog();
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Refresh();
        }

        private void BindDisplayData(List<Leave> displayData) {
            if (displayData == null || !displayData.Any())
                displayData.AddRange(_handler.GetEmployeeLeaves(Employee?.Id ?? 0));
            DisplayData = displayData;
            DataGrid.ItemsSource = DisplayData;
            CollectionViewSource.GetDefaultView(DataGrid.ItemsSource).Filter = Filter;
        }
    }
}
