using CommunicationLibrary.Core.Models;
using System;

namespace CommunicationLibrary.HR.Models {
    public class Employee : BaseEntity {
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationality { get; set; }
        public bool IsArchived { get; set; }

        public string LastName { get; set; }
        public string Profession { get; set; }
        public string PhoneNo { get; set; }

        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public int? ForemanId { get; set; }
        public string ForemanFullName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
