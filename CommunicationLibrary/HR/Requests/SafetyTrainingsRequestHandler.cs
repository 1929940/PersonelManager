using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
    public class SafetyTrainingsRequestHandler : BaseRequestHandler<PersonelDocument> {

        public SafetyTrainingsRequestHandler() {
            _controllerName = "SafetyTrainings";
        }

        public IEnumerable<PersonelDocument> GetEmployeeSafetyTrainings(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_SAFETY_TRAININGS);
        }

        public async Task<IEnumerable<PersonelDocument>> GetEmployeeSafetyTrainingsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_SAFETY_TRAININGS);
        }
    }
}
