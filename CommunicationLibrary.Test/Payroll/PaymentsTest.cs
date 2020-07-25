using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using CommunicationLibrary.Test.Core;
using CommunicationLibrary.Test.Payroll.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Payroll {
    public class PaymentsTest : BaseTest<Payment> {
        public PaymentsTest() : base() {
            _requestHandler = new PaymentsRequestHandler();
            _comparer = new PaymentComparer();
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
            var payments = _requestHandler.Get();
            var employeePayments = ((PaymentsRequestHandler)_requestHandler).GetEmployeePayments(4);

            int countOfEmployeePayments = payments.Count(x => x.Contract.Id == 7);
            Assert.Equal(countOfEmployeePayments, employeePayments.Count());
        }

        [Fact]
        public async Task GetEmployeePaymentsAsync_ShouldPass() {
            var payments = await _requestHandler.GetAsync();
            var employeePayments = await ((PaymentsRequestHandler)_requestHandler).GetEmployeePaymentsAsync(4);

            int countOfEmployeePayments = payments.Count(x => x.Contract.Id == 7);
            Assert.Equal(countOfEmployeePayments, employeePayments.Count());
        }
    }
}
