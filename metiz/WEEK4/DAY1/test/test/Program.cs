namespace test
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
        public Dog(string name) : base(name)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("Generic Animal");
            genericAnimal.Speak();
            Dog dog = new Dog("Buddy");
            dog.Speak();
            Cat cat = new Cat("Whiskers");
            cat.Speak();
            PrintAnimalInfo(genericAnimal);
            PrintAnimalInfo(dog, "Lab");
        }
        static void PrintAnimalInfo(Animal animal)
        {
            Console.WriteLine($"Animal Name: {animal.Name}");
        }
        static void PrintAnimalInfo(Animal animal, string breed)
        {
            Console.WriteLine($"Animal Name: {animal.Name}, Breed: {breed}");
        }
    }
}
