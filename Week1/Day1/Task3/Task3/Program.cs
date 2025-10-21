namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHello, " + name);
            Console.WriteLine("You are " + age);
        }
    }
}
