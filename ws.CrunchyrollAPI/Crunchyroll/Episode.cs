using MongoDB.Bson.Serialization.Attributes;

namespace CrunchyrollAPI.Crunchyroll
{
    public class Episode
    {
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
