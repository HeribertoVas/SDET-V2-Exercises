package SDET_java_maintenanceUnosquare.sdet_java;

import java.util.concurrent.TimeUnit;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class Program {

	public WebDriver SetUp() 
	{
		//System.setProperty("webdriver.chrome.driver", "C:\\Users\\luis.osuna\\Downloads\\chromedriver_win32\\chromedriver.exe");
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://people.unosquare.com/");
		driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS);
		return driver;
	}
	
	public void SendText(WebElement element, String value) 
	{
		element.sendKeys(value);
	}
	
	public void Click(WebElement element) 
	{
		element.click();
	}
	
	public void ClickWhenEnabled(WebDriver driver, WebElement element) 
	{
		WebDriverWait wait = new WebDriverWait(driver,15);
		wait.until(ExpectedConditions.elementToBeClickable(element));
		
	}
	
	By ThreeDotMenu = By.cssSelector(".navbar-toggler-icon");
	By AboutUS = By.xpath("//a[.='About us']");
	By Personal = By.cssSelector("div.about-button:nth-child(1) > div:nth-child(1) > h3");

	public static void main(String[] args) {
		
		Program program = new Program();
		WebDriver driver = program.SetUp();
		WebElement element;
		
		element = driver.findElement(program.ThreeDotMenu);
		program.Click(element);		
		element = driver.findElement(program.AboutUS);
		program.Click(element);			
		element = driver.findElement(program.Personal);
		program.Click(element);	
		
	}

}
