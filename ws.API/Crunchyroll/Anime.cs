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
        public string ID { get; set; }
        
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

      
        public string[] Tags { get; set; }

        
        public string Publisher { get; set; }
        
        public DateTime LastUpdate { get; set; } = DateTime.Now.AddHours(2);
        public override string ToString()
        {
            return $"{Name}\n\nDescription: {Description}\nUrl: {Url}\n\nImage: {Image}\n\nSeasons: {Seasons.Length}\n\nEpisodes: {Episodes}\n\nRating: {Rating}\n\nTags: {GetTags()}\n\nPublisher: {Publisher}";
        }

        public string GetTags()
        {
            string tags = string.Empty;

            if (Tags.Length > 1)
            {
                foreach (var tag in Tags)
                {
                    tags += tag + ", ";
                }
                return tags.Remove(tags.Length - 2, 1);
            }
            else
                return Tags[0];
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
