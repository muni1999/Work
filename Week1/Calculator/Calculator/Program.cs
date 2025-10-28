using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract
        static double Subtract(double a, double b)
        {
            return a - b;
        }
            
        // Multiply
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return 0;
            }
            return a / b;
        }

        // Power
        static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        // Reverse number
        static int ReverseNumber(int n)
        {
            int reversed = 0;
            while (n != 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }
            return reversed;
        }

        // Main method
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===== MENU DRIVEN CALCULATOR =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Power");
                Console.WriteLine("6. Reverse Number");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                double num1, num2;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Add(num1, num2)}");
                        break;

                    case 2:
                        Console.Write("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Subtract(num1, num2)}");
                        break;

                    case 3:
                        Console.Write("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Multiply(num1, num2)}");
                        break;

                    case 4:
                        Console.Write("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Divide(num1, num2)}");
                        break;

                    case 5:
                        Console.Write("Enter base number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter exponent: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Power(num1, num2)}");
                        break;

                    case 6:
                        Console.Write("Enter a number to reverse: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Reversed Number: {ReverseNumber(n)}");
                        break;

                    case 7:
                        Console.WriteLine("Exiting... Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            } while (choice != 7);
        }
    }
}
