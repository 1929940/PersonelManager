using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
    public class EmployeeRequestHandler : BaseRequestHandler<Employee> {
        public EmployeeRequestHandler() {
            _controllerName = "Employees";
        }

        public IEnumerable<EmployeeHistory> GetEmployeeHistory(int id) {
            List<EmployeeHistory> output = new List<EmployeeHistory>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HISTORY, id);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<EmployeeHistory>>(apiResponse);
                }
            }
            return output;
        }

        public async Task<IEnumerable<EmployeeHistory>> GetEmployeeHistoryAsync(int id) {
            List<EmployeeHistory> output = new List<EmployeeHistory>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HISTORY, id);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<EmployeeHistory>>(apiResponse);
                }
            }
            return output;
        }


        public void ArchiveEmployee(int id, bool input) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.ARCHIVE_EMPLOYEE, id);

                using (var response = httpClient.PutAsync(requestUri, CreateStringContent(input)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public async Task ArchiveEmployeeAsync(int id, bool input) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.ARCHIVE_EMPLOYEE, id);

                using (var response = await httpClient.PutAsync(requestUri, CreateStringContent(input))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
