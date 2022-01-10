using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class ContainedItem
    {
        [JsonPropertyName("item")]
        public ItemIdHolder Item { get; set; }

        [JsonPropertyName("count")]
        public float Count { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        public class ItemIdHolder
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }
        }
    }
}