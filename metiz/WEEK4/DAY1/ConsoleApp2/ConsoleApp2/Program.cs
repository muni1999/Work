namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<int, string> students = new Dictionary<int, string>
                {
                    { 1, "Alice" },
                    { 2, "Bob" },
                    { 3, "Charlie" }
                };
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}
