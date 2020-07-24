namespace API.Business.Models {
    public class User : UserBase {
        public string Hash { get; set; }
        public bool RequestedPasswordReset { get; set; }
    }
}
