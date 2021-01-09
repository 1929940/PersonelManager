using CommunicationAndCommonsLibrary.Payroll.Models;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.Payroll.Comparers {
    public class AdvanceComparer : IEqualityComparer<Advance> {
        public bool Equals(Advance x, Advance y) =>
            x.Contract?.Id == y.Contract?.Id &&
            x.PaidOn == y.PaidOn &&
            x.Amount == y.Amount &&
            x.WorkedHours == y.WorkedHours;

        public int GetHashCode(Advance obj) => obj.GetHashCode();
    }
}
