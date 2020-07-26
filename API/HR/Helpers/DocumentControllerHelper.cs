using API.Core.DBContext;
using API.HR.Logic;
using API.HR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Helpers {
    public static class DocumentControllerHelper {

        public async static Task<IEnumerable<DocumentDTO>> GetAllDocuments<T>(DbSet<T> set) where T : PersonelDocumentEntity {
            var documents = await set.ToListAsync();
            return documents.Select(x => PersonelDocumentManager.CreateDTO(x));
        }

        public async static Task<DocumentDTO> GetDocument<T>(DbSet<T> set, int id) where T : PersonelDocumentEntity {
            T document = await set.FindAsync(id);
            if (document == null)
                return null;

            return PersonelDocumentManager.CreateDTO(document);
        }

        public async static Task<IEnumerable<DocumentDTO>> GetEmployeesDocuments<T>(DbSet<T> set, int id) where T : PersonelDocumentEntity {
            var documents = await set.Where(x => x.EmployeeId == id).ToListAsync();
            return documents.Select(x => PersonelDocumentManager.CreateDTO(x));
        }

        public async static Task PutDocument<T>(Context context,DbSet<T> set, int id, DocumentDTO dto, string requestAuthor) where T : PersonelDocumentEntity {
            PersonelDocumentEntity document = await set.FindAsync(id);
            PersonelDocumentManager.UpdateWithDTO(dto, ref document);
            PersonelDocumentManager.WriteUpdateTags(requestAuthor, ref document);

            context.Entry(document).State = EntityState.Modified;
            context.Entry(document).Property(x => x.CreatedOn).IsModified = false;
            context.Entry(document).Property(x => x.CreatedBy).IsModified = false;
        }

        public async static Task<DocumentDTO> PostDocument<T>(Context context, DbSet<T> set, DocumentDTO dto, string requestAuthor) where T : PersonelDocumentEntity, new() {
            PersonelDocumentEntity document = new T();
            await context.Employees.FindAsync(dto.Employee.Id);
            PersonelDocumentManager.UpdateWithDTO(dto, ref document);
            PersonelDocumentManager.WriteCreationTags(requestAuthor, ref document);

            set.Add((T)document);

            await context.SaveChangesAsync();

            return PersonelDocumentManager.CreateDTO(document);
        }
    }
}
