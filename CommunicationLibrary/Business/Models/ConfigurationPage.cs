using CommunicationLibrary.Core.Models;

namespace CommunicationLibrary.Business.Models {
    public class ConfigurationPage : BaseEntity {
        public int BillingMonthStart { get; set; }
        public int BillingMonthEnd { get; set; }
        public double PercentOfAdvancesAllowed { get; set; }
        public int MaximumLeaveTimeInDays { get; set; }
        public int WarningBeforeLeaveReachesLimit { get; set; }
        public int WarningBeforeMedicalCheckupExpires { get; set; }
        public int WarningBeforeSafetyTrainingExpires { get; set; }
        public int WarningBeforeCertificateExpires { get; set; }
        public int WarningBeforeVisaExpires { get; set; }
        public int WarningBeforePermitExpires { get; set; }
        public int WarningBeforePassportExpires { get; set; }
    }
}