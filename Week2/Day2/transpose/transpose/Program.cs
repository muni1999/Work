namespace transpose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            int[,] transpose = new int[2, 2];

            Console.WriteLine("Enter elements for a 2x2 matrix:");

            // Taking input from the user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Finding transpose
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    transpose[i, j] = matrix[j, i];
                }
            }

            // Displaying original matrix
            Console.WriteLine("\nOriginal Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

           
            Console.WriteLine("\nTransposed Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(transpose[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
