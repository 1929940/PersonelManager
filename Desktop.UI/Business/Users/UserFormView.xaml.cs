using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.Core.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop.UI.Business.Users {
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserFormView : Window {

        public User User { get; set; }
        public bool EditMode { get; set; }
        private readonly UserRequestHandler _handler;

        public UserFormView() {
            _handler = new UserRequestHandler();
            User = new User() { IsActive = true };
            this.DataContext = User;
            InitializeComponent();
            InitUI();
        }

        public UserFormView(int id) {
            _handler = new UserRequestHandler();
            EditMode = true;
            User = _handler.Get(id);

            this.DataContext = User;
            InitializeComponent();
            InitUI();
        }

        private void InitUI() {
            InitHeader();
            InitRoleComboBox();
            MetadataHelper.Init(this, EditMode, User);
        }

        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Użytkownika";
            } else {
                HeaderText.Text = "Dodaj Użytkownika";
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private string[] GetRoles() => Enum.GetNames(typeof(Enums.Roles));

        private void InitRoleComboBox() {
            RoleComboBox.ItemsSource = GetRoles();
            AssignValueToCombobox();
        }

        private void AssignValueToCombobox() {
            int selectedIndex = 0;
            if (!string.IsNullOrEmpty(User.Role))
                selectedIndex = RoleComboBox.ItemsSource.OfType<string>().ToList().IndexOf(User.Role);
            RoleComboBox.SelectedIndex = selectedIndex;
        }

        private void RoleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            User.Role = RoleComboBox.SelectedValue as string;
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                if (EditMode) {
                    await _handler.UpdateAsync(User.Id, User);
                } else {
                    await _handler.CreateAsync(User);
                }
                this.Close();
            }
        }
    }
}
