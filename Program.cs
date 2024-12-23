using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }

    public class ScientificCalculator : Calculator
    {
        public double Square(double a) => a * a;

        public double Sqrt(double a)
        {
            if (a < 0) throw new ArgumentException("Negative input.");
            return Math.Sqrt(a);
        }
    }

    public class AdvancedCalculator : ScientificCalculator
    {
        public double Power(double a, double b) => Math.Pow(a, b);
    }
}
