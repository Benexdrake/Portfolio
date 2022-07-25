using MongoDB;
using MongoDB.Driver;
using CrunchyrollAPI;
using CrunchyrollAPI.Crunchyroll;
using Web_Scraper.Classes;
using Web_Scraper.Crunchyroll;
using MongoDB.Bson;

namespace Web_Scraper
{
    public class Main
    {
        AnimeDocument animeDoc;
        Mongo_DB mongoDB;
        IMongoCollection<Anime> collection;
        API api;
        Menu menu;

        public Main()
        {
            api = new API(Browser.Standard);
            mongoDB = new Mongo_DB("mongodb://localhost:27017");
        }

        public void Start()
        {
            while (true)
            {
                string[] M = { "Crunchyroll", "Exit" };
                menu = new Menu(M);

                var index = menu.Run();

                switch (index)
                {
                    case 0:
                        collection = mongoDB.CrunchyrollDBLogin("Crunchyroll", "Animes");
                        animeDoc = new AnimeDocument(collection);
                        CrunchyrollMenu();
                        break;
                    case 1:
                        // Exit
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void CrunchyrollMenu()
        {
            string[] M = {"Weekly Update", "Full Update", "Back to Main Menu" };
            menu = new Menu(M);
            var index = menu.Run();

            switch (index)
            {
                case 0:
                    WeeklyUpdate();
                    break;
                case 1:
                    FullUpdate();
                    return;
                case 2:
                    return;
            }
        }
        private async Task FullUpdate()
        {
            Console.Clear();
            var urls = api.GetAllAnimesbyGroupAsync().Result;
            await animeDoc.CrunchyRollInsert(urls);
            await animeDoc.CrunchyRollUpdate(urls);
        }
        private async Task WeeklyUpdate()
        {
            Console.Clear();
            var urls = api.GetAnimeWeeklyUpdates().Result;
            await animeDoc.CrunchyRollInsert(urls);
            await animeDoc.CrunchyRollUpdate(urls);
        }
    }
}
