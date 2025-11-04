using System;

public class Student
{
   
    public string Name { get; set; }
    public int RollNo { get; set; }

   
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}");
    }

    // Main method
    public static void Main(string[] args)
    {
        // Create multiple student objects
        Student s1 = new Student { Name = "Alice", RollNo = 1 };
        Student s2 = new Student { Name = "Bob", RollNo = 2 };
        Student s3 = new Student { Name = "Charlie", RollNo = 3 };

        // Display details
        s1.DisplayDetails();
        s2.DisplayDetails();
        s3.DisplayDetails();
    }
}
