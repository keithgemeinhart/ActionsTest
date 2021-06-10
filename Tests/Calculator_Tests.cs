using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void DoubleReturnsExpectedValue()
        {
            var sut = new Calculator();

            var result = sut.Double(10);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void ExpectedToFailOnPurpose()
        {
            var sut = new Calculator();

            var result = sut.Double(5);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void NewTest()
        {
            var calc = new Calculator();

            var result = calc.Double(2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void OtherTest()
        {
            var calc = new Calculator();

            var result = calc.Double(3);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestyMcTestFace()
        {
            var calc = new Calculator();

            var result = calc.Double(9);

            Assert.AreEqual(6, result);
        }
    }
}
