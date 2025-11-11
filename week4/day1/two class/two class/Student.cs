using System;

namespace TwoClassDemo
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying for the test.");
        }

        public void AnswerQuestion(Teacher teacher)
        {
            Console.WriteLine($"{Name} answers the question asked by {teacher.Name}.");
            teacher.Teach(); // calling back Teacher method
        }
    }
}