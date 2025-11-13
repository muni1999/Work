using System;

// Custom Exception Class
public class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exception Handling Demo ===");

        
        DivideNumbers(10, 0);
        DivideNumbers(20, 4);

       
        int[] arr = { 5, 10, 15 };
        AccessArrayElement(arr, 5);
        AccessArrayElement(arr, 1);
    }

    static void DivideNumbers(int a, int b)
    {
        try
        {
            if (b == 0)
                throw new InvalidInputException("Denominator cannot be zero.");

            int result = a / b;
            Console.WriteLine($"Result of {a} / {b} = {result}");
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine("❌ Custom Error: " + ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("❌ Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("➡️ Completed division operation.\n");
        }
    }


    static void AccessArrayElement(int[] arr, int index)
    {
        try
        {
            if (index < 0)
                throw new InvalidInputException("Array index cannot be negative.");

            Console.WriteLine($"Value at index {index}: {arr[index]}");
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine("❌ Custom Error: " + ex.Message);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("❌ Index is outside the array range.");
        }
        finally
        {
            Console.WriteLine("➡️ Completed array access operation.\n");
        }
    }
}
