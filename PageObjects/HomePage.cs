using OpenQA.Selenium;

namespace DemoForGovind.PageObjects
{
    class HomePage
    {
        public IWebElement SearchButton => Driver.browser.FindElement(By.ClassName("search-toggle"));
        public IWebElement SearchInputBox => Driver.browser.FindElement(By.Id("search-box-form__input"));
    }
}
