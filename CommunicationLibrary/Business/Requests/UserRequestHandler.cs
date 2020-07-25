using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationLibrary.Business.Requests {
    public class UserRequestHandler : BaseRequestHandler<User> {

        public UserRequestHandler() {
            _controllerName = "Users";
        }

        //Login

        public AuthenticationReponse Login(string login, string password) {

            AuthenticationReponse output = null;
            var input = new AuthenticationRequest() { Login = login, Password = password };

            using (var httpClient = new HttpClient()) {

                string requestUri = GetUri(_controllerName, RouteVerbs.LOGIN);

                using (var response = httpClient.PostAsync(requestUri, CreateStringContent(input)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    output = JsonConvert.DeserializeObject<AuthenticationReponse>(apiResponse);
                }
            }
            return output;
        }

        public async Task<AuthenticationReponse> LoginAsync(string login, string password) {

            AuthenticationReponse output = null;
            var input = new AuthenticationRequest() { Login = login, Password = password };

            using (var httpClient = new HttpClient()) {

                string requestUri = GetUri(_controllerName, RouteVerbs.LOGIN);

                using (var response = await httpClient.PostAsync(requestUri, CreateStringContent(input))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    output = JsonConvert.DeserializeObject<AuthenticationReponse>(apiResponse);
                }
            }
            return output;
        }

        //RequestPasswordReset

        public void RequestPasswordReset(int id) {

            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.REQUEST_PASSWORD_RESET, id);
                var stringContent = new StringContent(string.Empty);

                using (var response = httpClient.PutAsync(requestUri, stringContent).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public async Task RequestPasswordResetAsync(int id) {

            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.REQUEST_PASSWORD_RESET, id);

                using (var response = await httpClient.PutAsync(requestUri, null)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }

        //UpdatePassword

        public void UpdatePassword(int id, string password) {

            using (var httpClient = new HttpClient()) {

                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE_PASSWORD, id);

                using (var response = httpClient.PutAsync(requestUri, CreateStringContent(password)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public async Task UpdatePasswordAsync(int id, string password) {

            using (var httpClient = new HttpClient()) {

                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE_PASSWORD, id);

                using (var response = await httpClient.PutAsync(requestUri, CreateStringContent(password))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}


