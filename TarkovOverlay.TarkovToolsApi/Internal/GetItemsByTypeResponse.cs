using System.Collections.Generic;
using System.Text.Json.Serialization;
using TarkovOverlay.TarkovToolsApi.Models;

namespace TarkovOverlay.TarkovToolsApi.Internal
{
    internal class GetItemsByTypeResponse
    {
        public class ResponseData
        {
            [JsonPropertyName("itemsByType")]
            public List<Item> ItemsByType { get; set; }
        }

        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }
    }
}