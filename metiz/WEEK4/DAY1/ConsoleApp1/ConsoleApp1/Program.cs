namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a value");
                Console.WriteLine("2. Remove a value");
                Console.WriteLine("3. Search for a value");
                Console.WriteLine("4. Display all values");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a value to add: ");
                        if (int.TryParse(Console.ReadLine(), out int valueToAdd))
                        {
                            numbers.Add(valueToAdd);
                            Console.WriteLine("Value added.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter a value to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int valueToRemove))
                        {
                            if (numbers.Remove(valueToRemove))
                            {
                                Console.WriteLine("Value removed.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter a value to search for: ");
                        if (int.TryParse(Console.ReadLine(), out int valueToSearch))
                        {
                            if (numbers.Contains(valueToSearch))
                            {
                                Console.WriteLine("Value found.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Values in the list:");
                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
