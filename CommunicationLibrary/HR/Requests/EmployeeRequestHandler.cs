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

        public IEnumerable<Employee> GetEmployeeHistory(int id) {
            List<Employee> output = new List<Employee>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HISTORY, id);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                }
            }
            return output;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeHistoryAsync(int id) {
            List<Employee> output = new List<Employee>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HISTORY, id);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
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

        public async Task<IEnumerable<EmployeeHeader>> GetEmployeeHeadersAsync() {
            List<EmployeeHeader> output = new List<EmployeeHeader>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HEADERS);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<EmployeeHeader>>(apiResponse);
                }
            }
            return output;
        }

        public IEnumerable<EmployeeHeader> GetEmployeeHeaders() {
            List<EmployeeHeader> output = new List<EmployeeHeader>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET_EMPLOYEE_HEADERS);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<EmployeeHeader>>(apiResponse);
                }
            }
            return output;
        }
    }
}
