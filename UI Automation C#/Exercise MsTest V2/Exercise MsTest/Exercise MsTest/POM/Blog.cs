using OpenQA.Selenium;
using Exercise_MsTest.Base;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_MsTest.POM
{
    //Implement all neded to use Blog in the test class (Constructor, WebElements, etc)
    public class Blog: UnoPages
    {
        UnoBrowser browser;
        By blogT = By.XPath("//h1[text()= 'DIGITAL TRANSFORMATION BLOG']");
        [FindsBy(How = How.XPath, Using = "//h1[text()= 'DIGITAL TRANSFORMATION BLOG']")]
        private IWebElement blogTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='search-bar']")]
        private IWebElement searchBar { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@class='search-icon']")]
        private IWebElement searchIcon { get; set; }

        By qaElement = By.XPath("//a[text()='Quality Assurance']");
        [FindsBy(How = How.XPath, Using = "//a[text()='Quality Assurance']")]
        private IWebElement qualityText { get; set; }
        
        public Blog(): base()
        {
           
        }

        public Blog validateBlogElement()
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            browser.explicitWait(2500);
            Assert.IsTrue(blogTest.Displayed);
            Console.WriteLine("PASS!");
            return this;
        }

        public Blog validateQAElement()
        {
            browser.SendText(searchBar, "Quality Assurance");
            browser.Click(searchIcon); //Wait for element
            browser.waitForElement(3, qaElement);
            Assert.IsTrue(qualityText.Displayed);
            Console.WriteLine("PASS!");
            return this;
        }
    }
}
