using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Automation
{
    class Program
    {
        IWebDriver driver;
        public IWebDriver SetUpDriver()
        {
            //driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); //local webdriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
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

        //region Facebook Locators
        By initialMessage = By.XPath("//h2[text()='Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida.']");
        By createAccount = By.XPath("//a[text()='Crear cuenta nueva']");
        By firstName = By.XPath("//input[@placeholder='Nombre']");
        By lastName = By.XPath("//input[@name='lastname']");
        By mobileNumber = By.XPath("//input[@name='reg_email__']");
        By newPwd = By.XPath("//input[@name='reg_passwd__']");
        By sixSense = By.XPath("//a[text()=' 6. Sexto sentido ']");//not real

        By termsC = By.XPath("//a[text()='Condiciones']");
        By titleTerms = By.XPath("//h2[text()='Condiciones del servicio']");
        By oneService = By.XPath("//a[text()=' 1. Los servicios que proporcionamos ']");
        By twoHow = By.XPath("//a[text()=' 2. Cómo se pagan nuestros servicios ']");
        By threeCommitments = By.XPath("//a[text()=' 3. Tus compromisos con Facebook y nuestra comunidad ']");
        By fourAdditional = By.XPath("//a[text()=' 4. Disposiciones adicionales ']");
        By fiveOther = By.XPath("//a[text()=' 5. Otras condiciones y políticas que se pueden aplicar a tu caso ']");

        By adsControl = By.XPath("//div[text()=' Controles de anuncios de Facebook ']");
        By privacyBasic = By.XPath("//div[text()=' Aspectos básicos de la privacidad ']");
        By cookiesPolicy = By.XPath("//div[text()=' Política de cookies ']");
        By dataPolicy = By.XPath("//div[text()=' Política de datos ']");
        By moreResources = By.XPath("//div[text()=' Más recursos ']");
        //endregion



        static void Main(string[] args)
        {
            IWebDriver Browser;
            IWebElement element;
            Program program = new Program();
            Browser = program.SetUpDriver();
            Browser.Url = "https://www.facebook.com/";

            //review initial message
            element = Browser.FindElement(program.initialMessage);
            Assert.AreEqual<string>(element.Text, "Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida.");

            // Click on create account
            element = Browser.FindElement(program.createAccount);
            program.Click(element);

            // fill information
            element = Browser.FindElement(program.firstName);            
            program.SendText(element,"Heriberto");

            element = Browser.FindElement(program.lastName);
            program.SendText(element, "Vasquez");

            element = Browser.FindElement(program.mobileNumber);
            program.SendText(element, "5564342426");

            element = Browser.FindElement(program.newPwd);
            program.SendText(element, "This is a password!");

            //element inexistent / try catch handled
            element = Browser.FindElement(program.sixSense);
            try
            {
                Assert.IsTrue(element.Displayed);
            }
            catch
            {
                Console.WriteLine("There is no six Sense jet!");
            }
            
            //2nd Test Case Go to terms

            element = Browser.FindElement(program.termsC);
            program.Click(element);

            //Validate terms title exists
            element = Browser.FindElement(program.titleTerms);
            Assert.IsTrue(element.Displayed);

            //Validate the 5 terms exists
            element = Browser.FindElement(program.oneService);
            Assert.IsTrue(element.Displayed);

            element = Browser.FindElement(program.twoHow);
            Assert.IsTrue(element.Displayed);

            element = Browser.FindElement(program.threeCommitments);
            Assert.IsTrue(element.Displayed);

            element = Browser.FindElement(program.fourAdditional);
            Assert.IsTrue(element.Displayed);

            element = Browser.FindElement(program.fiveOther);
            Assert.IsTrue(element.Displayed);
            program.Click(element);

            List<IWebElement> webElements = new List<IWebElement>();
            webElements.Add(Browser.FindElement(program.adsControl));
            webElements.Add(Browser.FindElement(program.privacyBasic));
            webElements.Add(Browser.FindElement(program.cookiesPolicy));
            webElements.Add(Browser.FindElement(program.dataPolicy));
            webElements.Add(Browser.FindElement(program.moreResources));

            for(int i = 0; i< webElements.Count; i++)
            {
                Console.WriteLine(webElements[i]);
            }

            Browser.Close();
            Browser.Quit();

        }

    }
}
