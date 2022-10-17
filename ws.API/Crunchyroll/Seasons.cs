using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Crunchyroll
{
    public class Seasons
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Episodes")]
        public Episode[] Episodes { get; set; }
    }
}
