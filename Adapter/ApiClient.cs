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
        private async Task<HttpResponseMessage> GetNAsync(Uri requestUri)
        {
            //FIXME wth is this?
            _httpClient.DefaultRequestHeaders.Remove("userIP");
            _httpClient.DefaultRequestHeaders.Add("userIP", "192.168.1.1");

            var respond = await _httpClient.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead);
            respond.EnsureSuccessStatusCode();
            var data = await respond.Content.ReadAsStringAsync();
            return respond;
        }
        private async Task<Message<T>> PostAsync<T>(Uri requestUrl, T content)
        {
            var respond = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent(content));
            respond.EnsureSuccessStatusCode();
            var message = Message<T>.CreateMessage(respond);
            return message;
        }
        private async Task<Message<T>> PutAsync<T>(Uri requestUrl, T content)
        {
            var respond = await _httpClient.PutAsync(requestUrl.ToString(), CreateHttpContent(content));
            respond.EnsureSuccessStatusCode();
            var message = Message<T>.CreateMessage(respond);
            return message;
        }
        private async Task<Message<T1>> PutAsync<T1, T2>(Uri requestUrl, T2 content)
        {
            var respond = await _httpClient.PutAsync(requestUrl.ToString(), CreateHttpContent(content));
            respond.EnsureSuccessStatusCode();
            var message = Message<T1>.CreateMessage(respond);
            return message;
        }
        private async Task<Message<T>> DeleteAsync<T>(Uri requestUrl)
        {
            var respond = await _httpClient.DeleteAsync(requestUrl);
            respond.EnsureSuccessStatusCode();
            var message = Message<T>.CreateMessage(respond);
            return message;
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
        private string CreateQuery(object obj)
        {
            if (obj == null)
            {
                return "";
            }
            string query = "?";
            foreach (var param in obj.GetType().GetProperties())
            {
                query += param.Name + "=" + param.GetValue(obj) + "&";
            }
            query = query.Substring(0, query.Length - 1);
            return query;
        }
    }
}