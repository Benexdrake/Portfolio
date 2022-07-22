using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WebScrapApi
{
    public class Helper
    {
        private static readonly Regex Regex = new Regex(@"\\[uU]([0-9A-Fa-f]{4})");
        static IWebDriver driver;
        private static ChromeDriver Chrome()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--block-new-web-contents");
            return new ChromeDriver(options);
        }
        private static FirefoxDriver Firefox()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--block-new-web-contents");
            return new FirefoxDriver(options);
        }
        public static async Task<HtmlDocument> GetPageDocument(Browser browser, string url)
        {
            switch(browser)
            {
                case Browser.Firefox:
                    driver = Firefox();
                    break;
                case Browser.Chrome:
                    driver = Chrome();
                    break;
                    default:
                    driver = Firefox();
                    break;
            }
            driver.Navigate().GoToUrl(url);
            string page = ReplaceString(driver.PageSource);
            

            var doc = new HtmlDocument();
            doc.LoadHtml(page);
            return doc;
        }

        private static string ReplaceString(string n)
        {
            n = n.Replace("&lt;", "")
                 .Replace("&gt;", "")
                 .Replace("&quot;", "")
                 .Replace("&amp;", "")
                 .Replace("&szlig", "ß")
                 .Replace("&Auml", "Ä")
                 .Replace("auml", "ä")
                 .Replace("Ouml", "Ö")
                 .Replace("ouml", "ö")
                 .Replace("Uuml", "Ü")
                 .Replace("uuml", "ü")
                 .Replace("&lt;", "<")
                 .Replace("&gt;", ">");
            n = UnescapeUnicode(n);

            return n;
        }
        public static string UnescapeUnicode(string str)
        {
            return Regex.Replace(str,
                match => ((char)int.Parse(match.Value.Substring(2),
                    NumberStyles.HexNumber)).ToString());
        }
    }
}
