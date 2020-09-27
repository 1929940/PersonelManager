namespace CommunicationLibrary.Business.Models {
    public class AuthenticationReponse {
        public string Token { get; set; }
        public bool RequestedPasswordReset { get; set; }
    }
}