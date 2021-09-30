using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class HomePage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.= 'Practice Areas' and @class = 'nav-link']")]
        private IWebElement PracticeAreas { get; set; }
        public HomePage() : base()
        {
            
        }

        public HomePage GoToServicesAndPracticeAreas()
        {
            browser.Click(ServicesMenu);
            browser.Click(PracticeAreas);
            return this;
        }
    }
}
