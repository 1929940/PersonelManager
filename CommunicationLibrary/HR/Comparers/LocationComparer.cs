using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.HR.Comparers {
    public class LocationComparer : IEqualityComparer<Location> {
        public bool Equals(Location x, Location y) =>
            x.Name == y.Name &&
            x.Country == y.Country &&
            x.Region == y.Region &&
            x.City == y.City &&
            x.Zip == y.Zip &&
            x.Street == y.Street &&
            x.Number == y.Number;

        public int GetHashCode(Location obj) => base.GetHashCode();
    }
}
