package automation_TestNG;

import java.util.concurrent.TimeUnit;

import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class SetUpClass extends BrowserController {

	@Override
	public WebDriver SetUp() {
		//System.setProperty("webdriver.chrome.driver", "C:\\Users\\luis.osuna\\Downloads\\chromedriver_win32\\chromedriver.exe");
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		//System.setProperty("webdriver.gecko.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Firefox\\geckodriver.exe");
		//WebDriver driver = new FirefoxDriver();
		WebDriver driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.amazon.com/");
		driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS);
		return driver;
	}

	@Override
	public WebElement findElement(WebDriver driver, By xpath) {
		//WebDriverWait wait = new WebDriverWait(driver, 7);
        //wait.until(ExpectedConditions.visibilityOfElementLocated(xpath));
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

}
