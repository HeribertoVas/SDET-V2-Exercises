package automation_2;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

public class ExecutionClass {
	
	public static void main(String[] args) {
		SetUpClass faceValidation = new SetUpClass();
		WebDriver driver = faceValidation.SetUp();
		WebElement element;
		
		faceValidation.isEquals(driver.getCurrentUrl(), "https://www.facebook.com/"); //Validate that URL is correct.	
		faceValidation.isEquals(driver.getTitle(), "Facebook - Inicia sesión o regístrate"); //Validate the Title of the page, should be : Facebook - Log In or Sign Up.
		
		element = faceValidation.findButton(driver,faceValidation.singBtn); //Fill all Sign Up section
		faceValidation.Click(element);
		
		element = faceValidation.findElement(driver,faceValidation.firstName);
		faceValidation.SendText(element, "Erika");

		element = faceValidation.findElement(driver,faceValidation.lastName);
		faceValidation.SendText(element, "Montes");

		element = faceValidation.findElement(driver,faceValidation.mobileNumber);
		faceValidation.SendText(element, "5564342426");

		element = faceValidation.findElement(driver,faceValidation.newPwd);
		faceValidation.SendText(element, "This is a password!");

		element = faceValidation.findElement(driver,faceValidation.birthDay); //Choose a different Birthday not the default one.
		faceValidation.FillBDay(faceValidation, element,"15");  
		
		element = faceValidation.findElement(driver,faceValidation.birthMonth);
		faceValidation.FillBDay(faceValidation, element,"sep"); 
		
		element = faceValidation.findElement(driver,faceValidation.birthYear);
		faceValidation.FillBDay(faceValidation, element,"1997"); 
		
		element = faceValidation.findButton(driver,faceValidation.sex);
		faceValidation.Click(element); //Click on Female.
		
		driver.get("https://www.facebook.com"); //return to previous link
		//review initial message		
        element = faceValidation.findElement(driver,faceValidation.initialMessage);
        String texto = element.getText();
        faceValidation.isEquals(texto, "Facebook te ayuda a comunicarte y compartir con las personas que forman parte de tu vida."); //Validate following text is present: Connect with friends and the
	
        element = faceValidation.findButton(driver,faceValidation.forgotPwd); //Click on Forgot Account?
		faceValidation.Click(element);
		
		element = faceValidation.findElement(driver,faceValidation.forgotTxt); //Validate following text is displayed: “Find Your Account”.
		texto = element.getText();
		faceValidation.isEquals(texto,"Recupera tu cuenta");
		
		element = faceValidation.findElement(driver,faceValidation.validEmail);
		faceValidation.SendText(element, "heriberto.vasquez@unosquare.com"); //Enter a valid email but non existing one and click on search.
		
		element = faceValidation.findButton(driver,faceValidation.searchBtn);
		faceValidation.Click(element);
		
		element = faceValidation.findElement(driver,faceValidation.errorMsg); //Validate Error message is displayed (No search Results)
		texto = element.getText();
		faceValidation.isEquals(texto,"No hay resultados de búsqueda");
		
		System.out.println("FINISHED!!!");
	}

}
