using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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

//public IEnumerable<T> Get() {
//    List<T> output = new List<T>();
//    using (var httpClient = new HttpClient()) {
//        SetToken(httpClient);

//        string requestUri = GetUri(_controllerName, RouteVerbs.GET);

//        using (var response = httpClient.GetAsync(requestUri).Result) {
//            string apiResponse = response.Content.ReadAsStringAsync().Result;
//            output = JsonConvert.DeserializeObject<List<T>>(apiResponse);
//        }
//    }
//    return output;
//}
