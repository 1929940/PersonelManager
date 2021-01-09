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

namespace Desktop.UI.HR.Views.Foremen {
    /// <summary>
    /// Interaction logic for ForemanFormView.xaml
    /// </summary>
    public partial class ForemanFormView : Window {

        public bool EditMode { get; set; }
        public Foreman Foreman { get; set; }
        private readonly ForemanRequestHandler _handler;

        public ForemanFormView() {
            _handler = new ForemanRequestHandler();
            Foreman = new Foreman();
            this.DataContext = Foreman;
            InitializeComponent();
            BindCombobox();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Foreman);
        }

        public ForemanFormView(int id) {
            _handler = new ForemanRequestHandler();
            EditMode = true;
            Foreman = _handler.Get(id);
            this.DataContext = Foreman;
            InitializeComponent();
            BindCombobox();
            InitHeader();
            MetadataHelper.Init(this, EditMode, Foreman);
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Mistrza";
            } else {
                HeaderText.Text = "Dodaj Mistrza";
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private void BindCombobox() {
            LocationComboBox.ItemsSource = ViewHelper.GetLocations();
            LocationComboBox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Foreman.LocationId, LocationComboBox);
        }

        private void LocationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Foreman.LocationId = (int)LocationComboBox.SelectedValue;
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _handler.UpdateAsync(Foreman.Id, Foreman);
                } else {
                    await _handler.CreateAsync(Foreman);
                }
                this.Close();
            }
        }
    }
}
