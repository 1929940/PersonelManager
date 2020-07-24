using Microsoft.Extensions.Configuration;

namespace API.Business.Helpers {
    public class AppSettingsHelper {
        public static bool IsSecretsEmpty(IConfiguration configuration) {
            string emailPassword = configuration["AppSecrets:EmailPassword"];
            string emailLogin = configuration["AppSecrets:EmailLogin"];
            string emailAddress = configuration["AppSecrets:EmailAddress"];
            string authSecret = configuration["AppSecrets:AuthSecret"];
            string issuer = configuration["AppSecrets:Issuer"];

            return string.IsNullOrEmpty(emailPassword) || string.IsNullOrEmpty(emailLogin) || string.IsNullOrEmpty(emailAddress)
                || string.IsNullOrEmpty(authSecret) || string.IsNullOrEmpty(issuer);
        }
    }
}
