using System;

interface IPrintable
{
    void PrintDetails();
}

abstract class Person : IPrintable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Work();

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student : Person
{
    public string Course { get; set; }
    public double GPA { get; set; }

    public Student(string name, int age, string course, double gpa)
        : base(name, age)
    {
        Course = course;
        GPA = gpa;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is studying for the {Course} course.");
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Course: {Course}, GPA: {GPA}");
    }
}

class Employee : Person
{
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, string department, double salary)
        : base(name, age)
    {
        Department = department;
        Salary = salary;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} is working in the {Department} department.");
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Department: {Department}, Salary: {Salary:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Muni", 22, "Computer Science", 3.8);
        Employee e1 = new Employee("Reddy", 30, "IT", 85000);

        Person[] people = { s1, e1 };

        foreach (Person p in people)
        {
            p.PrintDetails();
            p.Work();
            Console.ReadKey();
            
        }
    }
}
