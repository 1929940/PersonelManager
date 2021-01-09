using API.Business.Models;
using API.Core.Logic;
using System;

namespace API.Business.Logic {
    public class UserManager : BaseEntityManager {
        public static void UpdateWithDTO(UserDTO dto, ref User user) {
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.Role = dto.Role;
            user.CreatedOn = DateTime.Now;
            user.IsActive = true;
            user.RequestedPasswordReset = true;

            CopyTags(dto, ref user);
        }

        public static UserDTO CreateDTO(User user) {
            UserDTO dto = new UserDTO() {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                IsActive = user.IsActive
            };
            CopyTags(user, ref dto);
            return dto;
        }
    }
}



