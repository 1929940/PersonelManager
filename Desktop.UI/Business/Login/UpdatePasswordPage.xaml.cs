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
    public partial class UpdatePasswordPage : Page {

        public EventHandler<LoginEventArgs> ChangePasswordEvent;

        public string Login { get; set; }

        public UpdatePasswordPage() {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e) {
            //if (PasswordBox.Password != PasswordBox2.Password)
            //    return;

            LoginEventArgs args = new LoginEventArgs() {
                Login = Login,
                Password = PasswordBox.Password,
                ConfirmPassword = ConfirmPasswordBox.Password
            };

            ChangePasswordEvent(this, args);
        }
    }
}
