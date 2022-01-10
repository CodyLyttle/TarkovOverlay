using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TarkovOverlay.TarkovToolsApi.Enums;
using TarkovOverlay.TarkovToolsApi.Models;
using Xunit;
using Xunit.Abstractions;

namespace TarkovOverlay.TarkovToolsApi.Tests
{
    public class TarkovToolsApiTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private static readonly HttpClient HttpClient = new();
        private readonly TarkovToolsApi _testInstance;
        
        public TarkovToolsApiTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testInstance = new TarkovToolsApi(HttpClient);
        }
        
        [Theory]
        [InlineData(ItemType.Backpack)]
        [InlineData(ItemType.Grenade)]
        [InlineData(ItemType.Provisions)]
        public async Task GetItemsByType_RequestSpecificType_ReturnsOnlyItemsWithType(ItemType type)
        {
           List<Item> items = await _testInstance.GetItemsByType(type);
           Assert.All(items, item => item.Types.Contains(type));
        } 
    }
}