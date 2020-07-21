using API.Core.Models;
using System;

namespace API.Core.Logic {
    public abstract class BaseEntityManager {
        protected static void CopyTags<T>(BaseEntity input, ref T output) where T : BaseEntity {
            output.Id = input.Id;
            output.CreatedBy = input.CreatedBy;
            output.CreatedOn = input.CreatedOn;
            output.UpdatedBy = input.UpdatedBy;
            output.UpdatedOn = input.UpdatedOn;
        }

        public static void WriteCreationTags<T>(string author, ref T output) where T : BaseEntity {
            output.CreatedBy = author;
            output.CreatedOn = DateTime.Now;
            output.UpdatedBy = null;
            output.UpdatedOn = null;
        }

        public static void WriteUpdateTags<T>(string author, ref T output) where T : BaseEntity {
            output.UpdatedBy = author;
            output.UpdatedOn = DateTime.Now;
        }
    }
}
