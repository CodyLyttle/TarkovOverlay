using TarkovOverlay.Core.Enums;

namespace TarkovOverlay.Core.Dto
{
    public struct UnlockRequirement
    {
        public UnlockCondition Condition { get; set; }
        public int Value { get; set; }
    }
}