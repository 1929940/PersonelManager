using CommunicationLibrary.Payroll.Comparers;
using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.Test.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Payroll {
    public class ContractsTest : BaseTest<Contract> {

        private readonly int employeeId;

        public ContractsTest() : base() {
            _requestHandler = new ContractRequestHandler();
            _comparer = new ContractComparer();
            employeeId = 1;

            _baseRow = new Contract() {
                Employee = new EmployeeSimplified() { Id = 1},
                Title = "Test Contract",
                Number = "T/01/07/2020",
                ContractSubject = "Testing API",
                ValidFrom = DateTime.Today.AddDays(-10),
                ValidTo = DateTime.Today,
                HourlySalary = 10,
                TaxPercent = 0.1m,
                Value = 4000
            };

            _updatedRow = new Contract() {
                Employee = new EmployeeSimplified() { Id = 1 },
                Title = "Test Contract Updated",
                Number = "U/01/07/2020",
                ContractSubject = "Testing API - Updated",
                ValidFrom = DateTime.Today.AddDays(-20),
                ValidTo = DateTime.Today,
                HourlySalary = 12,
                TaxPercent = 0.2m,
                Value = 4500
            };
        }

        [Fact]
        public void GetEmployeePayments_ShouldPass() {
            var row = _requestHandler.Create(_baseRow);
            var employeePayments = ((ContractRequestHandler)_requestHandler).GetEmployeeContracts(employeeId);
            _requestHandler.Delete(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }

        [Fact]
        public async Task GetEmployeePaymentsAsync_ShouldPass() {
            var row = await _requestHandler.CreateAsync(_baseRow);
            var employeePayments = await ((ContractRequestHandler)_requestHandler).GetEmployeeContractsAsync(employeeId);
            await _requestHandler.DeleteAsync(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }
    }
}
