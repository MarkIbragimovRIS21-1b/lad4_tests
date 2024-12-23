using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup() => _calculator = new Calculator();

        [Test]
        public void Add_ShouldReturnSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.Equals(5, result);
        }

        [Test]
        public void Subtract_ShouldReturnDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equals(2, result);
        }

        [Test]
        public void Multiply_ShouldReturnProduct()
        {
            var result = _calculator.Multiply(4, 5);
            Assert.Equals(20, result);
        }

        [Test]
        public void Divide_ShouldReturnQuotient()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equals(5, result);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Test]
        public void Add_NegativeNumbers_ShouldReturnCorrectSum()
        {
            var result = _calculator.Add(-2, -3);
            Assert.Equals(-5, result);
        }
    }
}
