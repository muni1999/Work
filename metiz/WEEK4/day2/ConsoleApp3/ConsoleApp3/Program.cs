namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, World!");
                
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException caught: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General exception caught: {ex.Message}");
            }
        }
    }
}
