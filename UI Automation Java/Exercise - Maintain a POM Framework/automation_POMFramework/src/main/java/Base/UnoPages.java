package Base;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.PageFactory;

public class UnoPages {
	public UnoBrowser browser;
    protected WebDriver driver;
	public UnoPages(){
		browser = new UnoBrowser();
        driver = browser.CreateBrowser();
        PageFactory.initElements(driver, this);
	}

}
