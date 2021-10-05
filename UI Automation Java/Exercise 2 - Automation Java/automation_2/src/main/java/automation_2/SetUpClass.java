package automation_2;

import java.util.concurrent.TimeUnit;

import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;


public class SetUpClass {
	public WebDriver SetUp() 
	{
		//System.setProperty("webdriver.chrome.driver", "C:\\Users\\luis.osuna\\Downloads\\chromedriver_win32\\chromedriver.exe");
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\heriberto.vasquez\\Documents\\WebDrivers\\Chrome\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.facebook.com");
		driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS);
		return driver;
	}
	
	//Wait for the element and find it
	public WebElement findElement(WebDriver driver, By xpath) 
	{
		WebDriverWait wait = new WebDriverWait(driver, 5);
        wait.until(ExpectedConditions.visibilityOfElementLocated(xpath));
		return driver.findElement(xpath);
	}
	//Wait the button to be enabled and find it
	public WebElement findButton(WebDriver driver, By xpath) 
	{
		WebDriverWait wait = new WebDriverWait(driver, 5);
		wait.until(ExpectedConditions.elementToBeClickable(xpath));
		return driver.findElement(xpath);
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
		System.out.println("PASSED!!");
	}
	
	public void FillBDay(SetUpClass program, WebElement element, String partOfDate)
    {
        program.SendText(element, partOfDate);
        System.out.println(partOfDate);
    }
	
	By initialMessage = By.xpath("//h2[text()='Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida.']");
	By singBtn = By.xpath("//a[.='Crear cuenta nueva']");
	By firstName = By.xpath("//input[@placeholder='Nombre']");
    By lastName = By.xpath("//input[@name='lastname']");
    By mobileNumber = By.xpath("//input[@name='reg_email__']");
    By newPwd = By.xpath("//input[@name='reg_passwd__']");
    By birthDay = By.xpath("//select[@name='birthday_day']");
    By birthMonth = By.xpath("//select[@name='birthday_month']");
    By birthYear = By.xpath("//select[@name='birthday_year']");
    By sex = By.xpath("//label[text()='Mujer']");
    
    By forgotPwd = By.xpath("//a[.='¿Olvidaste tu contraseña?']");
    By forgotTxt = By.xpath("(//h2[.='Recupera tu cuenta'])[2]");
    By validEmail = By.xpath("//input[@id='identify_email']");
    By searchBtn = By.xpath("//button[@id='did_submit']");
    By errorMsg = By.xpath("//div[.='No hay resultados de búsqueda']");
  
}

