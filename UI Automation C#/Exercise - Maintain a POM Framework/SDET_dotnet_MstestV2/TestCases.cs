using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDET_dotnet_MstestV2.POM;

namespace SDET_dotnet_MstestV2
{
    [TestClass]
    public class TestCases
    {
        HomePage homepage;
        Services services;
        About about;
        [TestMethod]
        public void Unosquare_GotoCareers()
        {
            homepage = new HomePage();
            homepage.GoToServicesAndPracticeAreas();
        }

        [TestMethod]
        public void AllElementsInServices()
        {
            services = new Services(); // Create a new POM Page called: Services, implement Page Factory and add the following Test
            services.GoToServices(); //Go to Services
            services.validateLeaders(); //Verify that this element is present: TRUSTED BY INDUSTRY LEADERS
                                        //Print How many Industry Leaders are being displayed
        }
        [TestMethod]
        public void ValidateOurMission()
        {
            about = new About(); //Create a new POM Page called: About, implement Page Factory and add the following Test
            about.GoToAbout(); //Go to About
            about.ValidateSections(); // Verify that 3 elements are present: Personal, Professional and Social
            about.LeaderShipTeam(); //Scroll Down and verify element is present: LEADERSHIP TEAM
                                    //Print the name of each Leader and the corresponding Rol
        }

    }
}
