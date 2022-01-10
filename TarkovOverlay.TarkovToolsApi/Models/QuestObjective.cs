﻿using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class QuestObjective
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("target")]
        public string[] Target { get; set; }

        [JsonPropertyName("targetItem")]
        public Item TargetItem { get; set; }

        [JsonPropertyName("number")]
        public int? Number { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }
    }
}