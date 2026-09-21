namespace Consturtors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person defaultPerson = new Person();
            Console.WriteLine($"Default Person: Name = {defaultPerson.Name}, Age = {defaultPerson.Age}");

            
            Person parameterizedPerson = new Person("John Doe", 30);
            Console.WriteLine($"Parameterized Person: Name = {parameterizedPerson.Name}, Age = {parameterizedPerson.Age}");
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        

        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
