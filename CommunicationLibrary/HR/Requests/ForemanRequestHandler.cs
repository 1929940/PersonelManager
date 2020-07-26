using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
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
