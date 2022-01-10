using System;
using System.Net.Http;
using System.Text;
using TarkovOverlay.TarkovToolsApi.Enums;
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
            string actual = HttpRequestHelper.GetEnumString(ItemType.Gun);

            Assert.Equal(expected, actual);
        }
    }
}