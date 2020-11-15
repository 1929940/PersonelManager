using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Models {
    public class Contract : DocumentEntity {
        //TODO: RENAME VALUE TO VALUEGROSS
        public decimal Value { get; set; }
        public decimal ValueNetto { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }
        public bool IsRealized { get; set; }
        public EmployeeSimplified Employee { get; set; }

        //TODO: IS THIS NEEDED? YES BUT NEEDS TO BE REPLACED
        public Payment Payment { get; set; }
        public IEnumerable<Advance> Advances { get; set; }

        public Contract() {
            Employee = new EmployeeSimplified();
        }
    }
}
