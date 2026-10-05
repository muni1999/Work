namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.txt";

            try
            {
                // Initialize a list of integers
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Write the list to a file
                File.WriteAllLines(filePath, numbers.Select(n => n.ToString()));
                Console.WriteLine("Data written to file successfully.");

                // Read the data back from the file
                List<int> fileNumbers = File.ReadAllLines(filePath)
                                            .Select(line => int.Parse(line))
                                            .ToList();

                Console.WriteLine("Data read from file:");
                fileNumbers.ForEach(Console.WriteLine);

                // Perform a LINQ query on the data
                var filteredNumbers = fileNumbers.Where(n => n > 25).ToList();

                Console.WriteLine("Filtered numbers (greater than 25):");
                filteredNumbers.ForEach(Console.WriteLine);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"File handling error: {ioEx.Message}");
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine($"Data format error: {formatEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
