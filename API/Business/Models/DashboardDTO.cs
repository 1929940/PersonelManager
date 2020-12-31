using System;

namespace API.Business.Models {
    public class DashboardDTO {
        public string EmployeeFullName { get; set; }
        public string Profession { get; set; }
        public string LocalizationName { get; set; }
        public string ForemanName { get; set; }
        public string ContractNumber { get; set; }
        public decimal ContractTaxValue { get; set; }
        public decimal ContractAdvancesValue { get; set; }
        public decimal ContractPaymentValue { get; set; }
        public DateTime? ContractFrom { get; set; }
        public DateTime? ContractTo { get; set; }
        public DateTime? MedicalCheckupExpirationDate { get; set; }
        public ExpirationWarnings MedicalCheckupStatus { get; set; }
        public DateTime? SafetyTrainingExpirationDate { get; set; }
        public ExpirationWarnings SafetyTrainingStatus { get; set; }
        public DateTime? CertificateExpirationDate { get; set; }
        public ExpirationWarnings CertificateStatus { get; set; }
        public string TypeOfLeave { get; set; }
        public string LeavePeriod { get; set; }
        public ExpirationWarnings LeaveStatus { get; set; }
    }
}
