using API.Core.Models;

namespace API.Payroll.Models {
    public class ContractBase : DocumentEntity {
        //TODO: CAN I CONVERT THIS TO MONEY?
        public decimal Value { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }
        public bool IsRealized { get; set; }
    }
}
