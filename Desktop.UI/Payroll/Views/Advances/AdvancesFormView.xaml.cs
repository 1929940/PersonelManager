using CommunicationAndCommonsLibrary.Business.Logic;
using CommunicationAndCommonsLibrary.Business.Models;
using CommunicationAndCommonsLibrary.Core.Bufor;
using CommunicationAndCommonsLibrary.Payroll.Models;
using CommunicationAndCommonsLibrary.Payroll.Requests;
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

namespace Desktop.UI.Payroll.Views.Advances {
    /// <summary>
    /// Interaction logic for AdvancesFormView.xaml
    /// </summary>
    public partial class AdvancesFormView : Window {

        public Advance Advance { get; set; }
        public ContractAdvanceData AdvanceContractData { get; set; }
        public decimal AdvanceLimit { get; set; }
        public bool EditMode { get; set; }
        public Bufor<Advance> Bufor { get; set; }
        public bool IsReadOnly => Advance.PaidOn != null;
        public bool UseBufor { get => Bufor != null; }
        private readonly AdvanceRequestHandler _advanceHandler;
        private readonly ContractRequestHandler _contractHandler;

        public AdvancesFormView(out Advance advance, Bufor<Advance> bufor = null) {
            _advanceHandler = new AdvanceRequestHandler();
            _contractHandler = new ContractRequestHandler();
            Bufor = bufor;

            Advance = new Advance();
            this.DataContext = Advance;

            InitializeComponent();
            InitUI();

            advance = Advance;
        }

        public AdvancesFormView(int id) {
            EditMode = true;
            _advanceHandler = new AdvanceRequestHandler();
            _contractHandler = new ContractRequestHandler();

            Advance = _advanceHandler.Get(id);
            this.DataContext = Advance;

            InitializeComponent();
            InitUI();
        }

        private void InitUI() {
            BindCombobox();
            InitHeader();
            InitConfirmSection();
            MetadataHelper.Init(this, EditMode, Advance);
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Wniosek Zaliczkowy";
            } else {
                HeaderText.Text = "Wystaw Wniosek Zaliczkowy";
            }
        }

        private void InitConfirmSection() {
            if (Advance.PaidOn == null) {
                PaidOnDatePicker.SelectedDate = DateTime.Today;
            } else {
                PaidOnDatePicker.SelectedDate = Advance.PaidOn;
                PaidOnDatePicker.Focusable = false;
                PaidOnDatePicker.IsHitTestVisible = false;
                ConfirmAdvanceButton.Visibility = Visibility.Hidden;
            }
        }

        private void BindCombobox() {
            if (EditMode) {
                ContractCombobox.ItemsSource = ViewHelper.ConverToDictionary(Advance);
                ContractCombobox.SelectedIndex = 0;
            } else {
                ContractCombobox.ItemsSource = _contractHandler.GetContractsDictionary();
                ContractCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Advance.Contract.Id, ContractCombobox);
            }
            if (UseBufor || EditMode)
                ContractCombobox.IsEnabled = false;
        }

        private void WorkedTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            CalculateAdvanceLimit();
        }

        private void CalculateAdvanceLimit() {
            decimal value = 0;
            decimal allowedValue = 0;

            if (AdvanceLimitTextbox == null)
                return;

            if (AdvanceContractData != null) {
                value = Advance.WorkedHours * AdvanceContractData.Wage * AdvanceContractData.Modifier - AdvanceContractData.ContractCharges; // minus
                allowedValue = AdvanceContractData.MaximumContractCharges - AdvanceContractData.ContractCharges;

                if (value > allowedValue)
                    value = allowedValue;

                if (value < 0)
                    value = 0;
            }
            AdvanceLimit = value;
            AdvanceLimitTextbox.Text = value.ToString("0.00 PLN");
        }

        private void ConfirmAdvanceButton_Click(object sender, RoutedEventArgs e) {
            Advance.PaidOn = PaidOnDatePicker.SelectedDate;
            InitConfirmSection();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            if (IsReadOnly || DialogHelper.Close())
                this.Close();
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && IsAmountCorrect()) {
                if (EditMode) {
                    if (UseBufor)
                        Bufor.TransactionBufor.Modify(Advance);
                    else if (DialogHelper.Save())
                        await _advanceHandler.UpdateAsync(Advance.Id, Advance);
                } else {
                    if (UseBufor)
                        Bufor.TransactionBufor.Add(Advance);
                    else if (DialogHelper.Save())
                        await _advanceHandler.CreateAsync(Advance);
                }
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            if (IsReadOnly && !ConnectionManager.IsUserAuthorized(Roles.Administrator)) {
                ControlsHelper.DisableControls(this, new string[] { "CloseButton" });
            }
            CalculateAdvanceLimit();
        }

        private void ContractCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Advance.Contract.Id = (int)ContractCombobox.SelectedValue;
            AdvanceContractData = _contractHandler.GetContractAdvanceData(Advance.Contract.Id);
            AdvanceDataGroupBox.DataContext = AdvanceContractData;
        }

        private bool IsAmountCorrect() {
            if (Advance.Amount > AdvanceLimit) {
                AmountWarningLabel.Visibility = Visibility.Visible;
                return false;
            } else {
                AmountWarningLabel.Visibility = Visibility.Hidden;
                return true;
            }
        }
    }
}
