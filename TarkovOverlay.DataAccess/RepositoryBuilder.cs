using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TarkovOverlay.DataAccess.Tests")]
namespace TarkovOverlay.DataAccess
{
    internal static class RepositoryBuilder
    {
        public static SQLiteConnection CreateAndOverwriteDatabase(string databaseFilePath)
        {
            RemoveExistingDatabase(databaseFilePath);

            string connStr = $"URI=file:{databaseFilePath}";
            SQLiteConnection connection = new(connStr);
            connection.Open();

            using SQLiteCommand command = new(connection);
            InitPriceSourceNamesTable(command); 
            InitRequirementsTypeTable(command);
            InitTagNamesTable(command);
            InitTraderNamesTable(command);
            InitItemsTable(command);
            InitAttachedItemsTable(command);
            InitTradersTable(command);
            InitItemTraderPricesTable(command);
            InitItemPricesTable(command);
            InitItemPriceRequirementsTable(command);
            InitItemTagsTable(command);

            return connection;
        }
        
         private static void RemoveExistingDatabase(string databaseFilePath)
        {
            if (File.Exists(databaseFilePath))
                File.Delete(databaseFilePath);
        }

        private static void InitPriceSourceNamesTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE PriceSourceNames (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, Value TEXT UNIQUE NOT NULL);";
            command.ExecuteNonQuery();
            command.CommandText =
                @"INSERT INTO PriceSourceNames (Value) VALUES ('prapor'), ('therapist'), ('fence'), ('skier'), ('peacekeeper'), ('mechanic'), ('ragman'), ('jaeger'), ('fleaMarket');";
            command.ExecuteNonQuery();
        }
        
        private static void InitRequirementsTypeTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE RequirementTypes (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, Value TEXT UNIQUE NOT NULL);";
            command.ExecuteNonQuery();
            command.CommandText =
                @"INSERT INTO RequirementTypes (Value) VALUES ('playerLevel'), ('loyaltyLevel'), ('questCompleted');";
            command.ExecuteNonQuery();
        }
        
        private static void InitTagNamesTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE TagNames (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, Value TEXT NOT NULL UNIQUE);";
            command.ExecuteNonQuery();
            command.CommandText =
                @"INSERT INTO TagNames (Value) VALUES ('ammo'), ('ammoBox'), ('armor'), ('backpack'), ('barter'),('container'), ('disabled'),('glasses'), ('grenade'),('gun'), ('headphones'),('helmet'), ('keys'),('markedOnly'), ('mods'),('noFlea'), ('pistolGrip'),('preset'), ('provisions'),('rig'), ('suppressor'),('unLootable'), ('wearable');";
            command.ExecuteNonQuery();
        }
        
        private static void InitTraderNamesTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE TraderNames (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, Value TEXT UNIQUE NOT NULL);";
            command.ExecuteNonQuery();
            command.CommandText =
                @"INSERT INTO TraderNames (Value) VALUES ('prapor'),('therapist'),('fence'),('skier'),('peacekeeper'),('mechanic'),('ragman'),('jaeger');";
            command.ExecuteNonQuery();
        }
        
        private static void InitItemsTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE Items (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, Guid TEXT UNIQUE NOT NULL, Name TEXT, NormalizedName TEXT, ShortName TEXT, BasePrice INTEGER NOT NULL, UpdatedAt TEXT, Width INTEGER NOT NULL, Height INTEGER NOT NULL, IconLink TEXT, IconLinkFallback TEXT NOT NULL, WikiLink TEXT, ImageLink TEXT, ImageLinkFallback TEXT NOT NULL, GridImageLink TEXT, GridImageLinkFallback TEXT NOT NULL, Avg24hPrice INTEGER, AccuracyModifier REAL, RecoilModifier REAL, ErgonomicsModifier REAL, HasGrid BOOLEAN, BlocksHeadphones BOOLEAN, Link TEXT, LastLowPrice INTEGER, ChangeLast48h REAL, ChangeLast48hPercent REAL, Low24hPrice INTEGER, High24hPrice INTEGER);";
            command.ExecuteNonQuery();
        }
        
        private static void InitAttachedItemsTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE AttachedItems (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, ParentItemId INTEGER REFERENCES Items (Id) NOT NULL, ChildItemId INTEGER REFERENCES Items (Id) NOT NULL, ChildCount REAL NOT NULL, ChildQuantity INTEGER NOT NULL);";
            command.ExecuteNonQuery();
        }

        private static void InitTradersTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE Traders (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, Guid TEXT UNIQUE NOT NULL, Name TEXT NOT NULL UNIQUE);";
            command.ExecuteNonQuery();
        }

        private static void InitItemTraderPricesTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE ItemTraderPrices (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, ItemId INTEGER REFERENCES Items (Id) NOT NULL, TraderId INTEGER NOT NULL REFERENCES Traders (Id), Price INTEGER NOT NULL);";
            command.ExecuteNonQuery();
        }

        private static void InitItemPricesTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE ItemPrices (Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, ItemId INTEGER REFERENCES Items (Id) NOT NULL, PriceSourceId INTEGER REFERENCES PriceSourceNames (Id), IsBuyPrice BOOLEAN NOT NULL, IsSellPrice BOOLEAN NOT NULL, Price INTEGER, Currency TEXT);";
            command.ExecuteNonQuery();
        }

        private static void InitItemPriceRequirementsTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE ItemPriceRequirements (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, ItemPriceId INTEGER REFERENCES ItemPrices (Id) NOT NULL, RequirementTypeId INTEGER REFERENCES RequirementTypes (Id) NOT NULL);";
            command.ExecuteNonQuery();
        }

        private static void InitItemTagsTable(IDbCommand command)
        {
            command.CommandText =
                @"CREATE TABLE ItemTags (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, ItemId INTEGER REFERENCES Items (Id) NOT NULL, ItemTagId INTEGER REFERENCES TagNames (Id) NOT NULL);";
            command.ExecuteNonQuery();
        }
    }
}