using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }
        }
        else
        {
            if (b >= c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }
        }
    }
}
