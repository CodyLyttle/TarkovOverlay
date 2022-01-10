using System.IO;

namespace TarkovOverlay.DataAccess
{
    internal static class RepositoryInfo
    {
        public const string DirectoryName = "Data";
        public const string DatabaseFileName = "TarkovData.db";

        public static readonly string FullPathToDatabase =
            Path.Combine(Directory.GetCurrentDirectory(), DirectoryName, DatabaseFileName);
    }
}