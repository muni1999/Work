namespace day_10___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("2. Convert string to uppercase");
                Console.WriteLine("3. Find the length of an array");
                Console.WriteLine("4. Sort an array");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ReverseString();
                        break;
                    case "2":
                        ConvertToUppercase();
                        break;
                    case "3":
                        FindArrayLength();
                        break;
                    case "4":
                        SortArray();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ReverseString()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
        }

        static void ConvertToUppercase()
        {
            Console.Write("Enter a string to convert to uppercase: ");
            string input = Console.ReadLine();
            Console.WriteLine("Uppercase string: " + input.ToUpper());
        }

        static void FindArrayLength()
        {
            Console.Write("Enter array elements separated by space: ");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("Array length: " + input.Length);
        }

        static void SortArray()
        {
            Console.Write("Enter array elements separated by space: ");
            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);
            Console.WriteLine("Sorted array: " + string.Join(" ", input));
        }
    }
}
