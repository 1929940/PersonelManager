using API.Core.Models;
using Newtonsoft.Json;

namespace API.Business.Models {
    public class Credential : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Hash { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public bool RequestedPasswordReset { get; set; }
    }
}
