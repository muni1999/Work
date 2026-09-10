using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(number + "! = " + factorial);
    }
}
