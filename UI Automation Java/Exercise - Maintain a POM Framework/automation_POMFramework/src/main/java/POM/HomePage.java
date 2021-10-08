package POM;

import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.WebDriverWait;

import Base.UnoPages;
public class HomePage extends UnoPages {
	WebElement element;
	
	@FindBy(xpath = "//input[@id='twotabsearchtextbox']")
	WebElement searchBar;
	
	@FindBy(xpath = "//span[contains(text(),'Samsung Galaxy Note20')]")
	WebElement galaxy20;
	
	@FindBy(xpath = "(//span[contains(text(),'(N9860)')]//following::span[@class='a-offscreen'])[1]")
	WebElement priceAdvertizedG20;
	
	@FindBy(xpath = "//span[@id='priceblock_ourprice']")
	WebElement detailsPrice;
	
	@FindBy(xpath = "//input[@value='Add to Cart']")
	WebElement addCartBtn;
	
	@FindBy(xpath ="//a[@id='nav-cart']")
	WebElement cartIcon;
	
	@FindBy(xpath = "(//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap'])[1]")
	WebElement finalPrice;
	
	@FindBy(xpath = "//input[@data-action='delete']")
	WebElement deleteBtn;
	
	@FindBy(xpath = "(//span[contains(text(),'S20 FE')])[3]")
	WebElement galaxy20FE;
	
	@FindBy(xpath = "(((//span[contains(text(),'S20 FE')])[3])//following::span[@class='a-offscreen'])[1]")
	WebElement priceAdvertizedG20F;
	
	public HomePage(){
		super();
	}
	
	public HomePage VerifyGalaxyNote20()
    {
		browser.SendText(searchBar, "Samsung Galaxy Note 20");
		searchBar.sendKeys(Keys.ENTER); //Search for Samsung Galaxy Note 20

		WebDriverWait wait = new WebDriverWait(driver,15);		
		String priceAdvertized = priceAdvertizedG20.getAttribute("innerHTML");//Storage price
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		browser.displayed(galaxy20); //Verify Item is displayed on the screen and  locate the first one, then store the price   
		browser.Click(galaxy20); //Click on the First Result
		  
		String detailPrice = detailsPrice.getText();
		System.out.println("detailsPrice: "+detailPrice);
		browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		browser.Click(addCartBtn); //Click on Add to Cart.
		browser.Click(cartIcon);
		  
		String finalPriceTxt = finalPrice.getText();//Storage price
		System.out.println("finalPrice: "+finalPriceTxt );
		browser.isEquals(detailPrice, finalPriceTxt); //Go to Cart and verify again the price of the phone
		  
		browser.Click(deleteBtn);//Delete Item */
        return this;
    }
	
	public HomePage VerifyGalaxyNote20FE()
    {
		browser.get("https://www.amazon.com/");
		browser.SendText(searchBar, "Samsung Galaxy S20 FE 5G");
		searchBar.sendKeys(Keys.ENTER); //Search for Samsung Galaxy S20 FE 5G
		  
		String priceAdvertized = priceAdvertizedG20F.getAttribute("innerHTML"); //Storage price
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		browser.displayed(galaxy20FE); //Verify Item is displayed on the screen and  locate the first one, then store the price
		browser.Click(galaxy20FE); //Click on the First Result
		  
		String detailPrice = detailsPrice.getText(); //Storage price
		System.out.println("detailsPrice: "+detailPrice);
		browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		browser.Click(addCartBtn); //Click on Add to Cart.
		browser.Click(cartIcon);
		  
		String finalPriceTxt = finalPrice.getText(); //Storage price
		System.out.println("finalPrice: "+finalPriceTxt);
		  
		browser.Click(deleteBtn);//Delete Item
		return this;
    
    }
}
