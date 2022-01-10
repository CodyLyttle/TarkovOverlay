using System;
using System.Collections.Generic;

namespace TarkovOverlay.Core.Dto
{
    public class ItemPrices
    {
        public int InternalValuation { get; set; }
        public int? LastLow { get; set; }
        public int? Low24Hour { get; set; }
        public int? High24Hour { get; set; }
        public int? Average24Hour { get; set; }
        public float? Change48Hour { get; set; }
        public float? Change48HourPercent { get; set; }
        public List<PriceFromSource> SpecificPrices { get; set; } = new();
    }
}