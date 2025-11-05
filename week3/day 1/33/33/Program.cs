using System;

namespace EmployeeApp
{
    class Employee
    {
        // Private fields
        private int empId;
        private string name;
        private double salary;

        // Public properties
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Default constructor
        public Employee()
        {
            empId = 0;
            name = "Unknown";
            salary = 0.0;
        }

        // Constructor with ID and Name
        public Employee(int id, string empName)
        {
            empId = id;
            name = empName;
            salary = 0.0;
        }

        // Constructor with ID, Name, and Salary
        public Employee(int id, string empName, double empSalary)
        {
            empId = id;
            name = empName;
            salary = empSalary;
        }

        // Method to display employee info
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Using default constructor
            Employee emp1 = new Employee();
            Console.WriteLine("Employee 1 (Default Constructor):");
            emp1.DisplayInfo();

            // Using constructor with ID and Name
            Employee emp2 = new Employee(101, "John");
            Console.WriteLine("\nEmployee 2 (ID, Name Constructor):");
            emp2.DisplayInfo();

            // Using constructor with ID, Name, and Salary
            Employee emp3 = new Employee(102, "Sarah", 75000);
            Console.WriteLine("\nEmployee 3 (Full Constructor):");
            emp3.DisplayInfo();

            Console.ReadLine();
        }
    }
}
