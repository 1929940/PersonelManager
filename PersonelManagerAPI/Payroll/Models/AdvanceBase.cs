using API.Core.Models;
using System;

namespace API.Payroll.Models {
    public class AdvanceBase : BaseEntity {
        public int WorkedHours { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }
    }
}
