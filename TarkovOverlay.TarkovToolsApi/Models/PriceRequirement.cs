using System.Text.Json.Serialization;
using TarkovOverlay.TarkovToolsApi.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class PriceRequirement
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringToEnumConverter<RequirementType>))]
        public RequirementType? Type { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }
}