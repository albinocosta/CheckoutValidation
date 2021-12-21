using System;
using OpenQA.Selenium;
using CheckoutValidation.Utils.Selenium;
using NUnit.Framework;

namespace CheckoutValidation.Pages
{
    public class CheckoutStepTwoPage
    {
        protected IWebDriver driver = Driver.CurrentDriver;        

        private IWebElement SubTotal()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_subtotal_label']"));
        }
        private IWebElement Tax()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_tax_label']"));
        }
        private IWebElement Total()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_total_label']"));
        }

        private IWebElement FinishButton()
        {
            return driver.FindElement(By.Id("finish"));
        }

        public void VerifyOrderAmount()
        {
            string subTotal = SubTotal().Text;
            string tax = Tax().Text;
            string total = Total().Text;

            double ProductSum = double.Parse(subTotal.Replace("Item total: $", ""));
            double Taxes = double.Parse(tax.Replace("Tax: $", ""));
            double Totalamount = double.Parse(total.Replace("Total: $", ""));            
            Assert.AreEqual(Totalamount, (ProductSum + Taxes));

            Console.WriteLine(ProductSum);
            Console.WriteLine(Taxes);
            Console.WriteLine(Totalamount);
        }

        public void FinishOrder()
        {
            FinishButton().Click();
        }
        
    }
}