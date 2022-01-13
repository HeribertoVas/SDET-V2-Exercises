using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_3_MS_Test.POM;

namespace Exercise_3_MS_Test
{
    [TestClass]
    public class UnitTest1
    {
        HomePage homepage;

        [TestInitialize]
        public void BeforeTest()
        {
            homepage = new HomePage();
        }
        [TestMethod]
        public void TestMethod1()
        {
            homepage.LoginAmazon();
            homepage.VerifyGalaxyS9();
		    homepage.VerifyAlienware();             
        }
    }
}
