using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
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

namespace Desktop.UI.HR.Views.MedicalCheckups {
    /// <summary>
    /// Interaction logic for MedicalCheckupFormView.xaml
    /// </summary>
    public partial class MedicalCheckupFormView : Window {
        public PersonelDocument Document { get; set; }
        private readonly MedicalCheckupRequestHandler _handler;

        public MedicalCheckupFormView() {
            _handler = new MedicalCheckupRequestHandler();
            Document = new PersonelDocument();
            this.DataContext = Document;
            InitializeComponent();
            HeaderText.Text = "Dodaj Badanie Lekarskie";
            AddButton.Visibility = Visibility.Visible;
            BindCombobox();
            HideMetaDataRows();
        }

        public MedicalCheckupFormView(int id) {

            _handler = new MedicalCheckupRequestHandler();
            Document = _handler.Get(id);
            this.DataContext = Document;
            InitializeComponent();
            HeaderText.Text = "Modyfikuj Badanie Lekarskie";
            UpdateButton.Visibility = Visibility.Visible;
            BindCombobox();
            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }
        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(Document);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
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
            EmployeeCombobox.ItemsSource = ViewHelper.GetEmployeesDictionary();
            EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Document.Employee.Id, EmployeeCombobox);
        }
    }
}
