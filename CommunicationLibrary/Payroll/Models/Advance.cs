using CommunicationAndCommonsLibrary.Core.Models;
using CommunicationAndCommonsLibrary.HR.Models;
using System;

namespace CommunicationAndCommonsLibrary.Payroll.Models {
    public class Advance : BaseEntity{
        public ContractSimplified Contract { get; set; }
        public EmployeeSimplified Employee { get; set; }
        public int WorkedHours { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }

        public Advance() {
            Contract = new ContractSimplified();
            Employee = new EmployeeSimplified();
        }
    }
}
