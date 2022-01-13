using OpenQA.Selenium;
using Exercise_3_MS_Test.Base;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_MS_Test.POM
{
    class HomePage : Pages
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']")]
        private IWebElement iniciarSesion { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private IWebElement emailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement passwordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='twotabsearchtextbox']")]
        private IWebElement searchBar { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
        private IWebElement continueBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='signInSubmit']")]
        private IWebElement signBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'S9 Samsung Galaxy')])[1]")]
        private IWebElement galaxy9 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'S9 Samsung Galaxy')])[1]//following::span[@class='a-offscreen'][1]")]
        private IWebElement priceAdvertizedS9 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='a-price a-text-price a-size-medium']")]
        //[FindsBy(How = How.XPath, Using = "//span[@class='a-price aok-align-center a-text-bold priceSizeOverride']")]
        private IWebElement detailsPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='add-to-cart-button']")]
        private IWebElement addCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@aria-labelledby='attachSiNoCoverage-announce']")]
        private IWebElement noWarranty { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='nav-cart']")]
        private IWebElement cartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap sc-product-price a-text-bold'])[1]")]
        private IWebElement finalPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id = 'attach-close_sideSheet-link']")]
        private IWebElement attachCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id = 'nav-cart-count']")]
        private IWebElement totalInCar { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Alienware AW2720HF')])[2]")]
        private IWebElement alienware { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Alienware AW2720HF')])[2]//following::span[@class='a-offscreen'][1]")]
        private IWebElement priceAdvertizedAW {get; set;}

        private int inCar = 0;

        public HomePage() : base()
        {

        }

        public HomePage LoginAmazon()
        {
            browser.Click(iniciarSesion);
            //browser.SendText(emailInput, "ConfigurationManager.AppSettings["email"]); //UNCOMMENT THIS TO USE APP SETTINGS
            browser.SendText(emailInput, "email or phone");
            browser.Click(continueBtn);
            //browser.SendText(emailInput, "ConfigurationManager.AppSettings["password"]); //UNCOMMENT THIS TO USE APP SETTINGS
            browser.SendText(passwordInput, "password");
            browser.Click(signBtn);
            return this;
        }

		public HomePage VerifyGalaxyS9()
		{
			browser.SendText(searchBar, "Samsung Galaxy S9 64GB");
            browser.SendText(searchBar, Keys.Enter); //Search for Samsung Galaxy S20 FE 5G

			String priceAdvertized = priceAdvertizedS9.GetAttribute("innerHTML"); //Storage price
			Console.WriteLine("Price Advertized: " + priceAdvertized);

			browser.displayed(galaxy9); //Verify Item is displayed on the screen and  locate the first one, then store the price
			browser.Click(galaxy9); //Click on the First Result

            try
            {
                String detailPrice = detailsPrice.Text; //Storage price
                Console.WriteLine("detailsPrice: " + detailPrice);
                browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)

                browser.Click(addCartBtn); //Click on Add to Cart.
                attachCloseBtn.Click();
                browser.Click(cartIcon);

                String finalPriceTxt = finalPrice.Text; //Storage price
                Console.WriteLine("finalPrice: " + finalPriceTxt);

                browser.isEquals(priceAdvertized, finalPriceTxt);

                String totalInCa = totalInCar.Text;
                Console.WriteLine(totalInCa);
                browser.isEquals("1", totalInCa);
                inCar += 1;
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is no stock of this product");
                Console.WriteLine(ex);
            }
			

			return this;
		}

        public HomePage VerifyAlienware()
        {
            browser.GoToUrl("https://www.amazon.com.mx/");
            browser.SendText(searchBar, "Alienware AW2720HF");
            browser.SendText(searchBar, Keys.Enter); //Search for Samsung Galaxy S20 FE 5G

            String priceAdvertized = priceAdvertizedAW.GetAttribute("innerHTML"); //Storage price
            Console.WriteLine("Price Advertized: " + priceAdvertized);

            browser.displayed(alienware); //Verify Item is displayed on the screen and  locate the first one, then store the price
            browser.Click(alienware); //Click on the First Result

            String detailPrice = detailsPrice.Text; //Storage price
            Console.WriteLine("detailsPrice: " + detailPrice);
            browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)

            browser.Click(addCartBtn); //Click on Add to Cart.

            browser.Click(noWarranty);
            inCar += 1;
            //attachCloseBtn.Click();
			browser.Click(cartIcon);

			String finalPriceTxt = finalPrice.Text; //Storage price
			Console.WriteLine("finalPrice: " + finalPriceTxt);

			browser.isEquals(priceAdvertized, finalPriceTxt);
			String totalInCa = totalInCar.Text;
			Console.WriteLine(totalInCa);
            //IN case  there is no stock from product one the cart will have less items
            if(inCar==1)
            {
                browser.isEquals("1", totalInCa);
            }
            else
            {
                browser.isEquals("2", totalInCa);
            }
			

			return this;
		}
	}
}
