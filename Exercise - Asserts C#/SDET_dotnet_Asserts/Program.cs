using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoSquare_Maintenance
{
    class Program
    {
        IWebDriver driver;
        public IWebDriver SetUpDriver()
        {
            //driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); //local webdriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //region Google Locators
        By googleSearchBar = By.XPath("//input[@class='gLFyf gsfi']");
        By googleSearchIcon = By.XPath("//input[@name='btnK']");
        By unoSquareGoogleResult = By.XPath("//h3[text()='Unosquare: Digital Transformation Services | Agile Staffing ...']");
        //endregion

        //region UnoSquare Locators
        By unoSquareServicesMenu = By.XPath("//a[text()='Services']");
        By practiceAreas = By.XPath("//a[text()='Practice Areas']");
        By contactUs = By.XPath("//a[@href='/ContactUs' and @class='nav-link link-blue'] ");
        By ourDNA = By.XPath("//a[text()='Our Dna']");
        By articlesEvents = By.XPath("//a[text()='Articles & Events']");
        By digitalTransformation = By.XPath("//h2[text()='Distributed agile teams for your digital transformation']");
        //endregion 

        #region UnoSquare Locators
        By UnoSquareServicesMenu = By.XPath("need maintenance");
        By PracticeAreas = By.XPath("need maintenance");
        By ContactUs = By.XPath("need maintenance");
        #endregion 
        static void Main(string[] args)
        {

            IWebDriver Browser;
            IWebElement element;
            Program program = new Program();
            Browser = program.SetUpDriver();
            Browser.Url = "https://www.google.com";

            //Write the locator for the Google Search Bar
            element = Browser.FindElement(program.googleSearchBar);
            Assert.IsTrue(element.Displayed); // Write Assert True that element is present [Google Search] button

            //Send the text "Unosquare" to the Text Bar
            program.SendText(element, "Unosquare");

            // Click on the Search Button
            element = Browser.FindElement(program.googleSearchIcon);
            program.Click(element);
            
            // Locate the first result corresponding to Unosquare and click on the Link
            element = Browser.FindElement(program.unoSquareGoogleResult);
            Assert.AreEqual<string>(element.Text, "Unosquare: Digital Transformation Services | Agile Staffing ...");// Write Assert Equal [Unosquare: Digital Transformation Services | Agile Staffing ...] vs [Element.text]
            program.Click(element);


            element = Browser.FindElement(program.ourDNA);
            Assert.IsTrue(element.Displayed);// Write Assert True that element is present [Our Dna] menu object

            element = Browser.FindElement(program.articlesEvents);
            Assert.IsTrue(element.Displayed);// Write Assert True that element is present [Articles & Events] menu object

            element = Browser.FindElement(program.digitalTransformation);
            Assert.AreEqual<string>(element.Text, "DISTRIBUTED AGILE TEAMS FOR YOUR DIGITAL TRANSFORMATION");// Write Assert Equal [Digital transformation solutions] vs [Element.text] h2 ojbect

            //Locate the Service Menu and Click the element
            element = Browser.FindElement(program.unoSquareServicesMenu);

            program.Click(element);

            //Locate the Practice Areas Menu and Click the Element
            element = Browser.FindElement(program.practiceAreas);

            program.Click(element);

            //Locate the Contact Us Menu and Click the Element
            element = Browser.FindElement(program.contactUs);

            program.Click(element);

            Browser.Close();
            Browser.Quit();

        }
    }
}
