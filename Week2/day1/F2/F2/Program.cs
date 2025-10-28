namespace F2
{
    internal class Program
    {
        static int MaxOfThree(int a, int b, int c)
        {
            int max = a; 

            if (b > max)
                max = b;
            if (c > max)
                max = c;

            return max;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine($"Max of (10, 20, 15) = {MaxOfThree(10, 20, 15)}");
            Console.WriteLine($"Max of (5, 3, 9) = {MaxOfThree(5, 3, 9)}");
            Console.WriteLine($"Max of (-4, -7, -2) = {MaxOfThree(-4, -7, -2)}");
            Console.WriteLine($"Max of (100, 100, 100) = {MaxOfThree(100, 100, 100)}");
        }
    }
}
