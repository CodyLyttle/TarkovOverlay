using System.Data;
using System.Data.SQLite;
using System.IO;

namespace TarkovOverlay.DataAccess
{
    public sealed class Repository : IRepository
    {
        private SQLiteConnection? _connection = null;

        public void OverwriteDatabase()
        {
            _connection = RepositoryBuilder.CreateAndOverwriteDatabase(RepositoryInfo.FullPathToDatabase);
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}