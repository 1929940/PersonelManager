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

namespace Desktop.UI.HR.Views.MedicalCheckups {
    public partial class MedicalCheckupFormView : Window {
        public PersonelDocument Document { get; set; }
        public bool UseBufor { get; set; }
        private readonly MedicalCheckupRequestHandler _handler;

        public MedicalCheckupFormView(out PersonelDocument doc, bool useBufor = false) {
            _handler = new MedicalCheckupRequestHandler();
            UseBufor = useBufor;

            InitializeComponent();
            InitializeAddForm();
            SetDataContext();
            BindCombobox();
            HideMetaDataRows();
            doc = Document;
        }

        public MedicalCheckupFormView(PersonelDocument doc, bool useBufor = false){
            UseBufor = useBufor;
            _handler = new MedicalCheckupRequestHandler();
            InitializeComponent();
            InitializeEditForm();
            SetDataContext(doc);
            BindCombobox();
            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }


        private void InitializeAddForm() {
            HeaderText.Text = "Dodaj Badanie Lekarskie";
            AddButton.Visibility = Visibility.Visible;
        }

        private void InitializeEditForm() {
            HeaderText.Text = "Modyfikuj Badanie Lekarskie";
            UpdateButton.Visibility = Visibility.Visible;
        }

        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (UseBufor)
                    EmployeeFormView.MedicalCheckupBufor.Add(Document);
                else
                    await _handler.CreateAsync(Document);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (UseBufor)
                    EmployeeFormView.MedicalCheckupBufor.Modify(Document);
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
