using HtmlAgilityPack;

namespace WebScrapApi.Crunchyroll
{
    public class CrunchyrollAPI
    {
        #region Get all Animeurls from Crunchyroll
        public async Task<List<string>> GetAllAnimeURLsAsync(Browser browser)
        {
            string url = "https://www.crunchyroll.com/de/videos/anime/alpha?group=all";
            var AnimeUrlList = new List<string>();

            var htmldocument = await Helper.GetPageDocument(browser, url);

            var List = htmldocument.DocumentNode.Descendants("div")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("videos-column-container cf")).ToList().FirstOrDefault();
            if (List != null)
            {
                var ListItems = List.Descendants("div")
                                       .Where(node => node.GetAttributeValue("class", "")
                                       .Equals("videos-column left")).ToList();
                if (ListItems.Count > 0)
                {
                    for (int j = 0; j < ListItems.Count; j++)
                    {
                        var item = ListItems[j].Descendants("a")
                                   .Where(node => node.GetAttributeValue("token", "")
                                   .Equals("shows-portraits")).ToList();

                        for (int z = 0; z < item.Count; z++)
                        {
                            var URL = "https://www.crunchyroll.com" + item[z].GetAttributeValue("href", "");
                            AnimeUrlList.Add(URL);
                            Console.WriteLine(URL);
                        }
                    }
                }
            }
            return AnimeUrlList;
        }
        #endregion

        #region Get an Anime from Crunchyroll with an url
        public async Task<Anime> GetAnimeByUrlAsync(string url)
        {
            var htmldocument = await Helper.GetPageDocument(url);

            var List = htmldocument.DocumentNode.Descendants("div")
                              .Where(node => node.GetAttributeValue("class", "")
                              .Equals("cf new-template-body")).ToList().FirstOrDefault();

            var episodeList = List.Descendants("ul")
                              .Where(node => node.GetAttributeValue("class", "")
                              .Equals("list-of-seasons cf")).ToList().FirstOrDefault();
            var tags = await GetAnimeTagsAsyn(List);
            var anime = new Anime()
            {
                Image = await GetAnimeImageAsync(List),
                Name = await GetAnimeNameAsync(List),
                Rating = await GetAnimeRatingAsync(List),
                Tags = tags[1..],
                Description = await GetAnimeDescriptionAsync(List),
                Publisher = tags[0],
                Url = url,
                Seasons = await GetAnimeSeasonsAsync(List)
            };
            return anime;
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
            var img = side.Descendants("img")
                   .Where(node => node.GetAttributeValue("class", "")
                   .Equals("poster xsmall-margin-bottom")).ToList().FirstOrDefault();
            if (img != null)
            {
                return img.GetAttributeValue("src", "").Replace("wide", "full");
            }
            return "No Picture";
        }

        private async Task<string> GetAnimeDescriptionAsync(HtmlNode side)
        {
            string text = string.Empty;
            var inhalt1 = side.Descendants("span")
                   .Where(node => node.GetAttributeValue("class", "")
                   .Equals("trunc-desc")).ToList().FirstOrDefault();

            var inhalt2 = side.Descendants("span")
                   .Where(node => node.GetAttributeValue("class", "")
                   .Equals("more")).ToList().FirstOrDefault();

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
                return text = node.InnerText.Remove(0, 12);
            }
            return "No Description";
        }

        private async Task<string[]> GetAnimeTagsAsyn(HtmlNode side)
        {
            var a = side.Descendants("a")
                   .Where(node => node.GetAttributeValue("class", "")
                   .Equals("text-link")).ToList();
            if (a.Count > 0)
            {
                string[] tags = new string[a.Count];
                for (int i = 0; i < tags.Count(); i++)
                {
                    tags[i] = a[i].InnerText;
                }
                return tags;
            }
            return new string[0];
        }

        private async Task<string> GetAnimeRatingAsync(HtmlNode side)
        {
            var rating = side.Descendants("span")
               .Where(node => node.GetAttributeValue("class", "")
               .Equals("rating-widget-static-large")).ToList().FirstOrDefault();

            if (rating != null)
            {
                var r = rating.GetAttributeValue("content", "");
                return r;
            }

            return "No Ratings";
        }

        private async Task<Seasons[]> GetAnimeSeasonsAsync(HtmlNode list)
        {
            HtmlNode a = null;
            var SeasonList = new List<Seasons>();

            var seasonList = list.Descendants("ul")
                           .Where(node => node.GetAttributeValue("class", "")
                           .Contains("list-of-seasons")).ToList().FirstOrDefault();

            if (seasonList != null)
            {
                var seasons = list.Descendants("li")
                              .Where(node => node.GetAttributeValue("class", "")
                              .Contains("season")).ToList();

                foreach (var season in seasons)
                {
                    var seasonName = season.Descendants("a")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("season-dropdown")).ToList().FirstOrDefault();
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
                        Name = name,
                        Episodes = await GetAnimeEpisodes(season)
                    });
                }
            }
            else
            {

            }

            return SeasonList.ToArray();
        }
        private async Task<Episode[]> GetAnimeEpisodes(HtmlNode a)
        {
            var portraitGrid = a.Descendants("ul")
            .Where(node => node.GetAttributeValue("class", "")
            .Contains("portrait-grid")).ToList().FirstOrDefault();


            if (a != null)
            {
                var episodeList = portraitGrid.Descendants("li")
                                .Where(node => node.GetAttributeValue("class", "")
                                .Contains("hover-bubble")).ToList();

                if (episodeList.Count > 0)
                {
                    var script = a.Descendants("script").ToList();
                    int count = script.Count;
                    var episodes = new Episode[episodeList.Count];

                    for (int i = episodeList.Count - 1; i >= 0; i--)
                    {
                        episodes[i] = new Episode();
                        var img = await GetEpisodeImageAsync(episodeList[i]);
                        episodes[i].Url = "https://www.crunchyroll.com" + episodeList[i].Descendants("a").ToList().FirstOrDefault().GetAttributeValue("href", "");
                        episodes[i].Image = img;
                        string text = script[i].InnerText;
                        var scr = text.Split('"');
                        episodes[i].Name = scr[5];
                        episodes[i].Story = scr[9];
                    }

                    return episodes;
                }
            }
            return new Episode[0];
        }

        private async Task<string> GetEpisodeImageAsync(HtmlNode episode)
        {

            var next = episode.Descendants("img")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Equals("landscape")).ToList().FirstOrDefault();

            if (next != null)
            {
                var img = next.GetAttributeValue("data-thumbnailurl", "");
                if (string.IsNullOrEmpty(img))
                    img = next.GetAttributeValue("src", "");

                return img;
            }


            return "No Image found";
        }

        #endregion
    }
}
