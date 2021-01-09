using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Core.Bufor;
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

namespace Desktop.UI.HR.Views.SafetyTrainings {
    public partial class SafetyTrainingFormView : Window {

        public bool EditMode { get; set; }
        public PersonelDocument Document { get; set; }
        public Bufor<PersonelDocument> Bufor { get; set; }
        public bool UseBufor { get => Bufor != null; }

        private readonly SafetyTrainingRequestHandler _handler;

        public SafetyTrainingFormView(out PersonelDocument doc, Bufor<PersonelDocument> bufor = null) {
            _handler = new SafetyTrainingRequestHandler();
            Bufor = bufor;

            InitializeComponent();
            InitHeader();
            SetDataContext();
            BindCombobox();
            MetadataHelper.Init(this, EditMode, Document);
            doc = Document;
        }

        public SafetyTrainingFormView(PersonelDocument doc, Bufor<PersonelDocument> bufor = null) {
            Bufor = bufor;
            EditMode = true;
            _handler = new SafetyTrainingRequestHandler();

            InitializeComponent();
            InitHeader();
            SetDataContext(doc);
            BindCombobox();
            MetadataHelper.Init(this, EditMode, Document);
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Szkolenie BHP";
            } else {
                HeaderText.Text = "Dodaj Szkolenie BHP";
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this)) {
                if (EditMode) {
                    if (UseBufor)
                        Bufor.TransactionBufor.Modify(Document);
                    else if (DialogHelper.Save())
                        await _handler.UpdateAsync(Document.Id, Document);
                } else {
                    if (UseBufor)
                        Bufor.TransactionBufor.Add(Document);
                    else if (DialogHelper.Save())
                        await _handler.CreateAsync(Document);
                }
                this.Close();
            }
        }


        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Document.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (UseBufor) {
                HideEmployeeControls();
                ExpandNumberControls();
            } else {
                EmployeeCombobox.ItemsSource = ViewHelper.GetEmployeeHeaders();
                EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Document.Employee.Id, EmployeeCombobox);
            }
        }

        private void HideEmployeeControls() {
            EmployeeLabel.Visibility = Visibility.Collapsed;
            EmployeeCombobox.Visibility = Visibility.Collapsed;
        }
        private void ExpandNumberControls() {
            NumberTextBox.Width = 334;
            NumberLabel.Width = 60;
        }

        private void SetDataContext(PersonelDocument doc = null) {
            if (doc == null)
                Document = new PersonelDocument();
            else if (UseBufor)
                Document = doc;
            else
                Document = _handler.Get(doc.Id);
            this.DataContext = Document;
        }
    }
}