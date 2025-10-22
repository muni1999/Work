namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double product = num1 * num2;
            double quotient = 0;

            if (num2 != 0)
                quotient = num1 / num2;
            else
                Console.WriteLine("Division by zero is not allowed.");

         
            Console.WriteLine($"\nAddition Result:{sum}");
            Console.WriteLine($"Subtraction Result:{sub}");
            Console.WriteLine($"Multiplication Result:{product}");

            if (num2 != 0)
                Console.WriteLine($"Division Result:{quotient}");
        }
    }
}
