namespace Fibonacci
{
    public class CalculatorTest
    {
        private ICalculator _calculator;
        
        [Fact]  
        public void PassingTest()
        {
            Assert.Equal(1, _calculator.FibonacciNumber(0))
            Assert.Equal(1, _calculator.FibonacciNumber(1))
            Assert.Equal(2, _calculator.FibonacciNumber(2))
        }
        
    }
    
}