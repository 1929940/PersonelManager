using API.HR.Models;
using System.Collections.Generic;

namespace API.Payroll.Models {
    public class ContractDTO : ContractBase {
        public EmployeeSimplifiedDTO Employee {get; set;}
        public decimal Paymentvalue { get; set; }
        public decimal AdvancesTotalValue { get; set; }
        public decimal NettoValue { get; set; }
        public decimal TaxValue { get; set; }
    }
}
