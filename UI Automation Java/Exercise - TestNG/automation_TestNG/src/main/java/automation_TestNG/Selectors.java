package automation_TestNG;

import org.openqa.selenium.By;

public interface Selectors {
	final By searchBar = By.xpath("//input[@id='twotabsearchtextbox']");
	final By galaxy20 = By.xpath("//span[contains(text(),'Samsung Galaxy Note20')]");
	final By priceAdvertizedG20 = By.xpath("(//span[contains(text(),'(N9860)')]//following::span[@class='a-offscreen'])[1]");
	final By detailsPrice = By.xpath("//span[@id='priceblock_ourprice']");
	final By addCartBtn = By.xpath("//input[@value='Add to Cart']");	
	final By cartIcon = By.xpath("//a[@id='nav-cart']");
	final By finalPrice = By.xpath("(//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap'])[1]");
	final By deleteBtn = By.xpath("//input[@data-action='delete']");
	
	final By galaxy20FE = By.xpath("(//span[contains(text(),'S20 FE')])[3]");
	final By priceAdvertizedG20F = By.xpath("(((//span[contains(text(),'S20 FE')])[3])//following::span[@class='a-offscreen'])[1]");

}
