using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Advances : BaseEntity {
        public int WorkedHours { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidOn { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
