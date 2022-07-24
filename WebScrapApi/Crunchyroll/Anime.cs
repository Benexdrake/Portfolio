using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebScrapApi.Crunchyroll
{
    public class Anime
    {
        private int episodes;

        [BsonId]
        [BsonElement("ID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Episodes")]
        public int Episodes 
        { 
            get 
            {
                if(episodes <= 0)
                {
                    return EpisodesCount();
                }
                return episodes;
            } 
            set 
            {
                episodes = value;
            } 
        }

        [BsonElement("Seasons")]
        public Seasons[] Seasons { get; set; }

        [BsonElement("Url")]
        public string Url { get; set; }

        [BsonElement("Image")]
        public string Image { get; set; }

        [BsonElement("Rating")]
        public string Rating { get; set; }

        [BsonElement("Tags")]
        public string[] Tags { get; set; }

        [BsonElement("Publisher")]
        public string Publisher { get; set; }

        public override string? ToString()
        {
            string tags = string.Empty;

            if (Tags.Length > 1)
            {
                foreach (var tag in Tags)
                {
                    tags += tag + ", ";
                }
                tags = tags.Remove(tags.Length - 2, 1);
            }
            else
                tags = Tags[0];

            return $"{Name}\n\nDescription: {Description}\nUrl: {Url}\n\nImage: {Image}\n\nSeasons: {Seasons.Length}\n\nEpisodes: {Episodes}\n\nRating: {Rating}\n\nTags: {tags}\n\nPublisher: {Publisher}";
        }

        public int EpisodesCount()
        {
            int n = 0;
            foreach (var season in Seasons)
            {
                foreach (var episode in season.Episodes)
                {
                    n++;
                }
            }
            return n;
        }
    }
}
