using System.ComponentModel.DataAnnotations;
namespace API.Business.Models {
    public class AuthenticationRequest {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
