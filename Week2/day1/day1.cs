namespace Function_1
{
    internal class Program
    {
        static int AddNumbers(int a, int b)
        {
            int sum = a + b;   
            return sum;        
        }

        static void Main(string[] args)
        {
           
            int result1 = AddNumbers(5, 3);
            int result2 = AddNumbers(10, 20);
            int result3 = AddNumbers(-4, 9);

            
            Console.WriteLine($"Sum of 5 and 3 = {result1}");
            Console.WriteLine($"Sum of 10 and 20 = {result2}");
            Console.WriteLine($"Sum of -4 and 9 = {result3}");
        }
    }
}
