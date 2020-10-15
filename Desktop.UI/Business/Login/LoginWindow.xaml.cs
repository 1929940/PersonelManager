using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;
using PersonalManagerDesktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Desktop.UI.Business.Login {
    public partial class LoginWindow : Window {

        public LoginWindow() {
            InitializeComponent();

            //This needs local memory, perhaps to a file? or xml file? 
            ServerConnectionData.Url = @"https://localhost:44345";


            LoginFrame.Navigate(new LoginPage(LoginFrame, string.Empty));
        }

        public static void StartMainWindow() {
            MainWindow main = new MainWindow();
            main.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
