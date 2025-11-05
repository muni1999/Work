using System;
using System.Collections.Generic;

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
            Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
        }

        // Method to update salary
        public void UpdateSalary(double amount)
        {
            salary += amount; // Increase or decrease salary
            Console.WriteLine($"{Name}'s salary updated to {salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Employee emp = new Employee();

                Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                Console.Write("Employee ID: ");
                emp.EmpId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Employee Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Employee Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(emp);
            }

            Console.WriteLine("\n--- Employee List ---");
            foreach (var emp in employees)
            {
                emp.DisplayInfo();
            }

            // Test UpdateSalary method
            Console.Write("\nEnter Employee ID to update salary: ");
            int idToUpdate = Convert.ToInt32(Console.ReadLine());

            Employee foundEmp = employees.Find(e => e.EmpId == idToUpdate);
            if (foundEmp != null)
            {
                Console.Write("Enter amount to modify salary (use negative to decrease): ");
                double amount = Convert.ToDouble(Console.ReadLine());
                foundEmp.UpdateSalary(amount);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }

            Console.WriteLine("\n--- Updated Employee List ---");
            foreach (var emp in employees)
            {
                emp.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}

