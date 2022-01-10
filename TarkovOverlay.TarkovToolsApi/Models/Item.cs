using System.Collections.Generic;
using System.Text.Json.Serialization;
using TarkovOverlay.TarkovToolsApi.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;

namespace TarkovOverlay.TarkovToolsApi.Models
{
    public class Item
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("normalizedName")]
        public string NormalizedName { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("basePrice")]
        public int BasePrice { get; set; }

        [JsonPropertyName("updated")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("iconLink")]
        public string IconLink { get; set; }

        [JsonPropertyName("iconLinkFallback")]
        public string IconLinkFallback { get; set; }

        [JsonPropertyName("wikiLink")]
        public string WikiLink { get; set; }

        [JsonPropertyName("imageLink")]
        public string ImageLink { get; set; }

        [JsonPropertyName("imageLinkFallback")]
        public string ImageLinkFallback { get; set; }

        [JsonPropertyName("gridImageLink")]
        public string GridImageLink { get; set; }

        [JsonPropertyName("gridImageLinkFallback")]
        public string GridImageLinkFallback { get; set; }

        [JsonPropertyName("types")]
        [JsonConverter(typeof(JsonStringArrayToEnumListConverter<ItemType>))]
        public List<ItemType> Types { get; set; }

        [JsonPropertyName("avg24hPrice")]
        public int? Avg24hPrice { get; set; }

        [JsonPropertyName("accuracyModifier")]
        public float? AccuracyModifier { get; set; }

        [JsonPropertyName("recoilModifier")]
        public float? RecoilModifier { get; set; }

        [JsonPropertyName("ergonomicsModifier")]
        public float? ErgonomicsModifier { get; set; }

        [JsonPropertyName("hasGrid")]
        public bool? HasGrid { get; set; }

        [JsonPropertyName("blocksHeadphones")]
        public bool? BlocksHeadphones { get; set; }

        [JsonPropertyName("traderPrices")]
        public TraderPrice[] TraderPrices { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("lastLowPrice")]
        public int? LastLowPrice { get; set; }

        [JsonPropertyName("changeLast48h")]
        public float? ChangeLast48h { get; set; }

        [JsonPropertyName("changeLast48hPercent")]
        public float? ChangeLast48hPercent { get; set; }

        [JsonPropertyName("low24hPrice")]
        public int? Low24hPrice { get; set; }

        [JsonPropertyName("high24hPrice")]
        public int? High24hPrice { get; set; }

        [JsonPropertyName("sellFor")]
        public ItemPrice[] SellFor { get; set; }
        
        [JsonPropertyName("buyFor")]
        public ItemPrice[] BuyFor { get; set; }

        [JsonPropertyName("containsItems")]
        public ContainedItem[] ContainsItem { get; set; }
    }
}