using CommunicationLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.HR.Comparers {
    public class PersonelDocumentComperer :  IEqualityComparer<PersonelDocument> {
        public bool Equals(PersonelDocument x, PersonelDocument y) =>
            x.Title == y.Title &&
            x.Number == y.Number &&
            x.IssuedBy == y.IssuedBy &&
            x.ValidFrom == y.ValidFrom &&
            x.ValidTo == y.ValidTo;

    public int GetHashCode(PersonelDocument obj) => base.GetHashCode();
}
}
