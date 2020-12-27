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
        public bool EditMode { get; set; }
        public Bufor<Advance> Bufor { get; set; }
        public bool UseBufor { get => Bufor != null; }
        private readonly AdvanceRequestHandler _handler;

        public AdvancesFormView(out Advance advance, Bufor<Advance> bufor = null) {
            _handler = new AdvanceRequestHandler();
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
            _handler = new AdvanceRequestHandler();

            Advance = _handler.Get(id);
            this.DataContext = Advance;

            InitializeComponent();
            InitUI();

            //SetDataContext(doc);
            //BindCombobox();
            //MetadataHelper.Init(this, EditMode, Advance);

        }

        private void InitUI() {
            //InitPaymentSection();
            //BindCombobox();
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
                ConfirmAdvanceButton.Visibility = Visibility.Hidden;
            }
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

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

        private void SaveButton_Click(object sender, RoutedEventArgs e) {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }
    }
}
