using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Advance : BaseEntity {
        public int WorkedHours { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Contract Contract { get; set; }
    }
}
