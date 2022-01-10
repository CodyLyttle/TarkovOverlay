using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class Quest
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("requirements")]
        public QuestRequirement Requirements { get; set; }

        [JsonPropertyName("giver")]
        public Trader Giver { get; set; }

        // ReSharper disable once StringLiteralTypo
        [JsonPropertyName("turnin")]
        public Trader TurnIn { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("wikiLink")]
        public string WikiLink { get; set; }

        [JsonPropertyName("exp")]
        public int Exp { get; set; }

        [JsonPropertyName("unlocks")]
        public string[] Unlocks { get; set; }

        [JsonPropertyName("reputation")]
        public QuestRewardReputation[] Reputation { get; set; }

        [JsonPropertyName("objectives")]
        public QuestObjective[] Objectives { get; set; }
        
    }
}