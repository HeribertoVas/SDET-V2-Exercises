using OpenQA.Selenium;
using Exercise_MsTest.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_MsTest.POM
{
    public class HomePage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.= 'Practice Areas' and @class = 'nav-link']")]
        private IWebElement PracticeAreas { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.= 'Blog' and @class = 'nav-link']")]
        private IWebElement Blog { get; set; }
        public HomePage() : base()
        {

        }

        public HomePage GoToServicesAndPracticeAreas()
        {
            browser.Click(ServicesMenu);
            browser.Click(PracticeAreas);
            return this;
        }
        public HomePage GoToBlog()
        {
            browser.Click(Blog);
            return this;
        }
    }
}
