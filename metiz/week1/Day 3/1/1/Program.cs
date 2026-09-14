namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("string to reverse:");
            string input = Console.ReadLine();
            string rev = ReverseString(input);
            Console.WriteLine($"Reversed string: {rev}");

            
            Console.WriteLine("count vowels:");
            string vowelInput = Console.ReadLine();
            int vCount = CountVowels(vowelInput);
            Console.WriteLine($"Number of vowels: {vCount}");

            
        }

        static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            string vowels = "aeiouAEIOU";
            return input.Count(c => vowels.Contains(c));
        }

    }

}
