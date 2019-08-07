using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingForTheLongHaul.Tests
{
    [TestClass]
    public class OptionalArgumentsTests
    {
        [TestMethod]
        public void OptionalArguments_2String_Test()
        {
            var test = new OptionalArguments();

            var result = test.LetsUseOptionalArguments("Go", "Brewers");

            Assert.AreEqual("Go Brewers", result);
        }

        [TestMethod]
        public void OptionalArguments_3String_Test()
        {
            var test = new OptionalArguments();

            var result = test.LetsUseOptionalArguments("Let's", "Go", "Brewers");

            Assert.AreEqual("Let's Go Brewers!!!", result);
        }

        [TestMethod]
        public void OptionalArguments_4String_Test()
        {
            var test = new OptionalArguments();

            var result = test.LetsUseOptionalArguments("Let's", "Go", "Brewers", "Not the Cubs");

            Assert.AreEqual("Let's Go Brewers!!!", result);
        }
    }
}
