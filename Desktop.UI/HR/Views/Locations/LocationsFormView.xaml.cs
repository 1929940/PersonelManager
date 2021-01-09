using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
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
        public bool EditMode { get; set; }

        public LocationsFormView() {
            _handler = new LocationRequestHandler();
            Location = new Location();
            this.DataContext = Location;
            InitializeComponent();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Location);
        }

        public LocationsFormView(int id) {

            EditMode = true;
            _handler = new LocationRequestHandler();
            Location = _handler.Get(id);
            this.DataContext = Location;
            InitializeComponent();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Location);
        }
        private async void AddButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.CreateAsync(Location);
                this.Close();
            }
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(Location.Id, Location);
                this.Close();
            }
        }


        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Lokalizacje";
            } else {
                HeaderText.Text = "Dodaj Lokalizacje";
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _handler.UpdateAsync(Location.Id, Location);
                } else {
                    await _handler.CreateAsync(Location);
                }
                this.Close();
            }
        }
    }
}
