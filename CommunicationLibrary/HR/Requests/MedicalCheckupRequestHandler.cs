using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class MedicalCheckupRequestHandler : BaseRequestHandler<PersonelDocument> {

        public MedicalCheckupRequestHandler() {
            _controllerName = "MedicalCheckups";
        }

        public IEnumerable<PersonelDocument> GetEmployeeMedicalCheckups(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_MEDICAL_CHECKUPS);
        }

        public async Task<IEnumerable<PersonelDocument>> GetEmployeeMedicalCheckupsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_MEDICAL_CHECKUPS);
        }
    }
}
