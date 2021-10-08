package automation_TestNG;
import org.openqa.selenium.WebDriver;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import Base.UnoBrowser;
import POM.HomePage;

public class TestClass {
	UnoBrowser amazonValidation = new UnoBrowser();	 
	HomePage homepage;
	
	 
	@Test
	public void firstCase(){	
		homepage = new HomePage();
		homepage.VerifyGalaxyNote20();		
	  }
	  
	  
	@Test 
	public void secondCase() { 
		homepage.VerifyGalaxyNote20FE();
	}
}
