namespace Fibonacci
{
    static class Program
    {
        public static void Main(string[] arguments)
        {
            System.Console.WriteLine("Hello!");
            
            var number = 5;            
            var calculator = new Calculator();
            var result = calculator.FibonacciNumber(number);
            System.Console.WriteLine("Fibonacci({0}) = {1}", number, result);
        }
    }
}