using API.Core.Models;
using API.HR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Payroll.Models {
    public class Salary : BaseEntity {

        public DateTime PaidOn { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal TaxAmount { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
