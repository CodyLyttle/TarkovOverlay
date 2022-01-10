using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class TraderPrice
    {
        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("trader")]
        public Trader Trader { get; set; }
    }
}