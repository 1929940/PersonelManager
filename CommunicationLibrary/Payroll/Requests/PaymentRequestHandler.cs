using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.Payroll.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.Payroll.Requests {
    public class PaymentRequestHandler : BaseRequestHandler<Payment> {

        public PaymentRequestHandler() {
            _controllerName = "Payment";
        }

        public IEnumerable<Payment> GetEmployeePayments(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_PAYMENTS);
        }

        public async Task<IEnumerable<Payment>> GetEmployeePaymentsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_PAYMENTS);
        }
    }
}
