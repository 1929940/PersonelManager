using CommunicationAndCommonsLibrary.Core.Bufor;
using CommunicationAndCommonsLibrary.Payroll.Models;
using CommunicationAndCommonsLibrary.Payroll.Requests;
using System.Threading.Tasks;

namespace Desktop.UI.Payroll.Bufor {
    public class ContractBufor {
        public Bufor<Advance> AdvancesBufor { get; set; }

        public ContractBufor() {
            AdvancesBufor = new Bufor<Advance>(new AdvanceRequestHandler());
        }

        public async Task FlushBuforsAsync(int id) {
            await AdvancesBufor.TransactionBufor.FlushAsync(id);
        }
    }
}
