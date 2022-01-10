using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class ServerStatusMessage
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("solveTime")]
        public string SolveTime { get; set; }
    }
}