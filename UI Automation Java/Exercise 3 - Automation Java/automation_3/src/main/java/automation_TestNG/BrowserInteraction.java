package automation_TestNG;

import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.openqa.selenium.support.ui.ExpectedConditions;

public class BrowserInteraction {
	WebDriver driver;
	public WebElement findElement(WebDriver driver, By xpath) {
		new WebDriverWait(driver,1).until(ExpectedConditions.presenceOfElementLocated(xpath));
		return driver.findElement(xpath);
	}

	public void SendText(WebElement element, String value) {
		element.sendKeys(value);		
	}

	public void Click(WebElement element) {
		element.click();
	}
	
	public void displayed(WebElement element){
		Assert.assertTrue(element.isDisplayed());
		System.out.println("ON SCREEN!!");
	}

	public void isEquals(String str1, String str2){
		Assert.assertEquals(str1,str2);
		System.out.println("PASSED!!");
	}
	
	public void get(String url){
		try{
			driver.get(url);
		}catch(Exception e){
			e.printStackTrace();
		}
	}
	
	public void Close(){
		try{
			driver.close();
		}catch(Exception e){
			e.printStackTrace();
		}
	}

	
}
