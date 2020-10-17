using CommunicationLibrary.HR.Models;
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
using static Desktop.UI.Core.Helpers.Enums;

namespace Desktop.UI.HR.Views.Absences {
    /// <summary>
    /// Interaction logic for AbsenceFormView.xaml
    /// </summary>
    public partial class AbsenceFormView : Window {

        public string[] Types { get => Enum.GetNames(typeof(AbsenceTypes)); }
        public Leave Leave { get; set; }


        public AbsenceFormView() {
            Leave = new Leave() {
                From = DateTime.Today
            };

            this.DataContext = Leave;
            InitializeComponent();
            InitializeComboboxes();

            HeaderText.Text = "Dodaj Nieobecność";
            AddButton.Visibility = Visibility.Visible;

            HideMetaDataRows();
        }

        public AbsenceFormView(Leave leave) {
            Leave = leave;

            this.DataContext = Leave;
            InitializeComponent();
            InitializeComboboxes();

            HeaderText.Text = "Modyfikuj Nieobecność";
            UpdateButton.Visibility = Visibility.Visible;

            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }

        private void InitializeComboboxes() {
            TypeCombobox.ItemsSource = Types;
            AssignValueToCombobox();
        }

        private void AssignValueToCombobox() {
            int selectedIndex = 0;
            if (!string.IsNullOrEmpty(Leave.Type))
                selectedIndex = TypeCombobox.ItemsSource.OfType<string>().ToList().IndexOf(Leave.Type);
            TypeCombobox.SelectedIndex = selectedIndex;
        }



        private void TypeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Leave.Type = TypeCombobox.SelectedValue as string;
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }


        //TODO: These dialogboxes need to signal that data will be saved on saving employee
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Save()) {
                //await _handler.UpdateAsync(User.Id, User);
                this.Close();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Save()) {
                //await _handler.CreateAsync(User);
                this.Close();
            }
        }

        private void HideMetaDataRows() {
            CreatedRow.Height = new GridLength(0);
            UpdatedRow.Height = new GridLength(0);
            this.Height -= 50;
        }
    }
}
