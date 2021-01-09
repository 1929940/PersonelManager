using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class CertificateRequestHandler : BaseRequestHandler<PersonelDocument> {

        public CertificateRequestHandler() {
            _controllerName = "Certificates";
        }

        public IEnumerable<PersonelDocument> GetEmployeeCertificates(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_CERTIFICATES);
        }

        public async Task<IEnumerable<PersonelDocument>> GetEmployeeCertificatesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_CERTIFICATES);
        }
    }
}