using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class Craft
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("duration")]
        public int DurationInSeconds { get; set; }

        [JsonPropertyName("requiredItems")]
        public ContainedItem[] RequiredItems { get; set; }

        [JsonPropertyName("rewardItems")]
        public ContainedItem[] RewardItems { get; set; }
    }
}