namespace Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("string");
            string input = Console.ReadLine();
            string r = ReverseString(input);
            Console.WriteLine($"Reversed String: {r}");


            int v = CountVowels(input);
            Console.WriteLine($"No of vowels: {v}");

            int[] numbers = { 1, 2, 3 };
            int s = ArraySum(numbers);
            Console.WriteLine($"Sum of array elements: {s}");

        }

        static string ReverseString(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int ArraySum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }
    }
}

