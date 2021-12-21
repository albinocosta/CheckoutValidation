using System;
using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;

using static CheckoutValidation.Utils.Selenium.Settings;

namespace CheckoutValidation.Pages
{
    public class LoginPage
    {
        protected IWebDriver driver = Driver.CurrentDriver;  
        

        public void NavigateLoginUrl()
        {
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
            Console.WriteLine(" :: The Login URL is navigated to");
        }    

        private IWebElement UserName()
        {
            return driver.FindElement(By.Id("user-name"));
        }

        private IWebElement Password()
        {
            return driver.FindElement(By.Id("password"));
        }

        private IWebElement LoginButton()
        {
            return driver.FindElement(By.Id("login-button"));
        }

        public void LoginSauce()
        {
            UserName().SendKeys("standard_user");
            Password().SendKeys("secret_sauce");
            LoginButton().Click();
        }
    }
}