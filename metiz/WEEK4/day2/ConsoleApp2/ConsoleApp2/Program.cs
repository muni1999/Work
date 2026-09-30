namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateInput(0); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ValidateInput(int age)
        {
            if (age <= 0)
            {
                throw new ArgumentException("Age must be greater than zero.");
            }
        }
    }
}
