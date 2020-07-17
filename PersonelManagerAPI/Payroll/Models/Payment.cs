using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Payment : BaseEntity {

        public DateTime? PaidOn { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
