using API.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Logic {
    public class EmployeeManager {
        public static EmployeeSimplifiedDTO CreateSimplifiedDTO(Employee employee) => new EmployeeSimplifiedDTO() {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.History.FirstOrDefault().LastName,
            Profession = employee.History.FirstOrDefault().Profession
        };

    }
}
