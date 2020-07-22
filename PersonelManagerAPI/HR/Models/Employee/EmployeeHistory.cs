using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public class EmployeeHistory : EmployeeHistoryBase {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Employee Employee { get; set; }

        [ForeignKey("Location")]
        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }

        [ForeignKey("Foreman")]
        public int? ForemanId { get; set; }
        public virtual Foreman Foreman { get; set; }

        [ForeignKey("EmployeeAddress")]
        public int? EmployeeAddressId { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
    }
}
