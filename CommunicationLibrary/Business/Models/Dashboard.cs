using System;

namespace CommunicationLibrary.Business.Models {
    public class Dashboard {
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
        public string MedicalCheckupStatus { get; set; }
        public DateTime? SafetyTrainingExpirationDate { get; set; }
        public string SafetyTrainingStatus { get; set; }
        public DateTime? CertificateExpirationDate { get; set; }
        public string CertificateStatus { get; set; }
    }
}
