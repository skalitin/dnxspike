namespace Fibonacci
{
    static class Program
    {
        public static void Main(string[] arguments)
        {
            System.Console.WriteLine("Test");
            
            var calculator = new IterativeCalculator();
            var result = calculator.FibonacciNumber(0);
            System.Console.WriteLine("0: {0}", result);
        }
    }
}