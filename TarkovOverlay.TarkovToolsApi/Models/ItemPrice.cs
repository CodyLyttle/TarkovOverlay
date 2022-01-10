using System.Text.Json.Serialization;
using TarkovOverlay.Core.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class ItemPrice
    {
        [JsonPropertyName("source")]
        [JsonConverter(typeof(JsonStringToEnumConverter<PriceSource>))]
        public PriceSource? Source { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("requirements")]
        public PriceRequirement[] Requirements { get; set; }
    }
}