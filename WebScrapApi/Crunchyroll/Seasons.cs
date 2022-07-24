using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebScrapApi.Crunchyroll
{
    public class Seasons
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Episodes")]
        public Episode[] Episodes { get; set; }
    }
}
