using NUnit.Framework;

namespace CalculatorApp.Tests
{
    public class AdvancedCalculatorTests
    {
        private AdvancedCalculator _advancedCalculator;

        [SetUp]
        public void Setup() => _advancedCalculator = new AdvancedCalculator();

        [Test]
        public void Power_ShouldReturnCorrectResult()
        {
            var result = _advancedCalculator.Power(2, 3);
            Assert.Equals(8, result);
        }

        [Test]
        public void Sqrt_ShouldReturnCorrectResult()
        {
            var result = _advancedCalculator.Sqrt(16);
            Assert.Equals(4, result);
        }

        [Test]
        public void Square_ShouldReturnCorrectResult()
        {
            var result = _advancedCalculator.Square(4);
            Assert.Equals(16, result);
        }
    }
}
