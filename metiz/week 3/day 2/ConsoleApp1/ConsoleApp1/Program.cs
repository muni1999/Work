namespace ConsoleApp1
{
    internal class Program
    {
        private string _name;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Name = "Hello, World!";
            Console.WriteLine(program.Name);
        }
    }
}
