using System;


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
        try
        {
            Console.Write("Enter a positive number: ");
            int value = int.Parse(Console.ReadLine());

        
            if (value <= 0)
            {
                throw new InvalidInputException("Input must be a positive number greater than zero.");
            }

            Console.WriteLine("You entered: " + value);
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine("❌ Custom Exception Caught: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Input is not a valid number. Please enter digits only.");
        }
        finally
        {
            Console.WriteLine("➡️ Execution finished (finally block).");
        }
    }
}
