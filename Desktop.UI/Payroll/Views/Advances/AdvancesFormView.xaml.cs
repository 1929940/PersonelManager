using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using Desktop.UI.Core.Bufor;
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

            //InitializeComponent();
            //InitHeader();
            //SetDataContext();
            //BindCombobox();
            //MetadataHelper.Init(this, EditMode, Advance);

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

            //SetDataContext(doc);
            //BindCombobox();
            //MetadataHelper.Init(this, EditMode, Advance);

        }

        private void InitUI() {
            //InitPaymentSection();
            BindCombobox();
            //InitDates();
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
                ContractCombobox.ItemsSource = ViewHelper.GetCurrentContractHeader(Advance);
                ContractCombobox.SelectedIndex = 0;
                ContractCombobox.IsEnabled = false;
            } else {
                ContractCombobox.ItemsSource = ViewHelper.GetContractHeaders();
                ContractCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Advance.Contract.Id, ContractCombobox);
            }
        }

        private void WorkedTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void AmountTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void ConfirmAdvanceButton_Click(object sender, RoutedEventArgs e) {
            Advance.PaidOn = PaidOnDatePicker.SelectedDate;
            InitConfirmSection();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {

        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            var handler = new CommunicationLibrary.HR.Requests.EmployeeRequestHandler();

            var employees = handler.GetEmployeeHeaders();
            var employeesAsync = await handler.GetEmployeeHeadersAsync();

            var headers = _contractHandler.GetContractHeaders();
            var headersAsync = await _contractHandler.GetContractHeadersAsync();

            var advData = _contractHandler.GetContractAdvanceData(Advance.Contract.Id);
            var advDataAsync = await _contractHandler.GetContractAdvanceDataAsync(Advance.Contract.Id);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            if (IsReadOnly && !AuthorizationHelper.Authorize(Enums.Roles.Administrator)) {
                ControlsHelper.DisableControls(this, new string[] { "CloseButton" });
            }
        }

        private void ContractCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Advance.Contract.Id = (int)ContractCombobox.SelectedValue;
            AdvanceContractData = _contractHandler.GetContractAdvanceData(Advance.Contract.Id);
            AdvanceDataGroupBox.DataContext = AdvanceContractData;
        }
    }
}
