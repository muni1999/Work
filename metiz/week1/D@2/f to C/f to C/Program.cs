using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");

        Console.Write("Enter your choice (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine("Temperature in Fahrenheit: "
                              + fahrenheit + " °F");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            Console.WriteLine("Temperature in Celsius: "
                              + celsius + " °C");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}