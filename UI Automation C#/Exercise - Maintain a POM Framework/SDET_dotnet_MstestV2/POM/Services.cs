using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class Services : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//h3[.= 'Trusted by industry leaders' and @class = 'subtitle']")]
        private IWebElement Trusted { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//div[@class= 'logos col-12 row' ]")]
        private IWebElement Leaders { get; set; }

        public Services() : base()
        {

        }
        public Services GoToServices()
        {
            browser.Click(ServicesMenu);
            return this;
        }

        public Services validateLeaders()
        {
            int leadersN = browser.countElements("//div[@class= 'logos col-12 row' ]//descendant::div");
            Console.WriteLine("There are: "+leadersN+" leaders displayed");
            Assert.IsTrue(Trusted.Displayed);
            return this;
        }
    }
}
