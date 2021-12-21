using System;
using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;

using static CheckoutValidation.Utils.Selenium.Settings;

namespace CheckoutValidation.Pages
{
    public class InventaryPage
    {
        protected IWebDriver driver = Driver.CurrentDriver;
        private IWebElement AddBackPack()
        {
            return driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        }
        private IWebElement AddBikeLight()
        {
            return driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        }
        private IWebElement CartButton()
        {
            return driver.FindElement(By.Id("shopping_cart_container"));
        }

        public void AddItens()
        {
            AddBackPack().Click();
            AddBikeLight().Click();
            CartButton().Click();
        }
    }
}