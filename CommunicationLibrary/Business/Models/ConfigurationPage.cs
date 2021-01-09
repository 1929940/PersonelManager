using CommunicationAndCommonsLibrary.Core.Models;

namespace CommunicationAndCommonsLibrary.Business.Models {
    public class ConfigurationPage : BaseEntity {
        public int BillingMonthStart { get; set; }
        public int BillingMonthEnd { get; set; }
        public double PercentOfAdvancesAllowed { get; set; }
        public int WarningBeforeMedicalCheckupExpires { get; set; }
        public int WarningBeforeSafetyTrainingExpires { get; set; }
        public int WarningBeforeCertificateExpires { get; set; }
    }
}