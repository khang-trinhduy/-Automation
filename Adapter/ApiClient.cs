using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedLibrary;

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
        private async Task<Message<T>> PutAsync<T>(Uri requestUrl, T content)
        {
            var respond = await _httpClient.PutAsync(requestUrl.ToString(), CreateHttpContent(content));
            respond.EnsureSuccessStatusCode();
            var data = await respond.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T>>(data);
        }
        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.MicrosoftDateFormat});
            return new StringContent(json, Encoding.UTF8, "application/json");
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