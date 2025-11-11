using System;

namespace TwoClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Teacher teacher = new Teacher("Mr. Smith");
            Student student = new Student("Alice");

          
            teacher.AskQuestion(student);

            Console.WriteLine("\nProgram ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}