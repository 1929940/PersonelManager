using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Models {
    public class Contract : DocumentEntity {
        public decimal TotalValue { get; set; }
        public decimal NettoValue { get; set; }
        public decimal TaxValue { get; set; }
        public decimal PaymentValue { get; set; }
        public decimal AdvancesTotalValue { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }
        public bool IsRealized { get; set; }
        public EmployeeSimplified Employee { get; set; }
        public DateTime? PaidOn { get; set; }
        public IEnumerable<Advance> Advances { get; set; }

        public Contract() {
            Employee = new EmployeeSimplified();
        }
    }
}
