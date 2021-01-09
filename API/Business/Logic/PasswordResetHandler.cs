using API.Business.Helpers;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Business.Logic {
    public class PasswordResetHandler {

        public static string GeneratePassword(int noDigits) {
            Random rng = new Random();

            string password = string.Empty;

            for (int i = 0; i < noDigits; i++) {
                password += rng.Next(0, 10);
            }
            return password;
        }

        public static string EncryptPassword(string input) {
            using (var sha256 = new SHA256Managed()) {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", string.Empty);
            }
        }

        //TODO: Try catch, return bool, if false dont do anything?
        public static async Task SentEmail(AppSettings appSettings, string emailTo, string newPassword) {
            if (!IsValidEmailAddress(emailTo))
                return;

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("PersonalManager - NoReply", appSettings.EmailAddress));
            mailMessage.To.Add(new MailboxAddress("To", emailTo));
            mailMessage.Subject = "Nadanie hasła do systemu PersonalManager";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"Twoje jednorazowe hasło to: <b>{newPassword}</b> <br/><br/>Po zalogowaniu wymagane bedzie podanie nowego hasła.";
            bodyBuilder.TextBody = "Does this matter?";
            mailMessage.Body = bodyBuilder.ToMessageBody();

            using (var smtpClient = new SmtpClient()) {
                smtpClient.Connect("smtp.gmail.com", 465, true);

                smtpClient.Authenticate(appSettings.EmailLogin, appSettings.EmailPassword);
                await smtpClient.SendAsync(mailMessage);
                smtpClient.Disconnect(true);
            }
        }
        private static bool IsValidEmailAddress(string address) => address != null && new EmailAddressAttribute().IsValid(address);
    }
}