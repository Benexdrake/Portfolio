using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using API.Crunchyroll;
using API;

namespace WSUpdater.Crunchyroll
{
    internal class AnimeDocument
    {
        IMongoCollection<Anime> Collection;
        
        CR_API api;
        public AnimeDocument(IMongoCollection<Anime> Collection)
        {
            this.Collection = Collection;
            api = new CR_API(Browser.Standard);
        }

        public async Task<bool> InsertAnimeAsync(Anime anime)
        {
            bool ok = false;
            try
            {
                anime.Episodes = anime.EpisodesCount();
                await Collection.InsertOneAsync(anime);
                ok = true;
            }
            catch (Exception)
            {
                Console.WriteLine("There was an Error with " + anime.Name);
            }
            return ok;
        }

        public async Task<bool> UpdateAnimeAsync(Anime anime, string id)
        {
            bool ok = false;
            try
            {
                anime.ID = id;
                Collection.ReplaceOne(x => x.ID.Equals(id), anime);
                ok = true;
            }
            catch (Exception)
            {
                Console.WriteLine("There was an Error with " + anime.Name);
            }
            return ok;
        }
        public async Task<List<Anime>> GetAnimesFromDB()
        {
            var list = await Collection.FindAsync(new BsonDocument());
            var l = list.ToList();
            return l;
        }

        public async Task<List<Anime>> CheckNotInDB(List<Anime> animeInfo)
        {
            var List = new List<Anime>();

            foreach (var item in animeInfo)
            {
               var results = from anime in Collection.AsQueryable()
                             where anime.Name.Equals(item.Name)
                             select anime;
                if(results.Count<Anime>() <= 0)
                {
                    Console.WriteLine("Found: " + item.Name);
                    List.Add(item);
                }
            }
            return List;
        }

        public async Task<List<Anime>> CheckforUpdates(List<Anime> animeInfo)
        {
            var List = new List<Anime>();

            foreach (var item in animeInfo)
            {
                var results = from anime in Collection.AsQueryable()
                              where anime.Name.Equals(item.Name) && anime.Episodes <= item.Episodes
                              select anime;
                if (results.Count<Anime>() <= 0)
                {
                    Console.WriteLine("Found: " + item.Name);
                    List.Add(item);
                }
            }
            return List;
        }

        public async Task CrunchyRollInsert(List<Anime> urls)
        {
            var newlist = new List<Anime>();
            foreach (var url in urls)
                newlist.Add(url);
            // Check for New Animes
            var check = CheckNotInDB(newlist).Result;
            if (check.Count > 0)
            {
                // Alle die nicht in der DB sind, werden Insert
                for (int i = 0; i < check.Count; i++)
                {
                    Console.WriteLine("Searching for Insert: " + check[i].Url);
                    var anime = api.GetAnimeByUrlAsync(check[i].Url).Result;
                    if (anime != null)
                    {
                        Console.WriteLine($">>>> Insert {i + 1}/{check.Count} : " + check[i].Name);
                        var ok = InsertAnimeAsync(anime).Result;

                        if (ok)
                        {
                            Console.WriteLine("<><><> Inserted: " + check[i].Name);
                            Console.WriteLine("");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cant load Anime, maybe Hentai..., without Login not possible, will be in V2");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Inserts...");
            }
        }
        public async Task CrunchyRollUpdate(List<Anime> urls)
        {
            var newlist = new List<Anime>();
            foreach (var url in urls)
                newlist.Add(url);
            Anime anime = null;

            //var AnimesDB = GetAnimesFromDB().Result;
            var check = CheckforUpdates(newlist).Result;

            if (check.Count > 0)
            {
                for (int i = 0; i < newlist.Count; i++)
                {
                    // Update
                    Console.WriteLine(">>>>>> Update: " + check[i].Url);
                    anime = api.GetAnimeByUrlAsync(check[i].Url).Result;
                    if (anime != null)
                    {
                        var id = check.Where(x => x.Name.Equals(anime.Name)).ToList().FirstOrDefault();
                        if (id != null)
                        {
                            var ok = UpdateAnimeAsync(anime, id.ID).Result;
                            if(ok)
                            {
                                Console.WriteLine("<><><> Updated: " + check[i].Name);
                                Console.WriteLine("");
                                continue;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No Updates...");
            }
            Console.WriteLine("Press Key...");
            Console.ReadKey();

        }

    }
}
