using System;

class Program
{

    static string ReverseString(string str)
    {
        string reverse = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }

        return reverse;
    }

  
    static int CountVowels(string str)
    {
        int count = 0;

        foreach (char ch in str.ToLower())
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' ||
                ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        return count;
    }

    
    static int ArraySum(int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    static void Main()
    {
        
        string text = "Hello";
        Console.WriteLine("Original String: " + text);
        Console.WriteLine("Reversed String: " + ReverseString(text));

        Console.WriteLine("Vowel Count: " + CountVowels(text));

        
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array Sum: " + ArraySum(numbers));
    }
}
