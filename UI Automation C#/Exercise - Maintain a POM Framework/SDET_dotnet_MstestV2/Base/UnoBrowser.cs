using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SDET_dotnet_MstestV2.Base
{
    public class UnoBrowser
    {
        IWebDriver driver;
        public enum Browser
        {
            Chrome
        }

        public IWebDriver CreateBrowser(Browser browser)
        {
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); //local webdriver
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.Navigate().GoToUrl("https://www.unosquare.com");
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public int countElements(String xpath)
        {
            int elements = driver.FindElements(By.XPath(xpath)).Count;
            return elements;
        }

        public List<IWebElement> FindElements(String xpath)
        {
            List<IWebElement> elements = new List<IWebElement>(driver.FindElements(By.XPath(xpath)));
            return elements;
        }

        public void MoveToElement(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
        }

    }
}
