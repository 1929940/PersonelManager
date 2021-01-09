using CommunicationAndCommonsLibrary.Business.Models;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.Business.Comparers {
    public class UserComparer : IEqualityComparer<User> {
        public bool Equals(User x, User y) =>
            x.FirstName == y.FirstName &&
            x.LastName == y.LastName &&
            x.Email == y.Email &&
            x.Role == y.Role &&
            x.IsActive == y.IsActive;

        public int GetHashCode(User obj) => obj.GetHashCode();
    }
}
