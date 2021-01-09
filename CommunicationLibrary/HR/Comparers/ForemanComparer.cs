using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.HR.Comparers {
    public class ForemanComparer : IEqualityComparer<Foreman> {
        public bool Equals(Foreman x, Foreman y) =>
            x.FirstName == y.FirstName &&
            x.LastName == y.LastName &&
            x.Mail == y.Mail &&
            x.PhoneNo == y.PhoneNo &&
            x.LocationId == y.LocationId;

        public int GetHashCode(Foreman obj) => base.GetHashCode();
    }
}

