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

        public static string GetPath(string controller, string routeVerb) =>
            string.Format($"{Settings.Url}/api/{controller}/{routeVerb}");

        public static string GetPath(string controller, string routeVerb, int id) =>
            string.Format($"{Settings.Url}/api/{controller}/{routeVerb}/{id}");
    }
}
