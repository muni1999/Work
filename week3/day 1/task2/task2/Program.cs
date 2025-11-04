using System;

public class Student
{
    // Properties
    public string Name { get; set; }
    public int RollNo { get; set; }

    // Default constructor
    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
    }

    // Parameterized constructor
    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}");
    }

    // Main method
    public static void Main(string[] args)
    {
        // Using default constructor
        Student s1 = new Student();
        Console.WriteLine("Using Default Constructor:");
        s1.DisplayDetails();

        // Using parameterized constructor
        Student s2 = new Student("Alice", 101);
        Student s3 = new Student("Bob", 102);

        Console.WriteLine("\nUsing Parameterized Constructor:");
        s2.DisplayDetails();
        s3.DisplayDetails();
    }
}

