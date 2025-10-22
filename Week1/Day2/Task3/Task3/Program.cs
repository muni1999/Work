namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter c =");
            double C = Convert.ToDouble(Console.ReadLine());

            double F = (C * 9 / 5) + 32;
            Console.WriteLine(F);

        }
    }
}
