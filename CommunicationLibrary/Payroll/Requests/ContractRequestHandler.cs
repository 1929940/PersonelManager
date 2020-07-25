using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.Payroll.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.Payroll.Requests {
    public class ContractRequestHandler : BaseRequestHandler<Contract>{

        public ContractRequestHandler() {
            _controllerName = "Contract";
        }

        public IEnumerable<Contract> GetEmployeeContracts(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_CONTRACTS);
        }

        public async Task<IEnumerable<Contract>> GetEmployeeContractsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_CONTRACTS);
        }
    }
}
