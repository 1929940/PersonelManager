using CommunicationLibrary.Core.Resx;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationLibrary.Core.Logic {

    public abstract class BaseRequestHandler<T> where T : class {
        protected string _controllerName { get; set; }

        protected void SetToken(HttpClient httpClient) =>
            httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", Settings.Token);

        protected string GetUri(string controller, string routeVerb) =>
            string.Format($"{Settings.Url}/api/{controller}/{routeVerb}");

        protected string GetUri(string controller, string routeVerb, int id) =>
            string.Format($"{Settings.Url}/api/{controller}/{routeVerb}/{id}");

        protected string GetUri(string controller, string routeVerb, string login) =>
            string.Format($"{Settings.Url}/api/{controller}/{routeVerb}/{login}");

        protected StringContent CreateStringContent(T input) {
            string body = JsonConvert.SerializeObject(input);
            return new StringContent(body, Encoding.UTF8, "application/json");
        }

        protected StringContent CreateStringContent<T>(T input) {
            string body = JsonConvert.SerializeObject(input);
            return new StringContent(body, Encoding.UTF8, "application/json");
        }

        //get all

        public IEnumerable<T> Get() {
            List<T> output = new List<T>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<T>>(apiResponse);
                }
            }
            return output;
        }


        public async Task<IEnumerable<T>> GetAsync() {
            List<T> output = new List<T>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<T>>(apiResponse);
                }
            }
            return output;
        }



        //get one

        public T Get(int id) {
            T output = null;
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET, id);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
            return output;
        }

        public async Task<T> GetAsync(int id) {
            T output = null;
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.GET, id);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
            return output;
        }


        //update one

        public void Update(int id, T input) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE, id);

                using (var response = httpClient.PutAsync(requestUri, CreateStringContent(input)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public async Task UpdateAsync(int id, T input) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE, id);

                using (var response = await httpClient.PutAsync(requestUri, CreateStringContent(input))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }


        //create one

        public T Create(T input) {
            T output = null;
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.CREATE);

                using (var response = httpClient.PostAsync(requestUri, CreateStringContent(input)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
            return output;
        }

        public async Task<T> CreateAsync(T input) {
            T output = null;
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.CREATE);

                using (var response = await httpClient.PostAsync(requestUri, CreateStringContent(input))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
            return output;
        }

        //delete one

        public void Delete(int id) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.DELETE, id);

                using (var response = httpClient.DeleteAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public async Task DeleteAsync(int id) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.DELETE , id);

                using (var response = await httpClient.DeleteAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }

        //get many defined by verb

        protected IEnumerable<T> Get(int id, string routeVerb) {
            List<T> output = new List<T>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, routeVerb, id);

                using (var response = httpClient.GetAsync(requestUri).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<List<T>>(apiResponse);
                }
            }
            return output;
        }

        protected async Task<IEnumerable<T>> GetAsync(int id, string routeVerb) {
            List<T> output = new List<T>();
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, routeVerb, id);

                using (var response = await httpClient.GetAsync(requestUri)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<List<T>>(apiResponse);
                }
            }
            return output;
        }
    }
}
