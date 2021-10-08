package automation_TestNG;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

public abstract class BrowserController {
	public abstract WebDriver CreateBrowser();	
	public abstract WebElement findElement(WebDriver driver, By xpath);
	public abstract void SendText(WebElement element, String value) ;
	public abstract void Click(WebElement element); 
	public abstract void displayed(WebElement element);
	public abstract void isEquals(String str1, String str2);
	public abstract void get(String url);
	
}
