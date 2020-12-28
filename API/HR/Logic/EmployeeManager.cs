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
            return CreateDTO(employee, employee.History.Last());
        }

        public static EmployeeDTO CreateDTO(Employee employee, EmployeeHistory history) {
            var dto = CreateBaseDTO(employee, history);

            CopyTags(employee, ref dto);
            return dto;
        }

        public static EmployeeDTO CreateHistoryDTO(Employee employee, EmployeeHistory history) {
            var dto = CreateBaseDTO(employee, history);

            CopyTags(history, ref dto);
            return dto;
        }

        public static EmployeeHeader CreateEmployeeHeader(Employee employee) {
            return new EmployeeHeader() {
                Id = employee.Id,
                DisplayValue = string.Format($"{employee.History.Last().LastName} {employee.FirstName}")
            };
        }

        private static EmployeeDTO CreateBaseDTO(Employee employee, EmployeeHistory history) =>
            new EmployeeDTO() {
                FirstName = employee.FirstName,
                LastName = history.LastName,
                DateOfBirth = employee.DateOfBirth,
                Nationality = employee.Nationality,
                FatherName = employee.FatherName,
                MotherName = employee.MotherName,
                IsArchived = employee.IsArchived,
                Pesel = employee.Pesel,
                PhoneNo = history.PhoneNo,
                Profession = history.Profession,
                Country = history.Country,
                Region = history.Region,
                City = history.City,
                Zip = history.Zip,
                Street = history.Street,
                Number = history.Number,
                ForemanId = history.ForemanId,
                ForemanFullName = string.Format(
                    $"{history.Foreman?.FirstName} {history.Foreman?.LastName}"),
                LocationId = history.LocationId,
                LocationName = history.Location?.Name
            };

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

            if (!IsEqual(dto, current))
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
