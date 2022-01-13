using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_MS_Test
{
    class BrowserInteraction
    {     
        public IWebElement findElement(IWebDriver driver, By xpath)
        {           
            return new WebDriverWait(driver, new TimeSpan(0, 0, 3)).Until(x => x.FindElement(xpath));
        }
        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        

        public void displayed(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
            Console.WriteLine("ON SCREEN!!");
        }

        
        public void isEquals(String str1, String str2)
        {
            Assert.AreEqual(str1, str2);
            Console.WriteLine("PASSED!!");
        }        
    }
}
