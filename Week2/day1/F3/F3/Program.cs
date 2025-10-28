namespace F3
{
    internal class Program
    {
        
            static int Square(int n)
            {
                return n * n;   
            }

            static void Main(string[] args)
            {
                
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int result = Square(num);

              
                Console.WriteLine($"Square of {num} = {result}");
              
            }
        
    }
}
