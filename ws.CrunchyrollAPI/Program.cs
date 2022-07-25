using CrunchyrollAPI.Crunchyroll;
namespace CrunchyrollAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // All Webscraper in this Class / Browser Firefox or Chrome
            var api = new API(Browser.Firefox);
            
            // Get an Anime with Url
            var AnimeByUrl = api.GetAnimeByUrlAsync("https://www.crunchyroll.com/de/a-certain-magical-index").Result;

            // Get all Animes from https://www.crunchyroll.com/de/videos/anime/alpha?group=all
            var AllAnimeByUrl = api.GetAllAnimeURLsAsync().Result;

            // Get Animes from Updated https://www.crunchyroll.com/de/videos/anime/updated
            var AnimeByUpdate = api.GetAnimeWeeklyUpdates().Result;

            // Get Animes from https://www.crunchyroll.com/de/videos/anime/alpha / numeric, a to z, this is the longest Method and the best because of the Videos Counter, to check if there are new Videos
            var AnimeByGroup = api.GetAllAnimesbyGroupAsync().Result;
            
            


            var AnimeUrlList = new List<Anime>();
            // Looks for Animes in All and Group, to find the Animes, that are not listet on Group
            var difList = AllAnimeByUrl.Where(a => !AnimeUrlList.Any(a1 => a1.Url.Equals(a.Url))).ToList();
            foreach (var item in difList)
            {
                AnimeUrlList.Add(item);
            }
            var Animes = AnimeUrlList.OrderBy(o => o.Name).ToList();
        }
    }
}