namespace hioop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Doe", "Software Engineer");
            employee.DisplayInfo();
            employee.Work();
        }
    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    internal class Employee : Person
    {
        public string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string jobTitle)
            : base(firstName, lastName)
        {
            JobTitle = jobTitle;
        }

        public void Work()
        {
            Console.WriteLine($"{FirstName} is working as a {JobTitle}.");
        }
    }
}
