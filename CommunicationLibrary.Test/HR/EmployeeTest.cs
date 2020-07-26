using CommunicationLibrary.HR.Comparers;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using CommunicationLibrary.Test.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.HR {
    public class EmployeeTest : BaseTest<Employee> {
        private readonly EmployeeRequestHandler _employeesRequestHandler;

        public EmployeeTest() {
            _requestHandler = _employeesRequestHandler = new EmployeeRequestHandler();
            _comparer = new EmployeeComparer();

            _baseRow = new Employee() {
                FirstName = "FirstNameTest",
                LastName = "LastNameTest",
                DateOfBirth = new DateTime(1999, 10, 11),
                Pesel = "PeselTest",
                Nationality = "NationalityTest",
                FatherName = "FatherNameTest",
                MotherName = "MotherNameTest",
                IsArchived = false,
                Profession = "ProfessionTest",
                PhoneNo = "000-CALL-TEST",
                ForemanId = 1,
                LocationId = 1,
                Country = "CountryTest",
                Region = "RegionTest",
                City = "CityTest",
                Zip = "ZipTest",
                Street = "StreetTest",
                Number = "NumberTest"
            };

            _updatedRow = new Employee() {
                FirstName = "FIRSTNAMETEST",
                LastName = "LASTNAMETEST",
                DateOfBirth = new DateTime(1999, 10, 11),
                Pesel = "PESELTEST",
                Nationality = "NATIONALITYTEST",
                FatherName = "FATHERNAMETEST",
                MotherName = "MOTHERNAMETEST",
                IsArchived = false,
                Profession = "PROFESSIONTEST",
                PhoneNo = "111-CALL-TEST",
                ForemanId = 1,
                LocationId = 1,
                Country = "COUNTRYTEST",
                Region = "REGIONTEST",
                City = "CITYTEST",
                Zip = "ZIPTEST",
                Street = "STREETTEST",
                Number = "NUMBERTEST"
            };

        }
        private bool IsEmployeeHistoryEqualToEmployee(EmployeeHistory history, Employee employee) =>
                history.LastName == employee.LastName &&
                history.Profession == employee.Profession &&
                history.PhoneNo == employee.PhoneNo &&
                history.Location?.Id == employee.LocationId &&
                history.Foreman?.Id == employee.ForemanId &&
                history.Country == employee.Country &&
                history.Region == employee.Region &&
                history.City == employee.City &&
                history.Zip == employee.Zip &&
                history.Street == employee.Street &&
                history.Number == employee.Number;

        [Fact]
        public void GetEmployeeHistory_ShouldPass() {
            var employeeHistory = _employeesRequestHandler.GetEmployeeHistory(1);

            Assert.NotEmpty(employeeHistory);
        }

        [Fact]
        public async Task GetEmployeeHistoryAsync_ShouldPass() {
            var employeeHistory = await _employeesRequestHandler.GetEmployeeHistoryAsync(1);

            Assert.NotEmpty(employeeHistory);
        }

        [Fact]
        public void DoesEmployeeTakeDataFromLastEmployeeHistory_ShouldPass() {
            var employeeHistory = _employeesRequestHandler.GetEmployeeHistory(1);
            var employee = _employeesRequestHandler.Get(1);

            Assert.True(IsEmployeeHistoryEqualToEmployee(employeeHistory.Last(), employee));
        }

        [Fact]
        public async Task DoesEmployeeTakeDataFromLastEmployeeHistoryAsync_ShouldPass() {
            var employeeHistory = await _employeesRequestHandler.GetEmployeeHistoryAsync(1);
            var employee = await _employeesRequestHandler.GetAsync(1);

            Assert.True(IsEmployeeHistoryEqualToEmployee(employeeHistory.Last(), employee));
        }

        [Fact]
        public void ArchiveEmployee_ShouldPass() {
            var employee = _requestHandler.Create(_baseRow);
            _employeesRequestHandler.ArchiveEmployee(employee.Id, true);
            employee = _requestHandler.Get(employee.Id);
            _requestHandler.Delete(employee.Id);

            Assert.True(employee.IsArchived);
        }

        [Fact]
        public async Task ArchiveEmployeeAsync_ShouldPass() {
            var employee = await _requestHandler.CreateAsync(_baseRow);
            await _employeesRequestHandler.ArchiveEmployeeAsync(employee.Id, true);
            employee = await _requestHandler.GetAsync(employee.Id);
            await _requestHandler.DeleteAsync(employee.Id);

            Assert.True(employee.IsArchived);
        }
    }
}
