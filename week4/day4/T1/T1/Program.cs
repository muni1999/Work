using System;
using System.IO;

namespace Day4_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text to save into a file: ");
            string userInput = Console.ReadLine();

            // File name & path
            string filePath = "UserInput.txt";

            // Write user input to file
            File.WriteAllText(filePath, userInput);

            Console.WriteLine("\nData saved successfully into UserInput.txt");
        }
    }
}
