package automation_1;

import org.junit.Assert;
import java.util.concurrent.TimeUnit;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class AppleValidation {

	public WebDriver SetUp() 
	{
		//System.setProperty("webdriver.chrome.driver", "C:\\Users\\luis.osuna\\Downloads\\chromedriver_win32\\chromedriver.exe");
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.apple.com/mx/");
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
	
	public void displayed(WebElement element){
		Assert.assertTrue(element.isDisplayed());
	}
	
	public void isEquals(String str1, String str2){
		Assert.assertEquals(str1,str2);
	}
	
	
	
	By macElement = By.xpath("//a[@class='ac-gn-link ac-gn-link-mac']");
	By iMacElement = By.xpath("//p[.='Dile hola.']");
	By searchIcon = By.xpath("//a[@id='ac-gn-link-search']");
	By searchBar = By.xpath("//input[@placeholder='Buscar en apple.com']");

	By iphoneElement = By.xpath("//a[@class='ac-gn-link ac-gn-link-iphone ']");
	By iphone12 = By.xpath("(//span[.='iPhone 12'])[1]");
	By ipDescript = By.xpath("//span[.='Descripción']");
	By ipEspec = By.xpath("//a[.='Especificaciones']");
	By ipComprar = By.xpath("(//a[@data-analytics-title='buy iphone 12'])[1]");
	
	
	public static void main(String[] args) {
		
		AppleValidation appleValidation = new AppleValidation();
		WebDriver driver = appleValidation.SetUp();
		WebElement element;
		
		WebDriverWait wait = new WebDriverWait(driver,30);
		element = driver.findElement(appleValidation.macElement);
		appleValidation.Click(element);	
		
		wait = new WebDriverWait(driver,30);
		element = driver.findElement(appleValidation.iMacElement);
		appleValidation.displayed(element);//User Assert for the following text: Dile hola.
		
		element = driver.findElement(appleValidation.searchIcon);
		appleValidation.Click(element);		
		
		element = driver.findElement(appleValidation.searchBar);
		appleValidation.SendText(element, "iPhone XR");
		element.sendKeys(Keys.ENTER);		
		appleValidation.isEquals(driver.getTitle(),"iPhone XR - Apple (MX)");//validate page title is iPhone XR - Apple (MX)
		
		
		element = driver.findElement(appleValidation.iphoneElement);
		appleValidation.Click(element);	
		
		element = driver.findElement(appleValidation.iphone12);
		appleValidation.Click(element);	
		//validate all these options are available and enabled
		element = driver.findElement(appleValidation.ipDescript);
		appleValidation.displayed(element);
		element = driver.findElement(appleValidation.ipEspec);
		appleValidation.displayed(element);
		element = driver.findElement(appleValidation.ipComprar);
		appleValidation.displayed(element);
		
		System.out.println("Completed");
		
		driver.quit();
	}


}
