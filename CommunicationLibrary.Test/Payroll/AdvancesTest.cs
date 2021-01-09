using CommunicationAndCommonsLibrary.Payroll.Comparers;
using CommunicationAndCommonsLibrary.Payroll.Models;
using CommunicationAndCommonsLibrary.Payroll.Requests;
using CommunicationAndCommonsLibrary.Test.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationAndCommonsLibrary.Test.Payroll {
    public class AdvancesTest : BaseTest<Advance>{

        private readonly int employeeId;

        public AdvancesTest() {
            _requestHandler = new AdvanceRequestHandler();
            _comparer = new AdvanceComparer();
            employeeId = 1;

            _baseRow = new Advance() {
                Contract = new ContractSimplified() { Id = 1 },
                PaidOn = DateTime.Now.AddDays(-1),
                Amount = 200,
                WorkedHours = 10
            };

            _updatedRow = new Advance() {
                Contract = new ContractSimplified() { Id = 1 },
                PaidOn = DateTime.Now,
                Amount = 300,
                WorkedHours = 15
            };
        }

        [Fact]
        public void GetEmployeePayments_ShouldPass() {
            var row = _requestHandler.Create(_baseRow);
            var employeePayments = ((AdvanceRequestHandler)_requestHandler).GetEmployeeAdvances(employeeId);
            _requestHandler.Delete(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }

        [Fact]
        public async Task GetEmployeePaymentsAsync_ShouldPass() {
            var row = await _requestHandler.CreateAsync(_baseRow);
            var employeePayments = await ((AdvanceRequestHandler)_requestHandler).GetEmployeeAdvancesAsync(employeeId);
            await _requestHandler.DeleteAsync(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }

    }
}
