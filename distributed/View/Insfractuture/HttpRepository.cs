using Newtonsoft.Json;
using System.Net;
using System.Text;
using View.Domain;

namespace View.Insfractuture
{
    internal class HttpRepository : IHttpRepository
    {
        private HttpClient _httpClient;
        private const string MEDIA_TYPE_JSON = "application/json";

        public HttpRepository(string baseUri)
        {
            this.BaseUri = baseUri;
            this._httpClient = new HttpClient();
        }

        public string BaseUri { get; private set; }

        TResponse IHttpRepository.Get<TResponse>(string relativeRestUri, IList<HttpParameter> parameters = null)
        {
            Uri uri = this.GetUri(relativeRestUri: relativeRestUri, parameters: parameters);
            HttpResponseMessage response = this._httpClient.GetAsync(uri).Result;
            this.ThrowIfResponseIsNotOk(response);
            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

        TResponse IHttpRepository.Get<TResponse, TRequest>(string relativeRestUri, TRequest item)
        {
            Uri uri = this.GetUri(relativeRestUri: relativeRestUri);
            HttpResponseMessage response = this._httpClient.GetAsync(uri).Result;
            this.ThrowIfResponseIsNotOk(response);
            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

        TResponse IHttpRepository.Put<TResponse, TRequest>(string relativeRestUri, TRequest item)
        {
            string bodyContent = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(bodyContent, Encoding.UTF8, MEDIA_TYPE_JSON);
            Uri uri = this.GetUri(relativeRestUri: relativeRestUri);
            HttpResponseMessage response = this._httpClient.PutAsync(uri, content).Result;
            this.ThrowIfResponseIsNotOk(response);

            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

        TResponse IHttpRepository.Post<TResponse, TRequest>(string relativeRestUri, TRequest item)
        {
            string bodyContent = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(bodyContent, Encoding.UTF8, MEDIA_TYPE_JSON);
            Uri uri = this.GetUri(relativeRestUri: relativeRestUri);
            var response = this._httpClient.PostAsync(uri, content).Result;
            this.ThrowIfResponseIsNotOk(response);

            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

        private Uri GetUri(string relativeRestUri, IList<HttpParameter> parameters = null)
        {
            StringBuilder query = new StringBuilder();
            string parameterIndicator = string.Empty;

            if (parameters != null)
            {
                Boolean first = true;
                parameterIndicator = "?";

                foreach (HttpParameter item in parameters)
                {
                    if (!first)
                    {
                        query.Append("&");
                    }

                    query.Append(item.Id);
                    query.Append("=");
                    query.Append(item.Value);

                    first = false;
                }
            }

            return new Uri(string.Format("{0}{1}{2}{3}", this.BaseUri, relativeRestUri, parameterIndicator, query.ToString()));
        }

        private void ThrowIfResponseIsNotOk(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception();
            }
        }
    }
}
