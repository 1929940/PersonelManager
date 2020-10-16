using CommunicationLibrary.HR.Models;
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

namespace Desktop.UI.HR.Views.Employees.Tabs {
    /// <summary>
    /// Interaction logic for GeneralTab.xaml
    /// </summary>
    public partial class GeneralTab : Page {
        public GeneralTab(Employee employee) {
            InitializeComponent();
            this.DataContext = employee;
        }

        public GeneralTab(Employee employee, bool historyView) {
            InitializeComponent();
            EnableHistoryView();
            this.DataContext = employee;
        }

        private void EnableHistoryView() {
            HistoryComboBox.Visibility = Visibility.Visible;
            HistoryTextBlock.Visibility = Visibility.Visible;
        }
    }
}
