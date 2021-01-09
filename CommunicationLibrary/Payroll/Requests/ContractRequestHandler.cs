using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.Payroll.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.Payroll.Requests {
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

        public async Task<IDictionary<int, string>> GetContractsDictionaryAsync() {
            Dictionary<int, string> output = new Dictionary<int, string>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_HEADERS);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<Dictionary<int, string>>(apiResponse);
                }
            }
            return output;
        }

        public IDictionary<int, string> GetContractsDictionary() {
            Dictionary<int, string> output = new Dictionary<int, string>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_CONTRACT_HEADERS);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<Dictionary<int, string>>(apiResponse);
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
                    response.EnsureSuccessStatusCode();
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
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<ContractAdvanceData>(apiResponse);
                }
            }
            return output;
        }
    }
}
