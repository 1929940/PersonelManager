namespace API.Business.Models {
    public class AuthenticationReponse {
        public string Token { get; set; }
        public bool RequestedPasswordReset { get; set; }
        public string Role { get; set; }
    }
}
