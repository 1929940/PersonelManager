using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class ForemanRequestHandler : BaseRequestHandler<Foreman> {

        public ForemanRequestHandler() {
            _controllerName = "Foremen";
        }

        public IEnumerable<Foreman> GetEmployeeForemen(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_FOREMEN);
        }

        public async Task<IEnumerable<Foreman>> GetEmployeeForemenAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_FOREMEN);
        }
    }
}
