using System;

namespace UserInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== User Information Program ===\n");

          
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("=== Employee Details ===\n");
            Console.WriteLine($"Name     : {name}");
            Console.WriteLine($"Age      : {age} years");
            Console.WriteLine($"Salary   : {salary:C}"); 
            Console.WriteLine($"City     : {city}");
            Console.WriteLine("\nThank you for providing your details!");

          
            Console.ReadKey();
        }
    }
}
