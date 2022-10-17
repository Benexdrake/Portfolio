using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Crunchyroll
{
    public class Anime
    {
        private int episodes;
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        public string Name { get; set; }

        
        public string Description { get; set; }

        
        public int Episodes
        {
            get
            {
                if (episodes <= 0)
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

        public Seasons[] Seasons { get; set; }

        
        public string Url { get; set; }

       
        public string Image { get; set; }

        
        public string Rating { get; set; }

      
        public string Tags { get; set; }

        
        public string Publisher { get; set; }
        
        //public DateTime LastUpdate { get; set; }
        public override string ToString()
        {
            return $"{Name}\n\nDescription: {Description}\nUrl: {Url}\n\nImage: {Image}\n\nSeasons: {Seasons.Length}\n\nEpisodes: {Episodes}\n\nRating: {Rating}\n\nTags: {Tags}\n\nPublisher: {Publisher}";
        }

        public int EpisodesCount()
        {
            int n = 0;
            if(Seasons != null)
            {
                foreach (var season in Seasons)
                {
                    foreach (var episode in season.Episodes)
                    {
                        n++;
                    }
                }
            }
            return n;
        }
    }
}
