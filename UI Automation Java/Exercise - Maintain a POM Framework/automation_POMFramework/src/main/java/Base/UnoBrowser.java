package Base;
import automation_TestNG.BrowserController;

import java.util.concurrent.TimeUnit;

import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class UnoBrowser extends BrowserController {
	WebDriver driver;
	@Override
	public WebDriver CreateBrowser() {
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.amazon.com/");
		driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS);
		return driver;
	}
	
	@Override
	public WebElement findElement(WebDriver driver, By xpath) {
		return driver.findElement(xpath);
	}

	@Override
	public void SendText(WebElement element, String value) {
		element.sendKeys(value);		
	}

	@Override
	public void Click(WebElement element) {
		element.click();
	}
	
	@Override
	public void displayed(WebElement element){
		Assert.assertTrue(element.isDisplayed());
		System.out.println("ON SCREEN!!");
	}

	@Override
	public void isEquals(String str1, String str2){
		Assert.assertEquals(str1,str2);
		System.out.println("PASSED!!");
	}
	
	@Override
	public void get(String url){
		driver.get(url);
	}

}
