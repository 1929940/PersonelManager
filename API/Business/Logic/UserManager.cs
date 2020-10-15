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

/*

public static void UpdateWithDTO(DocumentDTO dto, ref PersonelDocumentEntity document) {
    document.Title = dto.Title;
    document.Number = dto.Number;
    document.IssuedBy = dto.IssuedBy;
    document.ValidFrom = dto.ValidFrom;
    document.ValidTo = dto.ValidTo;
    document.EmployeeId = dto.Employee.Id;

    CopyTags(dto, ref document);
}
*/

        /*public static DocumentDTO CreateDTO(PersonelDocumentEntity document) {
            DocumentDTO dto = new DocumentDTO() {
                Id = document.Id,
                Title = document.Title,
                Number = document.Number,
                IssuedBy = document.IssuedBy,
                ValidFrom = document.ValidFrom,
                ValidTo = document.ValidTo,
                Employee = EmployeeManager.CreateSimplifiedDTO(document.Employee)
            };
            CopyTags(document, ref dto);
            return dto;
        }
        */
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



