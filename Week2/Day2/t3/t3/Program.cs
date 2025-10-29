namespace t3
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

          
            int largest = numbers[0];

            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine($"\nThe largest element in the array is: {largest}");

            Console.ReadLine();
        }
    }
}
