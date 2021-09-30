using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Automation
{
    class SetUpClass
    {
        IWebDriver driver;
        public IWebDriver SetUpDriver(string driverToSelect)
        {
            switch (driverToSelect)
            {
                case "Chrome":
                    driver = new ChromeDriver(@"C:\Users\heriberto.vasquez\Documents\WebDrivers\Chrome"); //local webdriver
                    //driver = new ChromeDriver();
                    break;
                case "Mozilla":
                    driver = new FirefoxDriver();
                    break;

            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://www.facebook.com/";
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
            Console.WriteLine("Element clicked");
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

        public void FillBDay(SetUpClass program, IWebElement element,string partOfDate)
        {
            program.SendText(element, partOfDate);
            Console.WriteLine(partOfDate);
        }

        public void AssertConfirmation(string text1, string text2)
        {
            Assert.AreEqual<string>(text1, text2);
            Console.WriteLine("PASSED!!");
        }

    }

    class ExecutionClass
    {
        #region Facebook Locators
        By initialMessage = By.XPath("//h2[text()='Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida.']");
        By createAccount = By.XPath("//a[text()='Crear cuenta nueva']");
        By firstName = By.XPath("//input[@placeholder='Nombre']");
        By lastName = By.XPath("//input[@name='lastname']");
        By mobileNumber = By.XPath("//input[@name='reg_email__']");
        By newPwd = By.XPath("//input[@name='reg_passwd__']");
        By birthDay = By.XPath("//select[@name='birthday_day']");
        By birthMonth = By.XPath("//select[@name='birthday_month']");
        By birthYear = By.XPath("//select[@name='birthday_year']");
        By sex = By.XPath("//label[text()='Mujer']");
        #endregion
        static void Main(string[] args)
        {
            IWebDriver Browser;
            IWebElement element;
            SelectElement selectElement;
            SetUpClass program = new SetUpClass();
            ExecutionClass exec = new ExecutionClass();
            Browser = program.SetUpDriver("Chrome");

            //Review title name
            program.AssertConfirmation(Browser.Title, "Facebook - Inicia sesión o regístrate");

            // Click on create account
            program.waitForElement(2, exec.createAccount);
            element = Browser.FindElement(exec.createAccount);
            program.Click(element);

            // fill information
            program.waitForElement(1, exec.firstName);
            element = Browser.FindElement(exec.firstName);
            program.SendText(element, "Erika");
            Console.WriteLine("Name: Erika");

            program.waitForElement(1, exec.lastName);
            element = Browser.FindElement(exec.lastName);
            program.SendText(element, "Montes");
            Console.WriteLine("Lastname: Montes");

            program.waitForElement(1, exec.mobileNumber);
            element = Browser.FindElement(exec.mobileNumber);
            program.SendText(element, "5564342426");
            Console.WriteLine("Number: 5564342426");

            program.waitForElement(1, exec.newPwd);
            element = Browser.FindElement(exec.newPwd);
            program.SendText(element, "This is a password!");
            Console.WriteLine("Password: This is a password!");

            program.waitForElement(1, exec.birthDay);
            element = Browser.FindElement(exec.birthDay);
            program.FillBDay(program, element,"15");            

            program.waitForElement(5, exec.birthMonth);
            element = Browser.FindElement(exec.birthMonth);
            program.FillBDay(program, element, "sep");

            program.waitForElement(5, exec.birthYear);
            element = Browser.FindElement(exec.birthYear);
            program.FillBDay(program, element, "1997");

            program.waitForElement(5, exec.sex);
            element = Browser.FindElement(exec.sex);
            program.Click(element);

            //review initial message
            program.waitForElement(5, exec.initialMessage);
            element = Browser.FindElement(exec.initialMessage);
            program.AssertConfirmation(element.Text, "Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida.");

            //Browser.Close();
            //Browser.Quit();

        }

    }
}
