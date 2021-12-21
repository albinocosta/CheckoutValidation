using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;
using NUnit.Framework;

namespace CheckoutValidation.Pages
{
    public class CheckoutCompletePage
    {
        protected IWebDriver driver = Driver.CurrentDriver;        

        private IWebElement SuccessOrderMessage()
        {
            return driver.FindElement(By.XPath("//h2[@class='complete-header']"));
        }

        public void VerifySuccesOrder()
        {
            string successmessage = SuccessOrderMessage().Text;
            Assert.AreEqual("THANK YOU FOR YOUR ORDER", successmessage);
        }
    }        
}