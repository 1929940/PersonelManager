using API.Core.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public abstract class PersonelDocumentEntity : DocumentEntity{
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
    }
}