using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine("Sum from 1 to " + n + " is: " + sum);
    }
}
