using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student s)
        {
            students.Add(s);
            Console.WriteLine($"Student {s.Name} added successfully.");
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("\n--- Student List ---");
            foreach (var s in students)
            {
                s.DisplayInfo();
            }
        }

        public void CalculateAverageMarks()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            double avg = students.Average(s => s.Marks);
            Console.WriteLine($"\nAverage Marks: {avg}");
        }
    }
}
