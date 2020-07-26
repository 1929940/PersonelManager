using CommunicationLibrary.HR.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.HR.Comparers {
    public class EmployeeComparer : IEqualityComparer<Employee> {
        public bool Equals(Employee x, Employee y) =>
            x.FirstName == y.FirstName &&
            x.LastName == y.LastName &&
            x.DateOfBirth == y.DateOfBirth &&
            x.Pesel == y.Pesel &&
            x.Nationality == y.Nationality &&
            x.FatherName == y.FatherName &&
            x.MotherName == y.MotherName &&
            x.IsArchived == y.IsArchived &&
            x.Profession == y.Profession &&
            x.PhoneNo == y.PhoneNo &&
            x.ForemanId == y.ForemanId &&
            x.ForemanFullName == y.ForemanFullName &&
            x.LocationId == y.LocationId &&
            x.LocationName == y.LocationName &&
            x.Country == y.Country &&
            x.Region == y.Region &&
            x.City == y.City &&
            x.Zip == y.Zip &&
            x.Street == y.Street &&
            x.Number == y.Number;

        public int GetHashCode(Employee obj) => base.GetHashCode();
    }
}

