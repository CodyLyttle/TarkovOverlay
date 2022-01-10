using TarkovOverlay.Core.Enums;
using TarkovOverlay.TarkovToolsApi.Internal;
using Xunit;

namespace TarkovOverlay.TarkovToolsApi.Tests
{
    public class Tests
    {
        [Fact]
        public void GetEnumString_ValidEnumValue_ReturnsEnumNameAsLowerCaseString()
        {
            string expected = "gun";
            string actual = HttpRequestHelper.GetEnumString(ItemTag.Gun);

            Assert.Equal(expected, actual);
        }
    }
}