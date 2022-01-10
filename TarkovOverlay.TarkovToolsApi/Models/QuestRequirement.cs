using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class QuestRequirement
    {
        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("quests")]
        public int[][] Quests { get; set; }

        [JsonPropertyName("prerequisiteQuests")]
        public Quest[][] PrerequisiteQuests { get; set; }
    }
}