using System;
namespace D4t1
{
    
        public interface IPrintable
        {
            void Print();
        }

        
        public class Document : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("Printing document details...");
            }
        }

      
        class Program
        {
            static void Main(string[] args)
            {
                IPrintable printable = new Document();
                printable.Print();

                Console.ReadLine();
            }
        }
    
}
