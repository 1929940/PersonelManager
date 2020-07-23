using API.Business.Helpers;
using MailKit.Net.Smtp;
using MimeKit;

namespace API.Business.Logic {
    public class PasswordResetHandler {

        //TODO: Generate PW - generate 4 digits - RETURN
        //Change that pw - this will be done by the controller
        //Once logged with that pw user gets prompt to change pw;
        //


        public static void Sent(AppSecrets secrets, string emailTo, string newPassword) {

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("PersonalManager - NoReply", secrets.EmailAddress));
            mailMessage.To.Add(new MailboxAddress("to name", "1929940@gmail.com"));
            mailMessage.Subject = "Zresetowanie hasła do systemu PersonalManager";
            mailMessage.Body = new TextPart("plain") {
                Text = $"Twoje nowe tymczasowe hasło to: {newPassword}"
            };

            using (var smtpClient = new SmtpClient()) {
                smtpClient.Connect("smtp.gmail.com", 465, true);

                smtpClient.Authenticate(secrets.EmailLogin, secrets.EmailPassword);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

    }
}