using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace DemoForGovind.PageObjects
{
    class SearchResultPage
    {
        public ReadOnlyCollection<IWebElement> SearchResultList => Driver.browser.FindElements(By.CssSelector(".compArticleList > li"));
    }
}
