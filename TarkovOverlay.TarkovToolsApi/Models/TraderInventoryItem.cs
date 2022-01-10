using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class TraderInventoryItem
    {
        [JsonPropertyName("Item")]
        public Item Item { get; set; }

        [JsonPropertyName("minLevel")]
        public int? MinLevel { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("updated")]
        public string Updated { get; set; }

        [JsonPropertyName("questUnlockId")]
        public string QuestUnlockId { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}