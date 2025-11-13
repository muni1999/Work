using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 0;

        try
        {
            int result = num1 / num2; 
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("❌ Cannot divide a number by zero. Please check your inputs.");
        }
        finally
        {
            Console.WriteLine("➡️ Program execution completed (finally block).");
        }
    }
}
