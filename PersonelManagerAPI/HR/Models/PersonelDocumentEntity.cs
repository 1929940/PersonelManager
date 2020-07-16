using API.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Models {
    public abstract class PersonelDocumentEntity : BaseEntity{
        public string Title { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Number { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}