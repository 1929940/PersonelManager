using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Employees;
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

namespace Desktop.UI.HR.Views.Certificates {
    public partial class CertificateFormView : Window {
        public PersonelDocument Document { get; set; }
        public bool UseBufor { get; set; }
        private readonly CertificateRequestHandler _handler;

        public CertificateFormView(out PersonelDocument doc, bool useBufor = false) {
            _handler = new CertificateRequestHandler();
            UseBufor = useBufor;

            InitializeComponent();
            InitializeAddForm();
            SetDataContext();
            BindCombobox();
            HideMetaDataRows();
            doc = Document;
        }

        public CertificateFormView(PersonelDocument doc, bool useBufor = false) {
            UseBufor = useBufor;
            _handler = new CertificateRequestHandler();

            InitializeComponent();
            InitializeEditForm();
            SetDataContext(doc);
            BindCombobox();
            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }


        private void InitializeAddForm() {
            HeaderText.Text = "Dodaj Certyfikat";
            AddButton.Visibility = Visibility.Visible;
        }

        private void InitializeEditForm() {
            HeaderText.Text = "Modyfikuj Certyfikat";
            UpdateButton.Visibility = Visibility.Visible;
        }

        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (UseBufor)
                    EmployeeFormView.CertificateBufor.Add(Document);
                else
                    await _handler.CreateAsync(Document);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (UseBufor)
                    EmployeeFormView.CertificateBufor.Modify(Document);
                else
                    await _handler.UpdateAsync(Document.Id, Document);
                this.Close();
            }
        }


        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private void HideMetaDataRows() {
            CreatedRow.Height = new GridLength(0);
            UpdatedRow.Height = new GridLength(0);
            this.Height -= 50;
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Document.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (UseBufor)
                EmployeeStackPanel.Visibility = Visibility.Collapsed;
            else {
                EmployeeCombobox.ItemsSource = ViewHelper.GetEmployeesDictionary();
                EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Document.Employee.Id, EmployeeCombobox);
            }
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
