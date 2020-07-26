using CommunicationLibrary.Payroll.Comparers;
using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using CommunicationLibrary.Test.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Payroll {
    public class PaymentsTest : BaseTest<Payment> {

        private readonly int employeeId;

        public PaymentsTest() : base() {
            _requestHandler = new PaymentsRequestHandler();
            _comparer = new PaymentComparer();
            employeeId = 1;

            _baseRow = new Payment() {
                Contract = new ContractSimplified() { Id = 1 },
                NetAmount = 1000,
                GrossAmount = 800,
                PaidOn = DateTime.Today.AddDays(-1),
            };

            _updatedRow = new Payment() {
                Contract = new ContractSimplified() { Id = 1 },
                NetAmount = 1200,
                GrossAmount = 850,
                PaidOn = DateTime.Today,
            };
        }

        [Fact]
        public void GetEmployeePayments_ShouldPass() {
            var row = _requestHandler.Create(_baseRow);
            var employeePayments = ((PaymentsRequestHandler)_requestHandler).GetEmployeePayments(employeeId);
            _requestHandler.Delete(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }

        [Fact]
        public async Task GetEmployeePaymentsAsync_ShouldPass() {
            var row = await _requestHandler.CreateAsync(_baseRow);
            var employeePayments = await ((PaymentsRequestHandler)_requestHandler).GetEmployeePaymentsAsync(employeeId);
            await _requestHandler.DeleteAsync(row.Id);

            Assert.Contains(row, employeePayments, _comparer);
        }
    }
}
