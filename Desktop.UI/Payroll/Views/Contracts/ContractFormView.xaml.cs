﻿using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.Payroll.Helpers;
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

namespace Desktop.UI.Payroll.Views.Contracts {
    /// <summary>
    /// Interaction logic for ContractFormView.xaml
    /// </summary>
    public partial class ContractFormView : Window {
        public Contract Contract { get; set; }
        private readonly ContractRequestHandler _handler;
        public bool EditMode { get; set; }
        public ContractBufor Bufor { get; set; }

        public DateTime PaidOn { get; set; }

        public ContractFormView() {
            _handler = new ContractRequestHandler();
            Contract = new Contract();
            Bufor = new ContractBufor();
            this.DataContext = Contract;
            InitializeComponent();

            InitUI();
        }

        public ContractFormView(int id) {
            EditMode = true;
            _handler = new ContractRequestHandler();
            Contract = _handler.Get(id);
            Bufor = new ContractBufor();

            this.DataContext = Contract;
            InitializeComponent();
            InitUI();
        }

        private void InitUI() {
            InitPaymentSection();
            BindCombobox();
            InitDates();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Contract);
            InitPaymentButtons();
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Umowe";
            } else {
                HeaderText.Text = "Dodaj Umowe";
            }
        }

        private void InitDates() {
            if (!EditMode) {
                DateTime startingDate = DateTime.Today;
                DateTime endingDate = DateTime.Today;

                ConfigurationPage config = new ConfigurationPageRequestHandler().Get();
                if (config.BillingMonthStart < DateTime.Today.Day) {
                    startingDate = startingDate.AddMonths(1);
                    endingDate = endingDate.AddMonths(1);
                }

                if (config.BillingMonthStart > config.BillingMonthEnd) {
                    endingDate = startingDate.AddMonths(1);
                }

                ValidFromDatePicker.SelectedDate = DateHelper.CreateDate(startingDate.Year, startingDate.Month, config.BillingMonthStart);
                ValidToDatePicker.SelectedDate = DateHelper.CreateDate(endingDate.Year, endingDate.Month, config.BillingMonthEnd);

                TitleTextBox.Text = string.Format($"Umowa za {startingDate.ToString("MMMMMMMMMMMMM")}");
            }
        }

        private void InitPaymentSection() {
            decimal paymentValue = Contract.NettoValue - Contract.AdvancesTotalValue;
            if (PaidOnDatePicker != null)
                PaidOnDatePicker.DataContext = this;

            if (Contract.PaidOn == null) {
                if (ToBePaidTextBox != null && PaidTextBox != null && PaidOnDatePicker != null) {
                    ToBePaidTextBox.Text = paymentValue.ToString("0.00 PLN");
                    PaidTextBox.Text = "0.00 PLN";
                    PaidOnDatePicker.SelectedDate = DateTime.Today;
                }
            } else {
                if (PaidTextBox != null) {
                    ToBePaidStackPanel.Visibility = Visibility.Collapsed;
                    PaidTextBox.Text = paymentValue.ToString("0.00 PLN");
                }
            }
        }

        private void InitPaymentButtons() {
            //if (Contract.Payment == null) {
            //AddPayment.Visibility = Visibility.Visible;
            //} else {
            //EditPayment.Visibility = Visibility.Visible;
            //RemovePayment.Visibility = Visibility.Visible;
            //}
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Contract.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (EditMode) {
                EmployeeCombobox.ItemsSource = ViewHelper.GetCurrentEmployeeDictionary(Contract.Employee);
                EmployeeCombobox.SelectedIndex = 0;
                EmployeeCombobox.IsEnabled = false;
            } else {
                EmployeeCombobox.ItemsSource = ViewHelper.GetEmployeesDictionary();
                EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Contract.Employee.Id, EmployeeCombobox);
            }
        }

        private void AddAdvance_Click(object sender, RoutedEventArgs e) {

        }

        private void ShowAdvances_Click(object sender, RoutedEventArgs e) {

        }

        private void AddPayment_Click(object sender, RoutedEventArgs e) {
            InitPaymentButtons();
        }

        private void EditPayment_Click(object sender, RoutedEventArgs e) {
            InitPaymentButtons();
        }

        private void RemovePayment_Click(object sender, RoutedEventArgs e) {
            InitPaymentButtons();
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _handler.UpdateAsync(Contract.Id, Contract);
                    await Bufor.FlushBuforsAsync(Contract.Id);
                } else {
                    Contract created = await _handler.CreateAsync(Contract);
                    await Bufor.FlushBuforsAsync(created.Id);
                }
                this.Close();
            }
        }

        private void ValueTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            decimal netto = Decimal.Round(Contract.TotalValue - (Contract.TotalValue * Contract.TaxPercent / 100), 2);

            if (ValueNettoTextBox != null) {
                ValueNettoTextBox.Text = netto.ToString("0.00 PLN");
                Contract.NettoValue = netto;
                InitPaymentSection();
            }
        }

        private void ConfirmPayment_Click(object sender, RoutedEventArgs e) {
            Contract.PaidOn = PaidOn;
            InitPaymentSection();
        }
    }
}
