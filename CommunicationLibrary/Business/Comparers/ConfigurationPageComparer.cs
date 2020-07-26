using CommunicationLibrary.Business.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.Business.Comparers {
    public class ConfigurationPageComparer : IEqualityComparer<ConfigurationPage> {
        public bool Equals(ConfigurationPage x, ConfigurationPage y) =>
            x.BillingMonthEnd == y.BillingMonthStart &&
            x.BillingMonthStart == y.BillingMonthStart &&
            x.MaximumLeaveTimeInDays == y.MaximumLeaveTimeInDays &&
            x.PercentOfAdvancesAllowed == y.PercentOfAdvancesAllowed &&
            x.WarningBeforeCertificateExpires == y.WarningBeforeCertificateExpires &&
            x.WarningBeforeLeaveReachesLimit == y.WarningBeforeLeaveReachesLimit &&
            x.WarningBeforeMedicalCheckupExpires == y.WarningBeforeMedicalCheckupExpires &&
            x.WarningBeforeSafetyTrainingExpires == y.WarningBeforeSafetyTrainingExpires;

        public int GetHashCode(ConfigurationPage obj) => obj.GetHashCode();
    }
}
