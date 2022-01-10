using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TarkovOverlay.Core.Enums;
using Xunit;

namespace TarkovOverlay.TarkovToolsApi.Tests
{
    public class TarkovToolsApiTests
    {
        private static readonly HttpClient HttpClient = new();
        private readonly TarkovToolsApi _testInstance;
        
        public TarkovToolsApiTests()
        {
            _testInstance = new TarkovToolsApi(HttpClient);
        }
        
        [Theory]
        [InlineData(ItemTag.Backpack)]
        [InlineData(ItemTag.Grenade)]
        [InlineData(ItemTag.Provisions)]
        public async Task GetItemsByType_RequestSpecificType_ReturnsOnlyItemsWithType(ItemTag type)
        {
           List<Core.Dto.Item> items = await _testInstance.GetItemsByType(type);
           Assert.All(items, item => item.Tags.Contains(type));
        } 
    }
}