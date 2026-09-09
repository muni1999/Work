using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string filePath = "student.json";

        try
        {
            // Create a student object
            Student stu = new Student
            {
                Id = 1,
                Name = "Muni",
                Marks = 95
            };

            // Write JSON to file
            WriteJson(filePath, stu);

            // Read JSON from file
            Student data = ReadJson(filePath);

            Console.WriteLine($"Student: {data.Id}, {data.Name}, {data.Marks}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }
    }

    // Serialize object → JSON → File
    static void WriteJson(string path, Student student)
    {
        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }

    // Read JSON from File → Deserialize → Object
    static Student ReadJson(string path)
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Student>(json);
    }
}

// Simple Student class
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

