using System;

namespace StudentApp
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int rollNo, string name, double marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Roll No: {RollNo}, Name: {Name}, Marks: {Marks}");
        }
    }
}