using System.Text.Json.Serialization;
using TarkovOverlay.Core.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class PriceRequirement
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringToEnumConverter<UnlockCondition>))]
        public UnlockCondition? Type { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }
}