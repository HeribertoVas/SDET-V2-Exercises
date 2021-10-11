package Base;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import automation_TestNG.BrowserInteraction;

public class UnoBrowser extends BrowserInteraction {
	WebDriver driver;
	public WebDriver CreateBrowser() {
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.amazon.com.mx/");
		driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS);
		return driver;
	}

}
