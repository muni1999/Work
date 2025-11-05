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

        // Method to display employee info
        public void DisplayInfo()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            
            emp.DisplayInfo();

            Console.ReadLine();
        }
    }
}

