using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace DemoForGovind
{
    class Driver
    {
        public static IWebDriver browser;

        public static void StartBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.CHROME:
                    browser = new ChromeDriver();
                    break;
                case BrowserType.IE:
                    browser = new InternetExplorerDriver();
                    break;
                default:
                    browser = new ChromeDriver();
                    break;
            }
            browser.Manage().Window.Maximize();
        }

        public static void QuitBrowser()
        {
            browser.Quit();
        }

        public enum BrowserType
        {
            CHROME,
            IE
        }
    }
}
