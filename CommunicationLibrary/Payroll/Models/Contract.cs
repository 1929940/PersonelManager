using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Models {
    public class Contract : DocumentEntity {
        public decimal Value { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }
        public bool IsRealized { get; set; }
        public EmployeeSimplified Employee { get; set; }

        //TODO: IS THIS NEEDED?
        public Payment Payment { get; set; }
        public IEnumerable<Advance> Advances { get; set; }
    }
}
