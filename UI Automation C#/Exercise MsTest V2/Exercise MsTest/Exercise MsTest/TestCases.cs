using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_MsTest.POM;

namespace Exercise_MsTest
{
    [TestClass]
    public class TestCases
    {
        HomePage homepage;
        Blog blog;
 
        [TestInitialize]
        public void BeforeTest()
        {
            homepage = new HomePage();
        }
        [TestMethod]
        public void Unosquare_BlogValidation()
        {
            homepage.GoToServicesAndPracticeAreas();
            blog = new Blog(); //Add a new Page object name Blog      
            blog.GoToBlog();
            blog.validateBlogElement();//Go to Blog - Vlidate using Asserts, this element is present DIGITAL TRANSFORMATION BLOG
            blog.validateQAElement(); // Search for Quality Assurance, validate with Asserts that at least one result is displayed
            
         }

    }
}
