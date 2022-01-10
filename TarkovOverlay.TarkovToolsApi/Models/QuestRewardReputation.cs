using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class QuestRewardReputation
    {
        [JsonPropertyName("trader")]
        public Trader Trader { get; set; }

        [JsonPropertyName("amount")]
        public float Amount { get; set; }
    }
}