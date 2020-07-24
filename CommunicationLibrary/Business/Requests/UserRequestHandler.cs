using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationLibrary.Business.Requests {
    public class UserRequestHandler {

        //Users Get()

        public async Task<IEnumerable<User>> Get() {
            List<User> reservationList = new List<User>();
            using (var httpClient = new HttpClient()) {
                //TODO: Does this set token?
                RequestHelper.SetToken(httpClient);

                string path = string.Format($"{Settings.Url}{"Endpoints.GetOne"}{"id"}");

                using (var response = await httpClient.GetAsync(Settings.Url)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<User>>(apiResponse);
                }
            }
            return reservationList;
        }


        //User Create(User)

        //void Update(id, User);

        //void Delete(id);

        //bool string Login(request);

        //void RequestPasswordReset(id)

        //void UpdatePassword(id, hash);
    }
}
