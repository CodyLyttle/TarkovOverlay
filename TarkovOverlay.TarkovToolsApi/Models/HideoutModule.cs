using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class HideoutModule
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("itemRequirements")]
        public ContainedItem[] ItemRequirements { get; set; }

        [JsonPropertyName("moduleRequirements")]
        public HideoutModule[] ModuleRequirements { get; set; }
    }
}