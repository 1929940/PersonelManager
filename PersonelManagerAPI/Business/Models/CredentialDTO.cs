namespace API.Business.Models {
    public class CredentialDTO {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public bool RequestedPasswordReset { get; set; }

        public CredentialDTO(Credential credential) {
            Id = credential.Id;
            FirstName = credential.FirstName;
            LastName = credential.LastName;
            Email = credential.Email;
            Role = credential.Role;
            IsActive = credential.IsActive;
            RequestedPasswordReset = credential.RequestedPasswordReset;
        }
    }
}
