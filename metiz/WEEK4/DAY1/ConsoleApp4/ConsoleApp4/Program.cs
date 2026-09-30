namespace ConsoleApp4
{
    internal class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }
        public void Fetch()
        {
            Console.WriteLine($"{Name} will fetch a stick.");
        }
        public void Fetch(string item)
        {
            Console.WriteLine($"{Name} is fetching a {item}.");
        }
    }
    internal class TestSet
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("Generic Animal");
            genericAnimal.Speak();
            Dog dog = new Dog("Thor", "Golden Retriever");
            dog.Speak();
            dog.Fetch();
            dog.Fetch("ball");
        }
    }
}
}
