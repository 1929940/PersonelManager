using API.Core.Models;
using API.Payroll.Models;
using System;
using System.Collections.Generic;

namespace API.HR.Models {
    public class Employee : BaseEntity {

        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationality { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Permit> Permits { get; set; }
        public virtual ICollection<Passport> Passports { get; set; }
        public virtual ICollection<Visa> Visas { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<MedicalCheckup> MedicalCheckups { get; set; }
        public virtual ICollection<SafetyTraining> SafetyTrainings { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<EmployeeHistory> History { get; set; }

        public bool IsArchived { get; set; }
    }
}
