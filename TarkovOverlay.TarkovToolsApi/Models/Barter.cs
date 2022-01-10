using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class Barter
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }
        
        [JsonPropertyName("requiredItems")]
        public ContainedItem[] RequiredItems { get; set; }

        [JsonPropertyName("rewardItems")]
        public ContainedItem[] RewardItems { get; set; }
    }
}