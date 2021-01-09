using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class SafetyTrainingRequestHandler : BaseRequestHandler<PersonelDocument> {

        public SafetyTrainingRequestHandler() {
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
