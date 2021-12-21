using CheckoutValidation.Utils.Selenium;
using TechTalk.SpecFlow;

namespace CheckoutValidation.Utils.Hooks
{
    internal static class TestRunHooks
    {
        [AfterTestRun]
        internal static void AfterTestRun()
        {
            Driver.CurrentDriver.Quit();
        }
    }
}