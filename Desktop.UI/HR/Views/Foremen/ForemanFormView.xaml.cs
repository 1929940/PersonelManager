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

namespace Desktop.UI.HR.Views.Foremen {
    /// <summary>
    /// Interaction logic for ForemanFormView.xaml
    /// </summary>
    public partial class ForemanFormView : Window {
        public Foreman Foreman { get; set; }

        private readonly ForemanRequestHandler _handler;

        public ForemanFormView() {
            _handler = new ForemanRequestHandler();
            Foreman = new Foreman();
            this.DataContext = Foreman;
            InitializeComponent();
            BindCombobox();
            HeaderText.Text = "Dodaj Lokalizacje";
            AddButton.Visibility = Visibility.Visible;
            HideMetaDataRows();
        }

        public ForemanFormView(int id) {

            _handler = new ForemanRequestHandler();
            Foreman = _handler.Get(id);
            this.DataContext = Foreman;
            InitializeComponent();
            BindCombobox();
            HeaderText.Text = "Modyfikuj Lokalizacje";
            UpdateButton.Visibility = Visibility.Visible;
            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }
        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(Foreman);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(Foreman.Id, Foreman);
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

        private void BindCombobox() {
            LocationComboBox.ItemsSource = ViewHelper.GetLocations();
            LocationComboBox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Foreman.LocationId, LocationComboBox);
        }

        private void LocationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Foreman.LocationId = (int)LocationComboBox.SelectedValue;
        }
    }
}
