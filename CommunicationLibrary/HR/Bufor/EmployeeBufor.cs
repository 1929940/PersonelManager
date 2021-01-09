using System.Threading.Tasks;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Core.Bufor;

namespace CommunicationAndCommonsLibrary.HR.Bufor {
    public class EmployeeBufor {
        public Bufor<Leave> LeaveBufor { get; set; }
        public Bufor<PersonelDocument> MedicalCheckupBufor { get; set; }
        public Bufor<PersonelDocument> SafetyTrainingBufor { get; set; }
        public Bufor<PersonelDocument> CertificateBufor { get; set; }

        public EmployeeBufor() {
            LeaveBufor = new Bufor<Leave>(new LeaveRequestHandler());
            MedicalCheckupBufor = new Bufor<PersonelDocument>(new MedicalCheckupRequestHandler());
            SafetyTrainingBufor = new Bufor<PersonelDocument>(new SafetyTrainingRequestHandler());
            CertificateBufor = new Bufor<PersonelDocument>(new CertificateRequestHandler());
        }

        public async Task FlushBuforsAsync(int id) {
            await LeaveBufor.TransactionBufor.FlushAsync(id);
            await MedicalCheckupBufor.TransactionBufor.FlushAsync(id);
            await SafetyTrainingBufor.TransactionBufor.FlushAsync(id);
            await CertificateBufor.TransactionBufor.FlushAsync(id);
        }
    }
}
