using API.Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace API.Amazon
{
    public class Amazon_Api
    {
        // Login Methode -- Username und Password eingeben und den Button klicken.

        // Seite öffnen und nach Button suchen, diesen klicken und in den Warenkorb legen.

        // Benachrichtigung per Email oder SMS dass dieser Artikel vorhanden ist.

        private readonly string username;
        private readonly string password;

        IWebDriver web;

        public Amazon_Api(string _username, string _password, bool seeBrowser)
        {
            username = _username;
            password = _password;
            if(seeBrowser)
            {
                web = new FirefoxDriver();
            }
            else
            {
                web = Helper.Firefox();
            }
            
        }

        public async Task CheckCookies(string id)
        {
            // Amazon sp-cc-accept --Cookie ID from Amazon
            try
            {
                await SendClick(id);
            }
            catch (Exception)
            {
                Console.WriteLine("No Cookie Button found");
            }
        }

        public async Task<Amazon_Api> SendClick(string id)
        {
            web.FindElement(By.Id(id)).Click();
            await Task.Delay(1000);
            return this;
        }

        public async Task<Amazon_Api> SendKeys(string id, string key)
        {
            foreach (var k in key)
            {
                web.FindElement(By.Id(id)).SendKeys(k.ToString());
                await Task.Delay(100);
            }
            return this;
        }
        
        public async Task Login()
        {
            web.Navigate().GoToUrl("https://www.amazon.de");

            await CheckCookies("sp-cc-accept");

            SendClick("nav-signin-tooltip");
            try
            {
                SendKeys("ap_email", username).Result.SendClick("continue");
                
                SendKeys("ap_password", password).Result.SendClick("signInSubmit");
            }
            catch (Exception)
            {
            }
        }

        public async Task<bool> Preorder(string url, bool buytheItem)
        {
            web.Navigate().GoToUrl(url);
            var i = web.FindElement(By.Id("buy-now-button"));
            await Task.Delay(1000);
            if (i != null)
            {
                if (buytheItem)
                {
                    i.Click();
                    BuyItem();
                }
                else
                {
                    var item = url.Split('/');
                    // Send Email
                    await SendEmail(url,item[3], false);
                }
                return true;
            }
            return false;
        }

        public async Task SendEmail(string url,string itemName, bool istBestellt)
        {
            Console.WriteLine(url);
            Console.WriteLine(itemName);
            // Sendet Email mit dem Link und dem Namen
            // Wenn istBestellt = true, anderer Text in der Email als bei false ein Text der aussagt, die Ware ist im Warenkorb und kann jederzeit bestellt werden.
        }

        public async Task BuyItem()
        {
            // Legt die Ware in den Warenkorb

            // Geht in den Warenkorb und drückt auf bezahlen

            // Überprüft ob bestimmte Html Tags vorhanden sind und klickt dann um die Ware zu bestellen.
        }
    }
}
