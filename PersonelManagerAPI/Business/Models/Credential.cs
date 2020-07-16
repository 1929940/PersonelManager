using API.Core.Models;

namespace API.Business.Models {
    public class Credential : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public bool IsActive { get; set; }
        public bool RequestedPasswordReset { get; set; }
    }
}
