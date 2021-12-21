using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;

namespace CheckoutValidation.Pages
{
    public class CheckoutStepOnePage
    {
        protected IWebDriver driver = Driver.CurrentDriver;

        private IWebElement FirstName()
        {
            return driver.FindElement(By.Id("first-name"));
        }
        private IWebElement LastName()
        {
            return driver.FindElement(By.Id("last-name"));
        }
        private IWebElement PostalCode()
        {
            return driver.FindElement(By.Id("postal-code"));
        }
        private IWebElement ContinueButton()
        {
            return driver.FindElement(By.Id("continue"));
        }

        public void FillInPersonalInfo()
        {
            FirstName().SendKeys("Robert");
            LastName().SendKeys("Parker");
            PostalCode().SendKeys("4568785");            
        }

        public void ProcceedCheckoutStepTwo()
        {
            ContinueButton().Click();
        }

    }    
}