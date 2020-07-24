using API.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public abstract class PersonelDocumentEntity : DocumentEntity{
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Employee Employee { get; set; }
    }
}