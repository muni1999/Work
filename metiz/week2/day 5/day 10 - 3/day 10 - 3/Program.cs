namespace day_10___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it's a palindrome:");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            str = str.ToLower();
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
