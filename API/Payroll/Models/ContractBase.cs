using API.Core.Models;
using System;

namespace API.Payroll.Models {
    public class ContractBase : DocumentEntity {
        //TODO: CAN I CONVERT THIS TO MONEY?
        public decimal TotalValue { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }
        public DateTime? PaidOn { get; set; }
        public bool IsRealized { get; set; }
    }
}
