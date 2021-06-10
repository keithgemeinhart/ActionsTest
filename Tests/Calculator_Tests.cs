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
    }
}
