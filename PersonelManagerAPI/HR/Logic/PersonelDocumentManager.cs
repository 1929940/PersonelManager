using API.Core.Logic;
using API.Core.Models;
using API.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Logic {
    public class PersonelDocumentManager : BaseEntityManager {

        public static DocumentDTO CreateDTO(PersonelDocumentEntity document) {
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

        public static void UpdateWithDTO(DocumentDTO dto, ref PersonelDocumentEntity document) {
            document.Title = dto.Title;
            document.Number = dto.Number;
            document.IssuedBy = dto.IssuedBy;
            document.ValidFrom = dto.ValidFrom;
            document.ValidTo = dto.ValidTo;
            document.EmployeeId = dto.Employee.Id;

            CopyTags(dto, ref document);
        }
    }
}
