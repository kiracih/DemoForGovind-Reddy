using System;
using System.Threading;
using DemoForGovind.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace DemoForGovind.StepDefinitions
{
    [Binding]
    public sealed class SearchSteps
    {
        private readonly ScenarioContext _context;
        private readonly HomePage _homePage;
        private readonly SearchResultPage _searchResultPage;
        private string _searchTerm;

        public SearchSteps(ScenarioContext injectedContext)
        {
            _context = injectedContext;
            _homePage = new HomePage();
            _searchResultPage = new SearchResultPage();
        }

        [Given(@"I have opened '(.*)' homepage")]
        public void GivenIHaveOpenedHomepage(string websiteName)
        {
            string websiteUrl = $"https://{websiteName}.com";
            Driver.browser.Url = websiteUrl;
        }

        [When(@"I click Search icon on the left")]
        public void WhenIClickIconOnTheLeft()
        {
            _homePage.SearchButton.Click();
        }

        [When(@"I enter '(.*)' for search term")]
        public void WhenIEnterForSearchTerm(string searchTerm)
        {
            _searchTerm = searchTerm;
            _homePage.SearchInputBox.SendKeys(searchTerm);
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            _homePage.SearchInputBox.SendKeys(Keys.Return);
        }

        [Then(@"I should see search result page")]
        public void ThenIShouldSeeSearchResultPage()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.browser.Title.Contains("TechCrunch Search Results"));
        }
        
        [Then(@"I should see search term in the results")]
        public void ThenIShouldSeeSearchTermİnTheResults()
        {
            foreach (var searchResult in _searchResultPage.SearchResultList)
            {
                string searchResultTitle = searchResult.FindElement(By.XPath(".//h4")).Text;
                string searchResultContent = searchResult.FindElement(By.XPath(".//p[@class=\"fz-14 lh-20 c-777\"]")).Text;

                Assert.IsTrue(searchResultTitle.Contains(_searchTerm) || searchResultContent.Contains(_searchTerm));
            }
        }
    }
}
