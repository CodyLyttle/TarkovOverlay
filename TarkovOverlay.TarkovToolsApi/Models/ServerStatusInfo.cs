using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class ServerStatusInfo
    {
        [JsonPropertyName("generalStatus")]
        public ServerStatus GeneralStatus { get; set; }

        [JsonPropertyName("currentStatuses")]
        public ServerStatus[] CurrentStatuses { get; set; }

        [JsonPropertyName("messages")]
        public ServerStatusMessage[] Messages { get; set; }
    }
}