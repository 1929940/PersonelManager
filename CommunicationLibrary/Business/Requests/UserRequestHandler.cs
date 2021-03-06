﻿using CommunicationAndCommonsLibrary.Business.Models;
using CommunicationAndCommonsLibrary.Core.Logic;
using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.Business.Requests {
    public class UserRequestHandler : BaseRequestHandler<User> {

        public UserRequestHandler() {
            _controllerName = "Users";
        }

        //Login

        public AuthenticationReponse Login(string login, string password) {

            AuthenticationReponse output = null;
            var input = new AuthenticationRequest() { Login = login, Password = PasswordManager.Encrypt(password) };

            using (var httpClient = new HttpClient()) {
                string requestUri = GetUri(_controllerName, RouteVerbs.LOGIN);

                using (var response = httpClient.PostAsync(requestUri, CreateStringContent(input)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        throw new UnauthorizedAccessException();
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<AuthenticationReponse>(apiResponse);
                }
            }
            return output;
        }

        public async Task<AuthenticationReponse> LoginAsync(string login, string password) {

            AuthenticationReponse output = null;
            var input = new AuthenticationRequest() { Login = login, Password = PasswordManager.Encrypt(password) };

            using (var httpClient = new HttpClient()) {
                string requestUri = GetUri(_controllerName, RouteVerbs.LOGIN);

                using (var response = await httpClient.PostAsync(requestUri, CreateStringContent(input))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        throw new UnauthorizedAccessException();
                    response.EnsureSuccessStatusCode();
                    output = JsonConvert.DeserializeObject<AuthenticationReponse>(apiResponse);
                }
            }
            return output;
        }

        //RequestPasswordReset

        public void RequestPasswordReset(string login) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.REQUEST_PASSWORD_RESET, login);
                var stringContent = new StringContent(string.Empty);

                using (var response = httpClient.PutAsync(requestUri, stringContent).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task RequestPasswordResetAsync(string login) {
            using (var httpClient = new HttpClient()) {
                SetToken(httpClient);

                string requestUri = GetUri(_controllerName, RouteVerbs.REQUEST_PASSWORD_RESET, login);
                var stringContent = new StringContent(string.Empty);

                using (var response = await httpClient.PutAsync(requestUri, stringContent)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        //UpdatePassword

        public void UpdatePassword(string login, string password) {
            using (var httpClient = new HttpClient()) {

                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE_PASSWORD, login, password);

                using (var response = httpClient.PutAsync(requestUri, CreateStringContent(password)).Result) {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task UpdatePasswordAsync(string login, string password) {
            using (var httpClient = new HttpClient()) {

                SetToken(httpClient);
                string requestUri = GetUri(_controllerName, RouteVerbs.UPDATE_PASSWORD, login, password);

                using (var response = await httpClient.PutAsync(requestUri, CreateStringContent(password))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                }
            }
        }
    }
}


