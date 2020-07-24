using API.Core.Models;
using System;

namespace API.Payroll.Models {
    public class PaymentBase : BaseEntity {
        public DateTime? PaidOn { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
    }
}
