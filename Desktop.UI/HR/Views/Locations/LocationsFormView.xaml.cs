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

namespace Desktop.UI.HR.Views.Locations {
    /// <summary>
    /// Interaction logic for LocationsFormView.xaml
    /// </summary>
    public partial class LocationsFormView : Window {

        public Location Location { get; set; }
        private readonly LocationRequestHandler _handler;

        public LocationsFormView() {
            _handler = new LocationRequestHandler();
            Location = new Location();
            this.DataContext = Location;
            InitializeComponent();
            HeaderText.Text = "Dodaj Lokalizacje";
            AddButton.Visibility = Visibility.Visible;
            HideMetaDataRows();
        }

        public LocationsFormView(int id) {

            _handler = new LocationRequestHandler();
            Location = _handler.Get(id);
            this.DataContext = Location;
            InitializeComponent();
            HeaderText.Text = "Modyfikuj Lokalizacje";
            UpdateButton.Visibility = Visibility.Visible;
            if (!AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideMetaDataRows();
        }
        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ValidationHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(Location);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ValidationHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(Location.Id, Location);
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
    }
}
