namespace miuu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.DisplayMessage();

            ChildClass childObj = new ChildClass();
            childObj.DisplayMessage();
        }
    }

    internal class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass.");
        }
    }

    internal class ChildClass : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from ChildClass.");
        }
    }
}
