namespace Web.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Web.Controllers;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HomeController();
            var result = controller.Index();  
        }
    }
}
