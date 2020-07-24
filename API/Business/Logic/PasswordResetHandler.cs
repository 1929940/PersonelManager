using API.Business.Helpers;
using MailKit.Net.Smtp;
using MimeKit;
using System;
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

        public static async Task Sent(AppSettings appSettings, string emailTo, string newPassword) {

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("PersonalManager - NoReply", appSettings.EmailAddress));
            mailMessage.To.Add(new MailboxAddress("To", emailTo));
            mailMessage.Subject = "Zresetowanie hasła do systemu PersonalManager";

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
    }
}