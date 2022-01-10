using System.Text.Json.Serialization;
using TarkovOverlay.TarkovToolsApi.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class TraderInventory
    {
        [JsonPropertyName("ID")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        [JsonConverter(typeof(JsonStringToEnumConverter<TraderName>))]
        public TraderName Name { get; set; }

        [JsonPropertyName("items")]
        public TraderInventoryItem[] Items { get; set; }
    }
}