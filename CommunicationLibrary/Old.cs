using System;

namespace CommunicationLibrary {
    public class Old {
        public async Task<IEnumerable<User>> Get() {
            List<User> reservationList = new List<User>();
            using (var httpClient = new HttpClient()) {
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "TOKENO");

                User user = new User() {
                    Id = 2,
                    Email = "test@wp.pl",
                    FirstName = "Marcinkiewicz",
                    LastName = "Kowalczuk"
                };

                string userStr = JsonConvert.SerializeObject(user);

                using (var response = await httpClient.PutAsync("https://localhost:44345/api/User/Update?id=2", new StringContent(userStr, Encoding.UTF8, "application/json"))) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<User>>(apiResponse);
                }
            }
            return reservationList;
        }
    }
}
}
