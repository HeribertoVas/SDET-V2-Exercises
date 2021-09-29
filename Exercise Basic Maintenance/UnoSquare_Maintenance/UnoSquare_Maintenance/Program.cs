using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnoSquare_Maintenance
{
    class Program
    {
        static IWebDriver driver;
        public IWebDriver SetUpDriver()
        {
            //driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); local webdriver
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
        By googleSearIcon = By.XPath("//input[@name='btnK']");
        By unoSquareGoogleResult = By.XPath("//h3[text()='Unosquare: Digital Transformation Services | Agile Staffing ...']");
        //endregion

        //region UnoSquare Locators
        By UnoSquareServicesMenu = By.XPath("//a[text()='Services']");
        By PracticeAreas = By.XPath("//a[text()='Practice Areas']");
        By ContactUs = By.XPath("//a[@href='/ContactUs' and @class='nav-link link-blue'] ");
        //endregion 

        static void Main(string[] args)
        {
            IWebDriver Browser;
            IWebElement element;
            Program program = new Program();
            Browser = program.SetUpDriver();
            Browser.Url = "https://www.google.com";

            element = Browser.FindElement(program.googleSearchBar);

            program.SendText(element, "Unosquare");

            element = Browser.FindElement(program.googleSearIcon);

            program.Click(element);

            element = Browser.FindElement(program.unoSquareGoogleResult);

            program.Click(element);

            element = Browser.FindElement(program.UnoSquareServicesMenu);

            program.Click(element);

            element = Browser.FindElement(program.PracticeAreas);

            program.Click(element);

            element = Browser.FindElement(program.ContactUs);

            program.Click(element);

            Browser.Close();
        }
    }
}
