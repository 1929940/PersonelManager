using API.Core.Logic;
using API.HR.Models;
using API.Payroll.Models;
using System.Linq;

namespace API.HR.Logic {
    public class EmployeeManager : BaseEntityManager {
        public static EmployeeSimplifiedDTO CreateSimplifiedDTO(Employee employee) => new EmployeeSimplifiedDTO() {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.History.Last().LastName,
            Profession = employee.History.Last().Profession
        };

        public static EmployeeSimplifiedDTO CreateSimplifiedDTO(Contract contract) => new EmployeeSimplifiedDTO() {
            Id = contract.Employee.Id,
            FirstName = contract.Employee.FirstName,
            LastName = contract.Employee.History.Last().LastName,
            Profession = contract.Employee.History.Last().Profession
        };

        public static EmployeeDTO CreateDTO(Employee employee) {
            EmployeeHistory current = employee.History.Last();

            var dto = new EmployeeDTO() {
                FirstName = employee.FirstName,
                LastName = current.LastName,
                DateOfBirth = employee.DateOfBirth,
                Nationality = employee.Nationality,
                FatherName = employee.FatherName,
                MotherName = employee.MotherName,
                IsArchived = employee.IsArchived,
                Pesel = employee.Pesel,
                PhoneNo = current.PhoneNo,
                Profession = current.Profession,
                Country = current.Country,
                Region = current.Region,
                City = current.City,
                Zip = current.Zip,
                Street = current.Street,
                Number = current.Number,
                ForemanId = current.ForemanId,
                ForemanFullName = string.Format(
                    $"{current.Foreman?.FirstName} {current.Foreman?.LastName}"),
                LocationId = current.LocationId,
                LocationName = current.Location?.Name
            };

            CopyTags(employee, ref dto);
            return dto;
        }

        public static void UpdateWithDTO(EmployeeDTO dto, ref Employee employee) {
            employee.FirstName = dto.FirstName;
            employee.DateOfBirth = dto.DateOfBirth;
            employee.FatherName = dto.FatherName;
            employee.MotherName = dto.MotherName;
            employee.Nationality = dto.Nationality;
            employee.Pesel = dto.Pesel;
            employee.IsArchived = dto.IsArchived;

            CopyTags(dto, ref employee);
        }

        public static EmployeeHistory CreateEmployeeHistoryEntry(EmployeeDTO dto, EmployeeHistory current = null) {

            if (! IsEqual(dto, current))
                return new EmployeeHistory() {
                    LastName = dto.LastName,
                    PhoneNo = dto.PhoneNo,
                    Profession = dto.Profession,
                    EmployeeId = dto.Id,
                    ForemanId = (dto.ForemanId == 0) ? null : dto.ForemanId,
                    LocationId = (dto.LocationId == 0) ? null : dto.LocationId,
                    Country = dto.Country,
                    Region = dto.Region,
                    City = dto.City,
                    Zip = dto.Zip,
                    Street = dto.Street,
                    Number = dto.Number,
                };
            return null;
        }

        private static bool IsEqual(EmployeeDTO dto, EmployeeHistory history) =>
            history != null &&
            history.EmployeeId == dto.Id &&
            history.LastName == dto.LastName &&
            history.PhoneNo == dto.PhoneNo &&
            history.Profession == dto.Profession &&
            history.LocationId == dto.LocationId &&
            history.ForemanId == dto.ForemanId &&
            history.Country == dto.Country &&
            history.Region == dto.Region &&
            history.City == dto.City &&
            history.Zip == dto.Zip &&
            history.Street == dto.Street &&
            history.Number == dto.Number;
    }
}
