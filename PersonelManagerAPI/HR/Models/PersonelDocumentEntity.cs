using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public abstract class PersonelDocumentEntity : BaseEntity{
        public string Title { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Number { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}