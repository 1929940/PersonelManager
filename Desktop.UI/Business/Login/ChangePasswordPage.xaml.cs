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
    public partial class ChangePasswordPage : Page {

        public EventHandler<LoginEventArgs> ChangePasswordEvent;

        public ChangePasswordPage() {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password != PasswordBox2.Password)
                return;


            LoginEventArgs args = new LoginEventArgs() {
                Password = PasswordBox.Password,
                PasswordRepeat = PasswordBox2.Password
            };

            ChangePasswordEvent(this, args);
        }
    }
}
