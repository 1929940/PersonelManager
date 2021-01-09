using CommunicationAndCommonsLibrary.Payroll.Models;
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

namespace Desktop.UI.Payroll.Views.Advances {
    /// <summary>
    /// Interaction logic for AdvancesSummaryTable.xaml
    /// </summary>
    public partial class AdvancesSummaryTable : Window {
        public AdvancesSummaryTable(IEnumerable<Advance> advances) {
            InitializeComponent();
            DataGrid.ItemsSource = advances;
        }
    }
}
