package cucumberJava;

import Base.UnoBrowser;
import POM.HomePage;
import cucumber.annotation.en.Given; 
import cucumber.annotation.en.Then; 
import cucumber.annotation.en.When; 


public class annotation {
	HomePage homepage;
	@Given("^I go to Amazon.mx on browser$") 
	public void createBrowser() { 
		UnoBrowser amazonValidation = new UnoBrowser();	 
	} 
		
	@When("^Successful login$")  
	public void goToFacebook() { 
		homepage = new HomePage();
		homepage.LoginAmazon();
		
	} 
		
	@Then("^Validation of Phone and Monitor correct$") 
	public void loginButton() { 
		homepage.VerifyGalaxyS9();
		homepage.VerifyAlienware();
	} 
}
