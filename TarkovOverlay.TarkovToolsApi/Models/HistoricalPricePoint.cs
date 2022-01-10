using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class HistoricalPricePoint
    {
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}