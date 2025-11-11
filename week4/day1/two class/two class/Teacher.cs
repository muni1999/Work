using System;

namespace TwoClassDemo
{
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching the class.");
        }

        public void AskQuestion(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("No student to ask the question.");
                return;
            }

            Console.WriteLine($"{Name} asks {student.Name} a question.");
            student.AnswerQuestion(this); // calling Student class method
        }
    }
}
