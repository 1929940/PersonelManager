namespace API.Business.Models {
    public class UserDTO {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public UserDTO(User user) {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Role = user.Role;
            IsActive = user.IsActive;
        }

        public UserDTO() {
        }
    }
}
