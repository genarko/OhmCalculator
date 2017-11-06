using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OhmCalculator.Tests.Classes
{
    [TestClass]
    public class OhmCalculatorTest
    {
        [TestMethod]
        public void Calc()
        {
            OhmCalculator.Classes.OhmCalculator calc = new OhmCalculator.Classes.OhmCalculator();
            var result = calc.CalculateOhmValue("Brown", "Red", "Black", "Brown");
            Assert.IsNotNull(result);

        }
    }
}
