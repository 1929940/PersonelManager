using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
    public class CertificateRequestHandler : BaseRequestHandler<PersonelDocument> {

        public CertificateRequestHandler() {
            _controllerName = "Certificate";
        }

        public IEnumerable<PersonelDocument> GetEmployeeCertificates(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_CERTIFICATES);
        }

        public async Task<IEnumerable<PersonelDocument>> GetEmployeeCertificatesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_CERTIFICATES);
        }
    }
}