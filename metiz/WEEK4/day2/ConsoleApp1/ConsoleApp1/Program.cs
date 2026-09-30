namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
