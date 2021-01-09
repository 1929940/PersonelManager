using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class LeaveRequestHandler : BaseRequestHandler<Leave> {

        public LeaveRequestHandler() {
            _controllerName = "Leaves";
        }

        public IEnumerable<Leave> GetEmployeeLeaves(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_LEAVES);
        }

        public async Task<IEnumerable<Leave>> GetEmployeeLeavesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_LEAVES);
        }
    }
}
