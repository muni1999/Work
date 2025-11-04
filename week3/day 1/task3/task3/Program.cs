using System;

public class Student
{
    // Properties
    public string Name { get; set; }
    public int RollNo { get; set; }
    public string Course { get; set; }

    // Default constructor
    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        Course = "Not Assigned";
    }

    // Constructor with RollNo only
    public Student(int rollNo)
    {
        Name = "Unknown";
        RollNo = rollNo;
        Course = "Not Assigned";
    }

    // Constructor with Name and RollNo
    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
        Course = "Not Assigned";
    }

    // Constructor with Name, RollNo, and Course
    public Student(string name, int rollNo, string course)
    {
        Name = name;
        RollNo = rollNo;
        Course = course;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}, Course: {Course}");
    }

    // Main method
    public static void Main(string[] args)
    {
        // Using default constructor
        Student s1 = new Student();
        Console.WriteLine("Using Default Constructor:");
        s1.DisplayDetails();

        // Using constructor with RollNo only
        Student s2 = new Student(101);
        Console.WriteLine("\nUsing Constructor with RollNo:");
        s2.DisplayDetails();

        // Using constructor with Name and RollNo
        Student s3 = new Student("Alice", 102);
        Console.WriteLine("\nUsing Constructor with Name and RollNo:");
        s3.DisplayDetails();

        // Using constructor with Name, RollNo, and Course
        Student s4 = new Student("Bob", 103, "Computer Science");
        Console.WriteLine("\nUsing Constructor with Name, RollNo, and Course:");
        s4.DisplayDetails();
    }
}
