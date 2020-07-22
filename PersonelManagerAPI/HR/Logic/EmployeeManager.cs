using API.Core.Logic;
using API.HR.Models;
using System.Linq;

namespace API.HR.Logic {
    public class EmployeeManager : BaseEntityManager {
        public static EmployeeSimplifiedDTO CreateSimplifiedDTO(Employee employee) => new EmployeeSimplifiedDTO() {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.History.FirstOrDefault().LastName,
            Profession = employee.History.FirstOrDefault().Profession
        };

    }
}
