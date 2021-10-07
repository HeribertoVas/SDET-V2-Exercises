using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Exercise_MsTest.Base
{
    public class UnoPages
    {
        public UnoBrowser browser;
        protected IWebDriver driver;
        public UnoPages()
        {
            browser = new UnoBrowser();
            driver = browser.CreateBrowser(UnoBrowser.Browser.Chrome);
            PageFactory.InitElements(driver, this);
        }

    }
}
