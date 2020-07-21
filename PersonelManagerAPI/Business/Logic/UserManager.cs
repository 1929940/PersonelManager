using API.Business.Models;
using System;

namespace API.Business.Logic {
    public class UserManager {
        public static User CreateUser(UserDTO dto) => new User() {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.LastName,
            Role = dto.Role,
            CreatedOn = DateTime.Now,
            IsActive = true,
            RequestedPasswordReset = true,
        };


        public static UserDTO CreateDto(User user) => new UserDTO() {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Role = user.Role,
            IsActive = user.IsActive
        };
    }
}
