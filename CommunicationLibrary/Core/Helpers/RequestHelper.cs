using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace CommunicationLibrary.Core.Helpers {
    public static class RequestHelper {
        public static void SetToken(HttpClient httpClient) =>
            httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", Settings.Token);
    }
}
