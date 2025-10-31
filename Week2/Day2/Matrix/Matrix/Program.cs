namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];

            Console.WriteLine("Enter elements for a 2x2 matrix:");

        
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe 2x2 Matrix is:\n");

           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
