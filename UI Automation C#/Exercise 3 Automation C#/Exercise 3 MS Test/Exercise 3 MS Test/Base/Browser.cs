using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace Exercise_3_MS_Test.Base
{
    class Browser: BrowserInteraction
    {
        IWebDriver driver;
        public IWebDriver CreateBrowser()
        {
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); //local webdriver
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.Navigate().GoToUrl("https://www.amazon.com.mx/");
            return driver;
        }

        public void GoToUrl(String url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
     

    }
}
