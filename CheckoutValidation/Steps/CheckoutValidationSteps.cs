using TechTalk.SpecFlow;
using CheckoutValidation.Pages;

namespace CheckoutValidation.Steps.LoginSteps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage = new ();
        private readonly InventaryPage inventaryPage = new ();
        private readonly CartPage cartPage = new ();
        private readonly CheckoutStepOnePage checkoutsteponePage = new ();
        private readonly CheckoutStepTwoPage checkoutsteptwoPage = new ();
        private readonly CheckoutCompletePage checkoutcompletePage = new ();

        [Given(@"I'm at Inventary page")] 
        public void GivenIAmOnLoginPage() 
        { 
            loginPage.NavigateLoginUrl();  
            loginPage.LoginSauce();           
        }

        [Given(@"I have added 2 products to the cart")] 
        public void AddTwoProductsCart() 
        { 
            inventaryPage.AddItens(); 
        }

        [When(@"I go to checkout")] 
        public void ProcceedCheckout() 
        { 
            cartPage.ProcceedCheckout(); 
        }

        [When(@"Fill in my basic information")] 
        public void FillInPersonalInfo() 
        { 
            checkoutsteponePage.FillInPersonalInfo();             
        }

        [When(@"go to checkout step two page")] 
        public void ProcceedCheckoutStepTwo() 
        { 
            checkoutsteponePage.ProcceedCheckoutStepTwo(); 
        }

        [Then(@"I can verify that the order amount is correct")] 
        public void VerifyOrderAmount() 
        { 
            checkoutsteptwoPage.VerifyOrderAmount();
        }

        [Then(@"I can complete the order")] 
        public void CompleteOrder() 
        {
            checkoutsteptwoPage.FinishOrder();
            checkoutcompletePage.VerifySuccesOrder();
        }       
        
    }
}