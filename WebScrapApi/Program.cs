using WebScrapApi.Crunchyroll;
using WebScrapApi;
namespace WebScrapApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var api = new Crunchyroll_V1();

            // Get All Animes from https://www.crunchyroll.com/de/videos/anime/updated
            var info = api.GetAnimeUpdateList().Result;
            foreach (var item in info)
            {
                Console.WriteLine(item.Episodes);
            }

            // Get All Animes from https://www.crunchyroll.com/de/videos/anime/alpha by Group (numeric, a-z)
            var all = api.GetAllAnimesbyGroupAsync(Browser.Chrome).Result;
            foreach (var item in all)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}