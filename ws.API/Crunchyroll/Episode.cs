using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Crunchyroll
{
    public class Episode
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Story")]
        public string Story { get; set; }

        [BsonElement("URL")]
        public string Url { get; set; }

        [BsonElement("Image")]
        public string Image { get; set; }
    }
}
