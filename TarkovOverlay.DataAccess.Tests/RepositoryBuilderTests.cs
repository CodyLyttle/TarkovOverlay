using System.IO;
using Xunit;

namespace TarkovOverlay.DataAccess.Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void CreateAndOverwriteDatabase_WithValidPath_CreatesNewDatabase()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "TestData.db");
            RepositoryBuilder.CreateAndOverwriteDatabase(path);
            Assert.True(File.Exists(path));
        }
    }
}