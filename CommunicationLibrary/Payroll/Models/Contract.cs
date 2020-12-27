using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Models {
    public class Contract : DocumentEntity {
        //TODO: RENAME VALUE TO VALUEGROSS
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

        //TODO: IS THIS NEEDED? YES BUT NEEDS TO BE REPLACED

        public Contract() {
            Employee = new EmployeeSimplified();
        }
    }
}
