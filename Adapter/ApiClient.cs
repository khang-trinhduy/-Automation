using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Adapter
{
    public partial class ApiClient
    {
        private readonly HttpClient _httpClient;
        private Uri BaseEndpoint {get; set;}
        public ApiClient(Uri endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));

            }
            BaseEndpoint = endpoint;
            _httpClient = new HttpClient();
        }

        private async Task<T> GetAsync<T>(Uri requestUri)
        {
            //FIXME wth is this?
            _httpClient.DefaultRequestHeaders.Remove("userIP");
            _httpClient.DefaultRequestHeaders.Add("userIP", "192.168.1.1");

            var respond = await _httpClient.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead);
            respond.EnsureSuccessStatusCode();
            var data = await respond.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }
        //FIXME wtf is this?
        private Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndpoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }
    }
}