using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;

namespace CheckoutValidation.Pages
{
    public class CartPage
    {
        protected IWebDriver driver = Driver.CurrentDriver;

        private IWebElement CheckoutButton()
        {
            return driver.FindElement(By.Id("checkout"));
        }

        public void ProcceedCheckout()
        {
            CheckoutButton().Click();            
        }

    }
}