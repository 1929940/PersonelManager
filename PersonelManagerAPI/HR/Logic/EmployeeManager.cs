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
                AddressId = current.EmployeeAddressId,
                FullAddress = string.Format(
                    $"{current.EmployeeAddress.City} {current.EmployeeAddress.Zip} {current.EmployeeAddress.Street} {current.EmployeeAddress.Number}"),
                ForemanId = current.ForemanId,
                ForemanFullName = string.Format(
                    $"{current.Foreman.FirstName} {current.Foreman.LastName}"),
                LocationId = current.LocationId,
                LocationName = current.Location.Name
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

        public static EmployeeHistory CreateEmployeeHistoryEntry(EmployeeDTO dto, EmployeeHistory current) {

            if (IsEqual(dto, current))
                return new EmployeeHistory() {
                    LastName = dto.LastName,
                    PhoneNo = dto.PhoneNo,
                    Profession = dto.Profession,
                    EmployeeId = dto.Id,
                    ForemanId = dto.ForemanId,
                    LocationId = dto.LocationId,
                    EmployeeAddressId = dto.AddressId
                };
            return null;
        }

        private static bool IsEqual(EmployeeDTO dto, EmployeeHistory history) =>
            history.EmployeeId == dto.Id &&
            history.LastName == dto.LastName &&
            history.PhoneNo == dto.PhoneNo &&
            history.Profession == dto.Profession &&
            history.LocationId == dto.LocationId &&
            history.ForemanId == dto.ForemanId &&
            history.EmployeeAddressId == dto.AddressId;
    }
}
