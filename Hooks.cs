using TechTalk.SpecFlow;

namespace DemoForGovind
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void InitalizeBrowser()
        {
            Driver.StartBrowser(Driver.BrowserType.CHROME);
        }

        [AfterTestRun]
        public static void TerminateBrowser()
        {
            Driver.QuitBrowser();
        }
    }
}
