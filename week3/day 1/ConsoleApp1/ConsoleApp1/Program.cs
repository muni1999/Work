using System;

public class Program
{
    static int Add(int a, int b) => a + b;

    static int MaxOfThree(int a, int b, int c)
    {
        if (a >= b && a >= c) return a;
        else if (b >= a && b >= c) return b;
        else return c;
    }

    static int Square(int n) => n * n;

    static void CreateAndDisplayArray()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Array:");
        foreach (int item in arr) Console.Write(item + " ");
        Console.WriteLine();
    }

    static void SumOfArrayElements()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        foreach (int val in arr) sum += val;
        Console.WriteLine("Sum = " + sum);
    }

    static void ReverseArray()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Reversed array:");
        for (int i = size - 1; i >= 0; i--) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void FindLargestElement()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        int max = arr[0];
        for (int i = 1; i < size; i++) if (arr[i] > max) max = arr[i];
        Console.WriteLine("Largest element = " + max);
    }

    static void TransposeMatrix()
    {
        Console.Write("Enter rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Transpose:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
                Console.Write(matrix[j, i] + " ");
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add Numbers");
            Console.WriteLine("2. Max of Three");
            Console.WriteLine("3. Square of a Number");
            Console.WriteLine("4. Create and Display Array");
            Console.WriteLine("5. Sum of Array Elements");
            Console.WriteLine("6. Reverse Array");
            Console.WriteLine("7. Find Largest Element");
            Console.WriteLine("8. Transpose of Matrix");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter two numbers: ");
                    Console.WriteLine("Sum = " + Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case 2:
                    Console.Write("Enter three numbers: ");
                    Console.WriteLine("Max = " + MaxOfThree(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case 3:
                    Console.Write("Enter number: ");
                    Console.WriteLine("Square = " + Square(Convert.ToInt32(Console.ReadLine())));
                    break;
                case 4:
                    CreateAndDisplayArray();
                    break;
                case 5:
                    SumOfArrayElements();
                    break;
                case 6:
                    ReverseArray();
                    break;
                case 7:
                    FindLargestElement();
                    break;
                case 8:
                    TransposeMatrix();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
