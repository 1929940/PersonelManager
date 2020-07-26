using CommunicationLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.HR.Comparers {
    public class LeaveComparer : IEqualityComparer<Leave> {
        public bool Equals(Leave x, Leave y) =>
            x.Employee?.Id == y.Employee?.Id &&
            x.Type == y.Type &&
            x.Comment == y.Comment &&
            x.From == y.From &&
            x.To == y.To;

        public int GetHashCode(Leave obj) => base.GetHashCode();
    }
}
