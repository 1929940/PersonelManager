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
using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;

namespace PersonalManagerDesktop {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //TODO: IF WRONG EMAIL ADDRESS CRASH
            //IF WRONG API CRASHED RESPONSE DESERIALIZATION WILL CRASH UI - INTERNAL SERVER ERRROR DOES

            string s1 = "1232";
            string s2 = "QWE";

            Settings.Url = @"https://localhost:44345";

            string en1 = CommunicationLibrary.Core.Logic.PasswordManager.EncryptPassword(s1);
            string en1_1 = CommunicationLibrary.Core.Logic.PasswordManager.EncryptPassword(s1);

            string en2 = CommunicationLibrary.Core.Logic.PasswordManager.EncryptPassword(s2);

            string en1_2 = CommunicationLibrary.Core.Logic.PasswordManager.EncryptPassword(s1);



            var requestHandler = new CommunicationLibrary.Business.Requests.UserRequestHandler();

            var login = requestHandler.Login("Jan.Kowalski@PersonelManager.pl", "1234");
            Settings.Token = login.Token;

            //var createOne = requestHandler.Create(new User() {
            //    Email = "wnuda@wp.pl",
            //    FirstName = "rzeznicki",
            //    LastName = "jan",
            //    IsActive = true,
            //});


            //var login2 = requestHandler.Login("wnuda@wp.pl", "macko15");
            //Settings.Token = login2.Token;

            requestHandler.Update(6, new User() {
                Id = 6,
                Email = "ZIOM@32.pl"
            });

            //Put with no body generates problems

            requestHandler.RequestPasswordReset(1);

            requestHandler.UpdatePassword(1, "Macko");


            requestHandler.UpdatePassword(15, PasswordManager.EncryptPassword("Macko"));


            var login3 = requestHandler.Login("wnuda@wp.pl", "Macko");
            Settings.Token = login3.Token;

            var createAnother = requestHandler.Create(new User() {
                Email = "KOSMOS@ww.pl",
                FirstName = "eloszka",
                LastName = "michalina",
                IsActive = true,
            });

            //var task = Task.Run(async () => await requestHandler.LoginAsync("Jan.Kowalski@PersonelManager.pl", "3026"));
            //var result = task.Result;



            //var getAll = Task.Run(async () => await requestHandler.GetAsync()).Result;

            //var getOne = Task.Run(async () => await requestHandler.GetAsync(1)).Result;

            //var createOne = Task.Run(async () => await requestHandler.CreateAsync(new User() {
            //    Email = "wnuda@macko.eu",
            //    FirstName = "rzeznicki",
            //    LastName = "jan",
            //    IsActive = true,
            //})).Result;

            //Task.Run(async () => await requestHandler.UpdateAsync(5, new User() {
            //    Id = 5,
            //    Email = "ziomeczko@32.pl"
            //})).Wait();

            //Task.Run(async () => await requestHandler.RequestPasswordResetAsync(5)).Wait();

            //Task.Run(async () => await requestHandler.UpdatePasswordAsync(5, "hehe")).Wait();
        }
    }
}
