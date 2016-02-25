namespace Fibonacci
{
    public class IterativeCalculator : ICalculator
    {
        public ulong FibonacciNumber(ulong index)
        {
            ulong firstnumber = 1, secondnumber = 1, result = 0;  
   
            if (index == 0) return 0;   
            if (index == 1) return 1;   
   
            for (ulong i = 2; i <= index; i++)  
            {  
                result = firstnumber + secondnumber;  
                firstnumber = secondnumber;  
                secondnumber = result;  
            }  
   
            return result;  
        }        
    }
}