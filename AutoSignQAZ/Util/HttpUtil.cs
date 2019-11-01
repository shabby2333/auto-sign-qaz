using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace AutoSignQAZ.Util
{
    public class HttpUtil
    {
        private static readonly string UA = "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9) Gecko/2008052906 Firefox/3.0";

        private static readonly HttpClient httpClient;
        public static readonly HttpClientHandler httpClientHandler;
        private readonly CookieContainer cookieContainer;

        static HttpUtil()
        {
            httpClientHandler = new HttpClientHandler();
            httpClient = new HttpClient(httpClientHandler);
        }

        public HttpUtil()
        {

            cookieContainer = httpClientHandler.CookieContainer;
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("User-Agent", UA);
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await httpClient.GetAsync(url);
        }

#nullable enable
        public async Task<HttpResponseMessage> PostFormAsync(string url, IDictionary<string, string>? body = null, IDictionary<string, string>? headers = null)
        {
            var form = new FormUrlEncodedContent(body);

            if (!(headers is null))
            {
                foreach (var header in headers)
                    form.Headers.Add(header.Key, header.Value);
            }
            //form.Headers.Add("User-Agent", UA);

            return await httpClient.PostAsync(url, form);
        }
    }
}
