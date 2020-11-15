using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System;

namespace CommunicationLibrary.Payroll.Models {
    public class Payment : BaseEntity{
        public ContractSimplified Contract { get; set; }
        public EmployeeSimplified Employee { get; set; }
        public DateTime? PaidOn { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public bool IsRealized { get; set; }
    }
}
