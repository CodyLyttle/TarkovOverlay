using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("TarkovOverlay.TarkovToolsApi.Tests")]

namespace TarkovOverlay.TarkovToolsApi.Internal
{
    internal static class HttpRequestHelper
    {
        public static HttpRequestMessage BuildRequest(string query)
        {
            string completeQuery = $"{{\"query\": \"{query}\"}}";
            
            return new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://tarkov-tools.com/graphql"),
                Content = new StringContent(completeQuery, Encoding.UTF8, "application/json")
            };
        }

        public static string GetEnumString(Enum enumValue) => enumValue.ToString().ToLower();
    }
}