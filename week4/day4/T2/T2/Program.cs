using System;
using System.IO;

namespace Day4_Task
{
    class ReadFileProgram
    {
        static void Main(string[] args)
        {
            string filePath = "UserInput.txt";

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("----- File Content -----");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("File not found. Make sure UserInput.txt exists.");
            }
        }
    }
}
