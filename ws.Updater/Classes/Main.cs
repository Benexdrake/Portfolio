using MongoDB.Driver;
using API.Crunchyroll;
using WSUpdater.Crunchyroll;
using API;

namespace WSUpdater.Classes
{
    public class Main
    {
        AnimeDocument animeDoc;
        Mongo_DB mongoDB;
        IMongoCollection<Anime> collection;
        CR_API api;
        Menu menu;

        public Main()
        {
            api = new CR_API(Browser.Standard);
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
            string[] M = { "Weekly Update", "Full Update", "Back to Main Menu" };
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
