package POM;

import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebElement;

import Base.UnoPages;
import automation_TestNG.ReadCredsFromFile;
import java.io.FileInputStream;
import java.io.InputStream;
import java.util.Properties;
import java.io.IOException;

public class HomePage extends UnoPages {
	WebElement element;
	
	@FindBy(xpath = "//input[@id='twotabsearchtextbox']")
	WebElement searchBar;
	
	@FindBy(xpath = "(//span[contains(text(),'S20 FE')])[3]")
	WebElement galaxy20FE;
	
	@FindBy(xpath = "(((//span[contains(text(),'S20 FE')])[3])//following::span[@class='a-offscreen'])[1]")
	WebElement priceAdvertizedG20F;
	
	@FindBy(xpath = "//a[@id='nav-link-accountList']")
	WebElement iniciarSesion;
	
	@FindBy(xpath = "//input[@name='email']")
	WebElement emailInput;
	
	@FindBy(xpath = "//input[@id='continue']")
	WebElement continueBtn;
	
	@FindBy(xpath = "//input[@name='password']")
	WebElement passwordInput;
	
	@FindBy(xpath = "//input[@id='signInSubmit']")
	WebElement signBtn;
	
	@FindBy(xpath = "(//span[contains(text(),'S9 Samsung Galaxy')])[1]")
	WebElement galaxy9;
	
	@FindBy(xpath = "(//span[contains(text(),'S9 Samsung Galaxy')])[1]//following::span[@class='a-offscreen'][1]")
	WebElement priceAdvertizedS9;
	
	@FindBy(xpath = "//span[@id='priceblock_ourprice']")
	WebElement detailsPrice;
	
	@FindBy(xpath = "//input[@id='add-to-cart-button']")
	WebElement addCartBtn;
	
	@FindBy(xpath ="//a[@id='nav-cart']")
	WebElement cartIcon;
	
	@FindBy(xpath = "(//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap sc-product-price a-text-bold'])[1]")
	WebElement finalPrice;
	
	@FindBy(xpath = "//a[@id = 'attach-close_sideSheet-link']")
	WebElement attachCloseBtn;
	
	@FindBy(xpath = "//span[@id = 'nav-cart-count']")
	WebElement totalInCar;
	
	@FindBy(xpath = "(//span[contains(text(),'(N9860)')]//following::span[@class='a-offscreen'])[1]")
	WebElement priceAdvertizedG20;
	
	@FindBy(xpath = "(//span[contains(text(),'Alienware AW2720HF')])[2]")
	WebElement alienware;
	
	@FindBy(xpath = "(//span[contains(text(),'Alienware AW2720HF')])[2]//following::span[@class='a-offscreen'][1]")
	WebElement priceAdvertizedAW;
	
	public HomePage(){
		super();
		ReadCredsFromFile readFromFile = new ReadCredsFromFile();
		readFromFile.readCreds();
	}
	
	
	
	public HomePage LoginAmazon(){	  
		iniciarSesion.click();
		try{
			InputStream input = new FileInputStream("C:\\Users\\heriberto.vasquez\\Documents\\Java Training Course\\automation_3\\creds.properties");
			Properties prop = new Properties();
			prop.load(input);
			emailInput.sendKeys(prop.getProperty("email"));
			continueBtn.click();
			passwordInput.sendKeys(prop.getProperty("password"));
			
		}catch (IOException ex){
			ex.printStackTrace();
		}
		
		signBtn.click();
		return this;
	}
	
	public HomePage VerifyGalaxyS9()
    {
		browser.SendText(searchBar, "Samsung Galaxy S9 64GB");
		searchBar.sendKeys(Keys.ENTER); //Search for Samsung Galaxy S20 FE 5G
		  
		String priceAdvertized = priceAdvertizedS9.getAttribute("innerHTML"); //Storage price
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		browser.displayed(galaxy9); //Verify Item is displayed on the screen and  locate the first one, then store the price
		browser.Click(galaxy9); //Click on the First Result
		  
		String detailPrice = detailsPrice.getText(); //Storage price
		System.out.println("detailsPrice: "+detailPrice);
		browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		browser.Click(addCartBtn); //Click on Add to Cart.
		attachCloseBtn.click();
		browser.Click(cartIcon);
		  
		String finalPriceTxt = finalPrice.getText(); //Storage price
		System.out.println("finalPrice: "+finalPriceTxt);
		 
		browser.isEquals(priceAdvertized, finalPriceTxt);
		
		String totalInCa =totalInCar.getText();
		System.out.println(totalInCa);
		browser.isEquals("1", totalInCa);
		
		return this;
    }
	
	public HomePage VerifyAlienware()
    {
		browser.SendText(searchBar, "Alienware AW2720HF");
		searchBar.sendKeys(Keys.ENTER); //Search for Samsung Galaxy S20 FE 5G
		  
		String priceAdvertized = priceAdvertizedAW.getAttribute("innerHTML"); //Storage price
		System.out.println("Price Advertized: "+priceAdvertized);
		  
		browser.displayed(alienware); //Verify Item is displayed on the screen and  locate the first one, then store the price
		browser.Click(alienware); //Click on the First Result
		  
		String detailPrice = detailsPrice.getText(); //Storage price
		System.out.println("detailsPrice: "+detailPrice);
		browser.isEquals(priceAdvertized, detailPrice);// Once in the details page compare this price vs the above one (first stored price)
		  
		browser.Click(addCartBtn); //Click on Add to Cart.
		attachCloseBtn.click();
		browser.Click(cartIcon);
		  
		String finalPriceTxt = finalPrice.getText(); //Storage price
		System.out.println("finalPrice: "+finalPriceTxt);
		 
		browser.isEquals(priceAdvertized, finalPriceTxt);
		String totalInCa =totalInCar.getText();
		System.out.println(totalInCa);
		browser.isEquals("2", totalInCa);
		
		return this;
    }
	
	
	
	
	
	
	
}
