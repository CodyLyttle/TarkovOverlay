using System;
using System.Collections.Generic;
using TarkovOverlay.Core.Enums;

namespace TarkovOverlay.Core.Dto
{
    public class Item
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<ItemTag> Tags { get; set; } = new();
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ShortName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool HasGrid { get; set; }
        public bool BlocksHeadphones { get; set; }
        public ItemUrls ItemUrls { get; set; }
        public ItemPrices Prices { get; set; }
        public List<AttachedItem> AttachedItems { get; set; } = new();
        public WeaponAttachment? WeaponAttachmentModifiers { get; set; }
        // TODO: Check whether WeaponAttachmentModifiers also apply to ammo and armor
        public bool IsWeaponAttachment => WeaponAttachmentModifiers != null;
        
    }
}