package automation_TestNG;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

import Base.UnoBrowser;
import POM.HomePage;

public class TestClass {
	 
	HomePage homepage;
	UnoBrowser amazonValidation = null;
	@BeforeTest
	public void Init(){
		amazonValidation = new UnoBrowser();	
	} 
	
	@Test
	public void Validations(){	
		homepage = new HomePage();
		homepage.LoginAmazon();
		homepage.VerifyGalaxyS9();
		homepage.VerifyAlienware();
	  }
	  
	
	@AfterTest
	public void Quit(){
		amazonValidation.Close();
	}
}
