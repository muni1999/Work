namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double area = length * breadth;

            Console.WriteLine($"\n area of the rectangle is: {area}");
        }
    }
}
