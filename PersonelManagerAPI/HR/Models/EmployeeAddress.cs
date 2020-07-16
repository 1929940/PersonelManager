using API.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public class EmployeeAddress : AddressEntity {
        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
