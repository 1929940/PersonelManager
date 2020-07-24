using Communication.Business.Models;
using Communication.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Communication.Business.Requests {
    public class UserRequests {

        //Users Get()

        public async Task<IEnumerable<User>> Get() {
            List<User> reservationList = new List<User>();
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(Configuration.Url)) {
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
