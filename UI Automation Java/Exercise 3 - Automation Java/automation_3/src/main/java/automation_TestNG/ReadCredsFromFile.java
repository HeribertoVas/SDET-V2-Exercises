package automation_TestNG;

import java.io.FileReader;

import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import java.io.FileOutputStream;
import java.io.OutputStream;
import java.util.Properties;

public class ReadCredsFromFile {
	public void readCreds(){
		JSONParser parser = new JSONParser();
		try{
			Object obj = parser.parse(new FileReader("C:\\Users\\heriberto.vasquez\\Documents\\Java Training Course\\automation_3\\creds.json"));
			JSONObject jsonObject = (JSONObject) obj;
			String email = (String) jsonObject.get("Email");
			String password = (String) jsonObject.get("Password");
			
			OutputStream output = new FileOutputStream("C:\\Users\\heriberto.vasquez\\Documents\\Java Training Course\\automation_3\\creds.properties");
					
			Properties prop = new Properties();
			prop.setProperty("email", email);
			prop.setProperty("password", password);
			// save properties to project root folder
            prop.store(output, null);
			System.out.println("SAVED");
			
		}catch (Exception e){
			e.printStackTrace();
		}
	}
		
		

}
