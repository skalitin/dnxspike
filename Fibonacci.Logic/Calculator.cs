namespace Fibonacci
{
    public class Calculator : ICalculator
    {
        public int FibonacciNumber(int index)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;  
   
            if (index == 0) return firstnumber;   
            if (index == 1) return secondnumber;   
   
            for (int i = 2; i <= index; i++)  
            {  
                result = firstnumber + secondnumber;  
                firstnumber = secondnumber;  
                secondnumber = result;  
            }  
   
            return result;  
        }        
    }
}