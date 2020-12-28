using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.Payroll.Helpers;
using Desktop.UI.Payroll.Views.Advances;
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
        private readonly ContractRequestHandler _contractHandler;
        private readonly AdvanceRequestHandler _advanceHandler;
        public bool EditMode { get; set; }
        public ContractBufor Bufor { get; set; }
        public bool IsReadOnly => Contract.PaidOn != null;
        public DateTime PaidOn { get; set; }

        public ContractFormView() {
            _contractHandler = new ContractRequestHandler();
            _advanceHandler = new AdvanceRequestHandler();
            Contract = new Contract();
            Bufor = new ContractBufor();
            this.DataContext = Contract;
            InitializeComponent();

            InitUI();
        }

        public ContractFormView(int id) {
            EditMode = true;
            _contractHandler = new ContractRequestHandler();
            _advanceHandler = new AdvanceRequestHandler();
            Contract = _contractHandler.Get(id);
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

            if (IsReadOnly) {
                if (PaidTextBox != null) {
                    ToBePaidStackPanel.Visibility = Visibility.Collapsed;
                    this.Height -= 20;
                    PaidTextBox.Text = paymentValue.ToString("0.00 PLN");
                    PaidOnDatePicker.SelectedDate = Contract.PaidOn;
                }
            } else {
                if (ToBePaidTextBox != null && PaidTextBox != null && PaidOnDatePicker != null) {
                    ToBePaidTextBox.Text = paymentValue.ToString("0.00 PLN");
                    PaidTextBox.Text = "0.00 PLN";
                    PaidOnDatePicker.SelectedDate = DateTime.Today;
                }
            }
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Contract.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (EditMode) {
                EmployeeCombobox.ItemsSource = ViewHelper.GetCurrentEmployeeHeader(Contract.Employee);
                EmployeeCombobox.SelectedIndex = 0;
                EmployeeCombobox.IsEnabled = false;
            } else {
                EmployeeCombobox.ItemsSource = ViewHelper.GetEmployeeHeaders();
                EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Contract.Employee.Id, EmployeeCombobox);
            }
        }

        private async Task InitAdvances() {
            if (Contract.Advances == null) {
                if (Contract.Id > 0) {
                    Contract.Advances = await _advanceHandler.GetContractAdvancesAsync(Contract.Id);
                } else {
                    Contract.Advances = new List<Advance>();
                }
            }
        }

        private async void AddAdvance_Click(object sender, RoutedEventArgs e) {
            AdvancesFormView form = new AdvancesFormView(out Advance advance, Bufor.AdvancesBufor);
            form.ShowDialog();

            Bufor.AdvancesBufor.TransactionBufor.Add(advance);

            await InitAdvances();

            List<Advance> updatedAdvances = Contract.Advances.ToList();
            updatedAdvances.Add(advance);
            Contract.Advances = updatedAdvances;

            Contract.AdvancesTotalValue = Contract.Advances.Where(x => x.PaidOn != null).Sum(x => x.Amount);
            AdvancesSumTextBox.Text = Contract.AdvancesTotalValue.ToString("0.00 PLN");
        }

        private async void ShowAdvances_Click(object sender, RoutedEventArgs e) {
            //if no list get it
            await InitAdvances();

            //show advances: {Amount, Worked, PaidOn} - Create new window just for this - Only show
        }

        //TODO: CHANGE TO READONLY
        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            if (Contract.IsRealized || DialogHelper.Close())
                this.Close();
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _contractHandler.UpdateAsync(Contract.Id, Contract);
                    await Bufor.FlushBuforsAsync(Contract.Id);
                } else {
                    Contract created = await _contractHandler.CreateAsync(Contract);
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

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            if (Contract.IsRealized && !AuthorizationHelper.Authorize(Enums.Roles.Administrator)) {
                ControlsHelper.DisableControls(this, new string[] { "ShowAdvances", "CloseButton" });
            }
        }
    }
}
