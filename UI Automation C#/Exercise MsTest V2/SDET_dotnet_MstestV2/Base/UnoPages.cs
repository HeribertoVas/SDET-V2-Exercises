using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SDET_dotnet_MstestV2.Base
{
    public class UnoPages
    {
        protected UnoBrowser browser;
        protected IWebDriver driver;
        public UnoPages()
        {
            browser = new UnoBrowser();
            driver = browser.CreateBrowser(UnoBrowser.Browser.Chrome);
            PageFactory.InitElements(driver, this);
        }

    }
}
