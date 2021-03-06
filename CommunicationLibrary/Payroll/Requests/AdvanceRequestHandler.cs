﻿using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.Payroll.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.Payroll.Requests {
    public class AdvanceRequestHandler : BaseRequestHandler<Advance> {

        public AdvanceRequestHandler() {
            _controllerName = "Advances";
        }

        public IEnumerable<Advance> GetEmployeeAdvances(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_ADVANCES);
        }

        public async Task<IEnumerable<Advance>> GetEmployeeAdvancesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_ADVANCES);
        }

        public IEnumerable<Advance> GetContractAdvances(int id) {
            return base.Get(id, RouteVerbs.GET_CONTRACT_ADVANCES);
        }

        public async Task<IEnumerable<Advance>> GetContractAdvancesAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_CONTRACT_ADVANCES);
        }

    }
}
