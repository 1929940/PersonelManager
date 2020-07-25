using CommunicationLibrary.Core.Models;
using System;

namespace CommunicationLibrary.Payroll.Models {
    public class Payment : BaseEntity{
        public ContractSimplified Contract { get; set; }
        public DateTime? PaidOn { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
    }
}
