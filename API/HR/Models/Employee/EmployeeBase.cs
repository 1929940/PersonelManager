using API.Core.Models;
using System;

namespace API.HR.Models {
    public class EmployeeBase : BaseEntity {
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationality { get; set; }
        public bool IsArchived { get; set; }
    }
}
