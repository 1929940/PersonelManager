using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CommunicationLibrary.Business.Requests {
    public class DashboardRequestHandler {

        public List<Dashboard> GetDashboard(DateTime from, DateTime to) {
            List<Dashboard> output = new List<Dashboard>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = string.Format($"{ServerConnectionData.Url}/api/Dashboard/GetDashboard?from={from.ToShortDateString()}&to={to.ToShortDateString()}");

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<List<Dashboard>>(apiResponse);
                }
            }
            return output;
        }

        public async Task<IEnumerable<Dashboard>> GetDashboardAsync(DateTime from, DateTime to) {
            List<Dashboard> output = new List<Dashboard>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = string.Format($"{ServerConnectionData.Url}/api/Dashboard/GetDashboard?from={from.ToShortDateString()}&to={to.ToShortDateString()}");

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<List<Dashboard>>(apiResponse);
                }
            }
            return output;
        }

        private void SetToken(HttpClient httpClient) =>
            httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", ServerConnectionData.Token);
    }
}
