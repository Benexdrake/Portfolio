using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Globalization;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace API.Classes
{
    public class Helper
    {
        private static readonly Regex Regex = new Regex(@"\\[uU]([0-9A-Fa-f]{4})");
        public static IWebDriver Driver { get; set; }
        public static ChromeDriver Chrome()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--enable-precise-memory-info");
            //options.AddArgument("--disable-popup-blocking");
            //options.AddArgument("--enable-precise-memory-info");
            //options.AddArgument("--blink-settings=imagesEnabled=false");
            //options.AddArgument("--block-new-web-contents");
            options.AddArgument("--enable-javascript");
            return new ChromeDriver(options);
        }
        public static FirefoxDriver Firefox()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--enable-javascript");
            options.AddArgument("--block-new-web-contents");
            return new FirefoxDriver(options);
        }

        

        public static async Task<HtmlDocument> GetPageDocument(string url)
        {
            if (Driver == null)
                Driver = Firefox();
            Driver.Navigate().GoToUrl(url);
            string page = ReplaceString(Driver.PageSource);
            var doc = new HtmlDocument();
            doc.LoadHtml(page);
            return doc;
        }

        private static string ReplaceString(string n)
        {
            n = n.Replace("&quot;", "")
                 .Replace("&amp;", "")
                 .Replace("&szlig", "ß")
                 .Replace("&Auml", "Ä")
                 .Replace("auml", "ä")
                 .Replace("Ouml", "Ö")
                 .Replace("ouml", "ö")
                 .Replace("Uuml", "Ü")
                 .Replace("uuml", "ü")
                 .Replace("&lt;", @$"< ")
                 .Replace("&gt;", @$" > ");
            n = UnescapeUnicode(n);
            return n;
        }
        public static string UnescapeUnicode(string str)
        {
            return Regex.Replace(str,
                match => ((char)int.Parse(match.Value.Substring(2),
                    NumberStyles.HexNumber)).ToString());
        }

        public static void SaveAsJson(object animes, string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, animes);
            }
        }
    }
}
