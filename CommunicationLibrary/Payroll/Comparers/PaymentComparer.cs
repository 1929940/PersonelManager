using CommunicationLibrary.Payroll.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Comparers {
    public class PaymentComparer : IEqualityComparer<Payment> {
        public bool Equals(Payment x, Payment y) =>
            x.Contract?.Id == y.Contract?.Id &&
            x.PaidOn == y.PaidOn &&
            x.NetAmount == y.NetAmount &&
            x.GrossAmount == y.GrossAmount;

        public int GetHashCode(Payment obj) => obj.GetHashCode();
    }
}
