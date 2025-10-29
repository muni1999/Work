namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[5];

            
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1}: {numbers[i]}");
            }

            Console.ReadLine();
        }
    }
}
