namespace Student_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Id = 1, Name = "Alice", Marks = 85 };
            Student student2 = new Student { Id = 2, Name = "Bob", Marks = 90 };

            student1.DisplayDetails();
            student2.DisplayDetails();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Marks: {Marks}");
        }
    }
}
