using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class About : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'About' and @class = 'nav-link']")]
        private IWebElement AboutMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[.= 'Personal']")]
        private IWebElement PersonalSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[.= 'Professional']")]
        private IWebElement ProfessionalSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[.= 'Social']")]
        private IWebElement SocialSection { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//h3[.= 'Leadership Team']")]
        private IWebElement leaderShipTeam { get; set; }
        public About() : base()
        {

        }

        public About GoToAbout()
        {
            browser.Click(AboutMenu);
            return this;
        }

        public About ValidateSections()
        {
            Assert.IsTrue(PersonalSection.Displayed);
            Assert.IsTrue(ProfessionalSection.Displayed);
            Assert.IsTrue(SocialSection.Displayed);
            Console.Write("Section validation PASSED!!");
            return this;
        }

        public About LeaderShipTeam()
        {
            browser.MoveToElement(leaderShipTeam);
            Assert.IsTrue(leaderShipTeam.Displayed);
            List<IWebElement> nameElements = browser.FindElements("//span[@class= 'name']");
            List<IWebElement> positions = browser.FindElements("//span[@class= 'rol']");

            for ( int i =0; i < nameElements.Count-1; i++)
            {
                Console.Write("\nName: "+nameElements[i].Text+"\n");
                Console.Write("Rol: "+positions[i].Text);
            }
            
            return this;
        }
    }
}
