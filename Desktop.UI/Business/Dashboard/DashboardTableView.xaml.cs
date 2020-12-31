using CommunicationLibrary.Business.Requests;
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

namespace Desktop.UI.Business.Dashboard {
    /// <summary>
    /// Interaction logic for DashboardTableView.xaml
    /// </summary>
    public partial class DashboardTableView : Page {
        private readonly DashboardRequestHandler _handler;

        public DashboardTableView() {
            _handler = new DashboardRequestHandler();

            InitializeComponent();
            DataGrid.ItemsSource = _handler.GetDashboard(DateTime.Today.AddDays(-230), DateTime.Today.AddDays(30));
        }
    }
}
