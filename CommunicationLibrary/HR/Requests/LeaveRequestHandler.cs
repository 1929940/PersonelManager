using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
    public class LeaveRequestHandler : BaseRequestHandler<Leave> {

        public LeaveRequestHandler() {
            _controllerName = "Leave";
        }

        public IEnumerable<Leave> GetEmployeeLeaves(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_LEAVES);
        }

        public async Task<IEnumerable<Leave>> GetEmployeeLeavesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_LEAVES);
        }
    }
}
