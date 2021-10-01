using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Exercise_MsTest.Base
{
    public class UnoBrowser
    {
        public enum Browser
        {
            Chrome
        }
        IWebDriver driver;
        public IWebDriver CreateBrowser(Browser browser)
        {
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public void explicitWait(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        //This method wait the element until it exists
        public void waitForElement(int seconds, By xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(xpath));
        }
    }
}
