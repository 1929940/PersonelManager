using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop.UI.Business.Configuration {
    /// <summary>
    /// Interaction logic for DashboardConfigurationPage.xaml
    /// </summary>
    public partial class ConfigurationView : Page {

        private readonly ConfigurationPageRequestHandler _handler;
        public ConfigurationPage PageData { get; set; }


        public ConfigurationView() {
            _handler = new ConfigurationPageRequestHandler();
            PageData = _handler.Get();

            InitializeComponent();
            this.DataContext = PageData;
        }

        private async void SaveForm_Click(object sender, RoutedEventArgs e) {
            if (ValidationHelper.AreTextboxesValid(this) && DialogHelper.Save()) {
                await _handler.UpdateAsync(PageData.Id, PageData);
            }
        }
    }
}
