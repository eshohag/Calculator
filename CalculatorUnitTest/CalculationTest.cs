using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Addition()
        {
            double expected = 2;
            double actual = Calculation.Addition(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Substraction()
        {
            double expected = 3;
            double actual = Calculation.Substraction(1, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
