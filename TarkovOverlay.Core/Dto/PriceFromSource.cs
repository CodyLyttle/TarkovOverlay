using System;
using TarkovOverlay.Core.Enums;

namespace TarkovOverlay.Core.Dto
{
    public class PriceFromSource
    {
        public int Price { get; set; }
        public TarkovCurrency Currency { get; set; }
        public PriceSource Source { get; set; }
        public UnlockRequirement[] Requirements { get; set; } = Array.Empty<UnlockRequirement>();
    }
}