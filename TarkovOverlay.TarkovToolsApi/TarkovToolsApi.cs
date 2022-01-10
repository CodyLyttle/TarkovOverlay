using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TarkovOverlay.Core.Dto;
using TarkovOverlay.Core.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;
using TarkovOverlay.TarkovToolsApi.Models;

namespace TarkovOverlay.TarkovToolsApi
{
    public class TarkovToolsApi
    {
        public HttpClient HttpClient { get; set; }
        private static readonly JsonSerializerOptions SerializerOptions = new();

        public TarkovToolsApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<List<TarkovOverlay.Core.Dto.Item>> GetItemsByType(ItemTag tag)
        {
            string typeParam = HttpRequestHelper.GetEnumString(tag);
            HttpRequestMessage request = HttpRequestHelper.BuildRequest(
                $"{{itemsByType(type: {typeParam}){QueryConstants.RequestAllItemProperties}");

            var response = await FetchAndDeserialize<GetItemsByTypeResponse>(request);
            // TODO: Convert to DTO
            throw new NotImplementedException();
        }

        private async Task<T> FetchAndDeserialize<T>(HttpRequestMessage request)
        {
            HttpResponseMessage response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"{response.StatusCode}: {response.ReasonPhrase}");
            
            Stream contentStream = await response.Content.ReadAsStreamAsync();
            T deserializedContent = await JsonSerializer.DeserializeAsync<T>(contentStream, SerializerOptions);

            if (deserializedContent == null)
                throw new Exception($"Json failed to deserialize type \"{typeof(T)}\" from the content stream");

            return deserializedContent;
        }
    }
}