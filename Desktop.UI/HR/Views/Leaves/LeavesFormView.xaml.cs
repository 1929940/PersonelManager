using CommunicationAndCommonsLibrary.Core.Bufor;
using CommunicationAndCommonsLibrary.HR.Models;
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

namespace Desktop.UI.HR.Views.Absences {
    public partial class LeavesFormView : Window {

        public bool EditMode { get; set; }
        public string[] Types { get => Enum.GetNames(typeof(AbsenceTypes)); }
        public Leave Leave { get; set; }
        public Bufor<Leave> Bufor { get; set; }


        public LeavesFormView(out Leave leave, Bufor<Leave> bufor) {
            Leave = new Leave();
            Bufor = bufor;

            this.DataContext = Leave;
            InitializeComponent();
            InitializeComboboxes();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Leave);

            leave = Leave;
        }

        public LeavesFormView(Leave leave, Bufor<Leave> bufor) {
            Leave = leave;
            Bufor = bufor;
            EditMode = true;

            this.DataContext = Leave;
            InitializeComponent();
            InitializeComboboxes();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Leave);
        }

        private void InitializeComboboxes() {
            TypeCombobox.ItemsSource = Types;
            AssignValueToCombobox();
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Nieobecność";
            } else {
                HeaderText.Text = "Dodaj Nieobecność";
            }
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

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (EditMode) {
                Bufor.TransactionBufor.Modify(Leave);
            } else {
                Bufor.TransactionBufor.Add(Leave);
            }
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }
    }
}
