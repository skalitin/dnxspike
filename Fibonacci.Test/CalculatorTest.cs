using System;
using Xunit;

namespace Fibonacci
{
    public class CalculatorTest
    {
        private ICalculator _calculator = new Calculator();

        [Fact]
        public void FirstNumbersTest()
        {
            Assert.Equal(0, _calculator.FibonacciNumber(0));
            Assert.Equal(1, _calculator.FibonacciNumber(1));
            Assert.Equal(1, _calculator.FibonacciNumber(2));
        }
                
        [Fact]
        public void LargeNumbersTest()
        {
            Assert.Equal(55, _calculator.FibonacciNumber(10));
            Assert.Equal(6765, _calculator.FibonacciNumber(20));
        }
    }
}