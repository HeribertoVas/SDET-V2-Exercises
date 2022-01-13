using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Exercise_3_MS_Test.Base
{    
    class Pages
    {
        public Browser browser;
        protected IWebDriver driver;
        public Pages()
        {
            browser = new Browser();
            driver = browser.CreateBrowser();
            PageFactory.InitElements(driver, this);
        }
    }
}
