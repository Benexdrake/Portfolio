using HtmlAgilityPack;
using API.Classes;
using MongoDB.Bson;

namespace API.Crunchyroll
{
    public class CR_API
    {
        string[] group = { "numeric", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        Browser browser;

        public CR_API(Browser browser)
        {
            this.browser = browser;
            switch (browser)
            {
                case Browser.Firefox:
                    Helper.Driver = Helper.Firefox();
                    break;
                case Browser.Chrome:
                    Helper.Driver = Helper.Chrome();
                    break;
                case Browser.Standard:

                    break;
                default:
                    break;
            }
        }

        #region Get all Animeurls from Crunchyroll
        public async Task<List<Anime>> GetAllAnimeURLsAsync()
        {
            string url = "https://www.crunchyroll.com/de/videos/anime/alpha?group=all";
            var AnimeUrlList = new List<Anime>();
            var htmldocument = await Helper.GetPageDocument(url);
            var List = FindNodesByDocument(htmldocument, "div", "class", "videos-column-container").Result.FirstOrDefault();
            var ListItems = FindNodesByNode(List, "div", "class", "videos-column").Result.ToList();
            for (int j = 0; j < ListItems.Count-1; j++)
            {
                var item = FindNodesByNode(ListItems[j], "a", "token", "shows-portraits").Result.ToList();
                foreach (var info in item)
                {
                    var name = info.InnerText;
                    AnimeUrlList.Add(new Anime()
                    {
                        Url = "https://www.crunchyroll.com" + info.GetAttributeValue("href", ""),
                        Name = name.Substring(8, name.Length - 12)
                    });
                }
            }
            return AnimeUrlList;
        }
        #endregion

        #region Get all Animeurls from Crunchyroll by Group from Number, a-z
        public async Task<List<Anime>> GetAllAnimesbyGroupAsync()
        {
            var AllAnimeByUrl = GetAllAnimeURLsAsync().Result;
            var AnimeUrlList = new List<Anime>();
            for (int i = 0; i < group.Length; i++)
            {
                string url = $"https://www.crunchyroll.com/de/videos/anime/alpha?group={group[i]}";
                var htmldocument = await Helper.GetPageDocument(url);
                var List = FindNodesByDocument(htmldocument,"ul","class", "landscape-grid").Result.ToList().FirstOrDefault();
                var ListItems = FindNodesByNode(List,"li","class","group-item").Result.ToList();    
                foreach (var item in ListItems)
                {
                    var URL = "https://www.crunchyroll.com" + item.Descendants("a").ToList().FirstOrDefault().GetAttributeValue("href", "");
                    var span = item.Descendants("span").ToList();
                    var name = span[0].InnerText;
                    bool isNumber = int.TryParse(span[1].InnerText.Replace("Videos", "").Replace(" ", ""), out int episode);

                    AnimeUrlList.Add(new Anime()
                    {
                        Name = name, Url = URL, Episodes = episode
                    });
                    Console.WriteLine($@"Anime: {name} - Episodes: {episode}");
                }
            }

            var difList = AllAnimeByUrl.Where(a => !AnimeUrlList.Any(a1 => a1.Url.Equals(a.Url))).ToList();
            foreach (var item in difList)
            {
                AnimeUrlList.Add(item);
            }
            return AnimeUrlList.OrderBy(o => o.Name).ToList();
        }
        #endregion

        #region Check for Weekly Updates
        public async Task<List<Anime>> GetAnimeWeeklyUpdates()
        {
            string url = "https://www.crunchyroll.com/de/videos/anime/updated";
            var AnimeUrlList = new List<Anime>();
            var htmldocument = await Helper.GetPageDocument(url);
            var List = FindNodesByDocument(htmldocument, "ul", "class", "portrait-grid").Result.ToList().FirstOrDefault();
            var ListItems = FindNodesByNode(List, "li","class","group-item").Result.ToList();
            foreach (var item in ListItems)
            {
                var shows = FindNodesByNode(item, "a", "token", "shows-portraits").Result.ToList();
                foreach (var info in shows)
                {
                    var name = FindNodesByNode(info, "span", "itemprop", "name").Result.ToList().FirstOrDefault().InnerText;
                    AnimeUrlList.Add(new Anime()
                    {
                        Url = "https://www.crunchyroll.com" + info.GetAttributeValue("href", ""),
                        Name = name
                    });
                    Console.WriteLine("Anime: " + name);
                }
            }
            return AnimeUrlList;
        }
        #endregion

        #region Get an Anime from Crunchyroll with an url
        public async Task<Anime> GetAnimeByUrlAsync(string url)
        {
            string tags = "No Tags";
            var htmldocument = await Helper.GetPageDocument(url);
            var List = FindNodesByDocument(htmldocument, "div", "class", "new-template-body").Result.ToList().FirstOrDefault();
            if (List != null)
            {
                var listBlock = FindNodesByNode(List, "ul", "class", "list-block").Result.ToList().FirstOrDefault();
                var listBlockLists = FindNodesByNode(listBlock, "li", "class", "large-margin-bottom").Result.ToList().Last();
                
                var a = listBlockLists.Descendants("a").ToList();
                var publisher = await GetPublisherAsync(a[0]);

                if (a.Count > 1)
                {
                    var tagList = new List<HtmlNode>();
                    for (int i = 1; i < a.Count - 2; i++)
                    {
                        tagList.Add(a[i]);
                    }
                    tags = await GetAnimeTagsAsyn(tagList);
                }

                var anime = new Anime()
                {
                    Id = ObjectId.GenerateNewId(),
                    Image = await GetAnimeImageAsync(List),
                    Name = await GetAnimeNameAsync(List),
                    Rating = await GetAnimeRatingAsync(List),
                    Tags = tags,
                    Description = await GetAnimeDescriptionAsync(List),
                    Publisher = publisher,
                    Url = url,
                    Seasons = await GetAnimeSeasonsAsync(List),
                };
                anime.Episodes = anime.EpisodesCount();
                return anime;
            }
            return null;
        }

        
        #endregion

        #region Get an Random Anime on Crunchroll
        public async Task<Anime> GetAnimeByRandomAsync()
        {
            var url ="https://www.crunchyroll.com/de/random/anime?random_ref=topbar";

            return await GetAnimeByUrlAsync(url);
        }
        #endregion

        #region Private Get Methods

        private async Task<string> GetAnimeNameAsync(HtmlNode List)
        {
            var name = List.Descendants("span").ToList().FirstOrDefault();
            if (name != null)
            {
                return name.InnerText;
            }
            return "No Name";
        }

        private async Task<string> GetAnimeImageAsync(HtmlNode side)
        {
            var img = FindNodesByNode(side,"img","class","poster").Result.ToList().FirstOrDefault();
            if (img != null)
            {
                return img.GetAttributeValue("src", "").Replace("wide", "full");
            }
            return "No Picture";
        }

        private async Task<string> GetAnimeDescriptionAsync(HtmlNode side)
        {
            var inhalt1 = FindNodesByNode(side, "span", "class", "trunc-desc").Result.ToList().FirstOrDefault();
            var inhalt2 = FindNodesByNode(side, "span", "class", "more").Result.ToList().FirstOrDefault();
            if (inhalt1 != null)
            {
                HtmlNode node;
                if (inhalt2 != null)
                {
                    node = inhalt2;
                }
                else
                {
                    node = inhalt1;
                }
                return node.InnerText.Remove(0, 12);
            }
            return "No Description";
        }
        private async Task<string> GetAnimeTagsAsyn(List<HtmlNode> a)
        {
            string tags = string.Empty;
            foreach (var item in a)
            {
                tags += item.InnerText + ", ";
            }

            if(!string.IsNullOrWhiteSpace(tags))
                tags = tags.Substring(0, tags.Length - 2);

            return tags;
        }
        private async Task<string> GetPublisherAsync(HtmlNode a)
        {
            return a.InnerText;
        }
        private async Task<string> GetAnimeRatingAsync(HtmlNode side)
        {
            var rating = FindNodesByNode(side, "span", "class", "rating").Result.ToList().FirstOrDefault();
            if (rating != null)
            {
                var r = rating.GetAttributeValue("content", "");
                return r;
            }

            return "No Ratings";
        }
        private async Task<Seasons[]> GetAnimeSeasonsAsync(HtmlNode list)
        {
            var SeasonList = new List<Seasons>();
            var seasons = FindNodesByNode(list, "li", "class", "season").Result.ToList();
            foreach (var season in seasons)
            {
                var seasonName = FindNodesByNode(season, "a","class", "season-dropdown").Result.ToList().FirstOrDefault();
                string name;
                if (seasonName != null)
                {
                    name = seasonName.InnerText;
                }
                else
                {
                    name = "Season 1";
                }

                SeasonList.Add(new Seasons()
                {
                    Id = ObjectId.GenerateNewId(),
                    Name = name,
                    Episodes = await GetAnimeEpisodes(season)
                });
            }
            return SeasonList.ToArray();
        }
        private async Task<Episode[]> GetAnimeEpisodes(HtmlNode list)
        {
            var portraitGrid = FindNodesByNode(list, "ul", "class", "portrait-grid").Result.ToList().FirstOrDefault();
            var episodeList = FindNodesByNode(portraitGrid, "li", "class", "hover-bubble").Result.ToList();
            if (episodeList.Count > 0)
            {
                var script = list.Descendants("script").ToList();
                int count = script.Count;
                var episodes = new Episode[episodeList.Count];
                for (int i = episodeList.Count - 1; i >= 0; i--)
                {
                    episodes[i] = new Episode();
                    var img = await GetEpisodeImageAsync(episodeList[i]);
                    episodes[i].Id = ObjectId.GenerateNewId();
                    episodes[i].Url = "https://www.crunchyroll.com" + episodeList[i].Descendants("a").ToList().FirstOrDefault().GetAttributeValue("href", "");
                    episodes[i].Image = img;
                    string text = script[i].InnerText;
                    var scr = text.Split('"');
                    episodes[i].Name = scr[5];
                    episodes[i].Story = scr[9];
                }
                return episodes;
            }
            return new Episode[0];
        }
        private async Task<string> GetEpisodeImageAsync(HtmlNode episode)
        {
            var next = FindNodesByNode(episode, "img", "class", "landscape").Result.ToList().FirstOrDefault();
            if (next != null)
            {
                var img = next.GetAttributeValue("data-thumbnailurl", "");
                if (string.IsNullOrEmpty(img))
                    img = next.GetAttributeValue("src", "");
                return img;
            }
            return "No Image found";
        }
        private async Task<List<HtmlNode>> FindNodesByNode(HtmlNode node,string a, string b, string c)
        {
            return node.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
        }
        private async Task<List<HtmlNode>> FindNodesByDocument(HtmlDocument document, string a, string b, string c)
        {
            return document.DocumentNode.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
        }
        #endregion
    }
}
