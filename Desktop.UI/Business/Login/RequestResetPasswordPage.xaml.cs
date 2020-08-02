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

namespace Desktop.UI.Business.Login {
    /// <summary>
    /// Interaction logic for RequestResetPasswordPage.xaml
    /// </summary>
    public partial class RequestResetPasswordPage : Page {

        public EventHandler ResetPasswordEvent;

        public RequestResetPasswordPage() {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e) {
            ResetPasswordEvent(this, EventArgs.Empty);
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            ResetPasswordEvent(this, EventArgs.Empty);
        }
    }
}
