using System;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            Student s1 = new Student(1, "Alice", 85.5);
            Student s2 = new Student(2, "Bob", 78.3);
            Student s3 = new Student(3, "Charlie", 92.0);

            manager.AddStudent(s1);
            manager.AddStudent(s2);
            manager.AddStudent(s3);

            manager.ShowAllStudents();
            manager.CalculateAverageMarks();

            Console.WriteLine("\nProgram Ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
