using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.Payroll.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommunicationLibrary.Payroll.Requests {
    public class ContractRequestHandler : BaseRequestHandler<Contract>{

        public ContractRequestHandler() {
            _controllerName = "Contracts";
        }

        public IEnumerable<Contract> GetEmployeeContracts(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_CONTRACTS);
        }

        public async Task<IEnumerable<Contract>> GetEmployeeContractsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_CONTRACTS);
        }

        public async Task<IEnumerable<ContractHeader>> GetContractHeadersAsync() {
            List<ContractHeader> output = new List<ContractHeader>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_HEADERS);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<ContractHeader>>(apiResponse);
                }
            }
            return output;
        }

        public IEnumerable<ContractHeader> GetContractHeaders() {
            List<ContractHeader> output = new List<ContractHeader>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_HEADERS);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<ContractHeader>>(apiResponse);
                }
            }
            return output;
        }

        public async Task<ContractAdvanceData> GetContractAdvanceDataAsync(int id) {
            ContractAdvanceData output = new ContractAdvanceData();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_ADVANCE_DATA, id);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<ContractAdvanceData>(apiResponse);
                }
            }
            return output;
        }

        public ContractAdvanceData GetContractAdvanceData(int id) {
            ContractAdvanceData output = new ContractAdvanceData();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_ADVANCE_DATA, id);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<ContractAdvanceData>(apiResponse);
                }
            }
            return output;
        }
    }
}
