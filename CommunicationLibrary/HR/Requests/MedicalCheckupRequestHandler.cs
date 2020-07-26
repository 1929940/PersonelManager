using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
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
