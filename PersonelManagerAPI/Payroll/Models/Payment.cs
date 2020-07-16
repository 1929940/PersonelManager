using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Payment : BaseEntity {

        public DateTime PaidOn { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal TaxAmount { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
