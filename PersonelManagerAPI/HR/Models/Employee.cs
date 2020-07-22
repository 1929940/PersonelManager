using API.Payroll.Models;
using System.Collections.Generic;

namespace API.HR.Models {
    public class Employee : EmployeeBase {
        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Permit> Permits { get; set; }
        public virtual ICollection<Passport> Passports { get; set; }
        public virtual ICollection<Visa> Visas { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<MedicalCheckup> MedicalCheckups { get; set; }
        public virtual ICollection<SafetyTraining> SafetyTrainings { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<EmployeeHistory> History { get; set; }
    }
}
