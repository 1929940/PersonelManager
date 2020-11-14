using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
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
using System.Windows.Shapes;

namespace Desktop.UI.Payroll.Views.Contracts {
    /// <summary>
    /// Interaction logic for ContractFormView.xaml
    /// </summary>
    public partial class ContractFormView : Window {
        public Contract Contract { get; set; }
        private readonly ContractRequestHandler _handler;
        public bool EditMode { get; set; }
        public decimal AdvancesSum => Contract.Advances?.Sum(x => x.Amount) ?? 0m;

        public ContractFormView() {
            _handler = new ContractRequestHandler();
            Contract = new Contract();

            this.DataContext = Contract;
            InitializeComponent();
            AdvancesSumTextBox.DataContext = this;

            InitUI();
        }

        public ContractFormView(int id) {
            EditMode = true;
            _handler = new ContractRequestHandler();
            Contract = _handler.Get(id);

            this.DataContext = Contract;
            InitializeComponent();
            AdvancesSumTextBox.DataContext = this;
            InitUI();
        }

        private void InitUI() {
            BindCombobox();
            InitDates();
            InitHeader();
            InitMetadata();
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

                ValidFromDatePicker.SelectedDate = CreateDate(startingDate.Year, startingDate.Month, config.BillingMonthStart);
                ValidToDatePicker.SelectedDate = CreateDate(endingDate.Year, endingDate.Month, config.BillingMonthEnd);

                TitleTextBox.Text = string.Format($"Umowa za {startingDate.ToString("MMMMMMMMMMMMM")}");
            }
        }

        //TODO: THIS NEEDS TO BE SOMEHWRE ELSE - DATEHELPERS?
        private DateTime CreateDate(int year, int month, int day) {
            string date = string.Format($"{year}/{month}/{day}");
            while (!DateTime.TryParse(date, out _))
                date = string.Format($"{year}/{month}/{--day}");

            return DateTime.Parse(date);
        }

        private void InitMetadata() {
            if (!EditMode || !AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetadata();
            else {
                HandleCreatedMetadata();
                HandleUpdatedMetadata();
            }
        }

        private void HideMetadata() {
            MetaDataGroupBox.Visibility = Visibility.Collapsed;
            this.Height -= 60;
        }

        private void HandleCreatedMetadata() {
            if (string.IsNullOrEmpty(Contract.CreatedBy)) {
                CreatedTextBlock.Visibility = Visibility.Collapsed;
            }
            CreatedTextBlock.Text = string.Format($"Obiekt stworzony {Contract.CreatedOn} przez {Contract.CreatedBy}");
        }

        private void HandleUpdatedMetadata() {
            if (string.IsNullOrEmpty(Contract.UpdatedBy)) {
                UpdatedTextBlock.Visibility = Visibility.Collapsed;
            }
            UpdatedTextBlock.Text = string.Format($"Obiekt stworzony {Contract.CreatedOn} przez {Contract.CreatedBy}");
        }


        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Contract.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (EditMode) {
                string employee = string.Format($"{Contract.Employee.LastName} {Contract.Employee.FirstName}");
                EmployeeCombobox.ItemsSource = new Dictionary<int, string>() { { Contract.Employee.Id, employee } };
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

        }

        private void EditPayment_Click(object sender, RoutedEventArgs e) {

        }

        private void RemovePayment_Click(object sender, RoutedEventArgs e) {

        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    //await _handler.UpdateAsync(Employee.Id, Employee);
                    //await Bufor.FlushBuforsAsync(Employee.Id);
                } else {
                    //Employee created = await _handler.CreateAsync(Employee);
                    //await Bufor.FlushBuforsAsync(created.Id);
                }
                this.Close();
            }
        }
    }
}
