using CommunicationAndCommonsLibrary.Business.Models;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.Business.Comparers {
    public class ConfigurationPageComparer : IEqualityComparer<ConfigurationPage> {
        public bool Equals(ConfigurationPage x, ConfigurationPage y) =>
            x.BillingMonthEnd == y.BillingMonthStart &&
            x.BillingMonthStart == y.BillingMonthStart &&
            x.PercentOfAdvancesAllowed == y.PercentOfAdvancesAllowed &&
            x.WarningBeforeCertificateExpires == y.WarningBeforeCertificateExpires &&
            x.WarningBeforeMedicalCheckupExpires == y.WarningBeforeMedicalCheckupExpires &&
            x.WarningBeforeSafetyTrainingExpires == y.WarningBeforeSafetyTrainingExpires;

        public int GetHashCode(ConfigurationPage obj) => obj.GetHashCode();
    }
}
