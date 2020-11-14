using CommunicationLibrary.Payroll.Models;
using CommunicationLibrary.Payroll.Requests;
using Desktop.UI.Core.Bufor;
using System.Threading.Tasks;

namespace Desktop.UI.Payroll.Helpers {
    public class ContractBufor {
        public Bufor<Advance> AdvancesBufor { get; set; }
        public Bufor<Payment> PaymentBufor { get; set; }

        public ContractBufor() {
            AdvancesBufor = new Bufor<Advance>(new AdvanceRequestHandler());
            PaymentBufor = new Bufor<Payment>(new PaymentRequestHandler());
        }

        public async Task FlushBuforsAsync(int id) {
            await AdvancesBufor.TransactionBufor.FlushAsync(id);
            await PaymentBufor.TransactionBufor.FlushAsync(id);
        }
    }
}
