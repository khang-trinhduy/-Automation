using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SharedLibrary
{
    [DataContract]
    public class Message<T>
    {
        [DataMember(Name = "IsSuccessStatusCode")]
        public bool IsSuccessStatusCode { get; set;}
        [DataMember(Name = "ReasonPhrase")]
        public string ReasonPhrase { get; set; }
        [DataMember(Name = "RequestMessage")]
        public HttpRequestMessage RequestMessage { get; set; }
        [DataMember(Name = "StatusCode")]
        public HttpStatusCode StatusCode { get; set; }
        [DataMember(Name = "Version")]
        public Version Version { get; set; }

        [DataMember(Name = "Content")]
        public T Content { get; set; }

        public static Message<T> CreateMessage(HttpResponseMessage msg)
        {
            return new Message<T> {
                IsSuccessStatusCode = msg.IsSuccessStatusCode,
                ReasonPhrase = msg.ReasonPhrase,
                RequestMessage = msg.RequestMessage,
                StatusCode = msg.StatusCode,
                Version = msg.Version,
                Content = JsonConvert.DeserializeObject<T>(msg.Content.ReadAsStringAsync().Result)
            };
        }
    }
}