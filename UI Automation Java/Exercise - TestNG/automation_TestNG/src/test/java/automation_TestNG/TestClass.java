package automation_TestNG;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import automation_TestNG.Selectors;
import automation_TestNG.SetUpClass;

public class TestClass {
	SetUpClass amazonValidation = new SetUpClass();
	WebDriver driver = null;
	WebElement element; 
	
	@BeforeClass
	public void beforeClass() {
		driver = amazonValidation.SetUp();
	}
	 
	@Test
	public void firstCase() {		  
		element = amazonValidation.findElement(driver, Selectors.searchBar);
		amazonValidation.SendText(element, "Samsung Galaxy Note 20");
		element.sendKeys(Keys.ENTER); //Search for Samsung Galaxy Note 20

		WebDriverWait wait = new WebDriverWait(driver,15);	  
		element = amazonValidation.findElement(driver, Selectors.priceAdvertizedG20); //Storage price
		String priceAdvertized = element.getAttribute("innerHTML");
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		element = amazonValidation.findElement(driver, Selectors.galaxy20);//Verify Item is displayed on the screen and  locate the first one, then store the price  
		amazonValidation.displayed(element); 
		amazonValidation.Click(element); //Click on the First Result
		  
		element = amazonValidation.findElement(driver, Selectors.detailsPrice); //Storage price
		String detailsPrice = element.getText();
		System.out.println("detailsPrice: "+detailsPrice);
		amazonValidation.isEquals(priceAdvertized, detailsPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		element = amazonValidation.findElement(driver, Selectors.addCartBtn);
		amazonValidation.Click(element); //Click on Add to Cart.
		 
		element = amazonValidation.findElement(driver, Selectors.cartIcon);
		amazonValidation.Click(element);
		  
		element = amazonValidation.findElement(driver, Selectors.finalPrice); //Storage price
		String finalPrice = element.getText();
		System.out.println("finalPrice: "+finalPrice);
		amazonValidation.isEquals(detailsPrice, finalPrice); //Go to Cart and verify again the price of the phone
		  
		element = amazonValidation.findElement(driver, Selectors.deleteBtn);
		amazonValidation.Click(element);//Delete Item */
	  }
	  
	  
	@Test 
	public void secondCase() { 
		driver.get("https://www.amazon.com/");
		element = amazonValidation.findElement(driver, Selectors.searchBar);
		amazonValidation.SendText(element, "Samsung Galaxy S20 FE 5G");
		element.sendKeys(Keys.ENTER); //Search for Samsung Galaxy S20 FE 5G
		  
		element = amazonValidation.findElement(driver, Selectors.priceAdvertizedG20F); //Storage price
		String priceAdvertized = element.getAttribute("innerHTML");
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		element = amazonValidation.findElement(driver, Selectors.galaxy20FE);//Verify Item is displayed on the screen and  locate the first one, then store the price
		amazonValidation.displayed(element);
		amazonValidation.Click(element); //Click on the First Result
		  
		element = amazonValidation.findElement(driver, Selectors.detailsPrice); //Storage price
		String detailsPrice = element.getText();
		System.out.println("detailsPrice: "+detailsPrice);
		amazonValidation.isEquals(priceAdvertized, detailsPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		element = amazonValidation.findElement(driver, Selectors.addCartBtn);
		amazonValidation.Click(element); //Click on Add to Cart.
		  
		element = amazonValidation.findElement(driver, Selectors.cartIcon);
		amazonValidation.Click(element);
		  
		element = amazonValidation.findElement(driver, Selectors.finalPrice); //Storage price
		String finalPrice = element.getText();
		System.out.println("finalPrice: "+finalPrice);
		  
		element = amazonValidation.findElement(driver, Selectors.deleteBtn);
		amazonValidation.Click(element);//Delete Item
	}
}
