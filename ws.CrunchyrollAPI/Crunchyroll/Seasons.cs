

using MongoDB.Bson.Serialization.Attributes;

namespace CrunchyrollAPI.Crunchyroll
{
    public class Seasons
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Episodes")]
        public Episode[] Episodes { get; set; }
    }
}
