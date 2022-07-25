using MongoDB.Bson;
using MongoDB.Driver;
using API.Crunchyroll;

namespace WSUpdater.Classes
{
    public class Mongo_DB
    {
        MongoClient client;
        IMongoCollection<Anime> animeCollection;

        public Mongo_DB(string connectionString)
        {
            client = new MongoClient(connectionString);
        }

        public IMongoCollection<Anime> MyProperty { get; set; }

        public IMongoCollection<Anime> CrunchyrollDBLogin(string databaseName, string collectionName)
        {
            var db = client.GetDatabase(databaseName);
            animeCollection = db.GetCollection<Anime>(collectionName);
            return animeCollection;
        }
    }
}
