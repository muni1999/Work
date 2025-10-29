namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(" 1 . Fact");
            Console.WriteLine(" 2 . Rev");
            Console.WriteLine(" 3 . Palindrome");
            Console.WriteLine(" 4 . even or odd");
            Console.WriteLine(" chosse one option and enter the No");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
               
                long fact = 1;
                for (int i = 1; i < num; i++)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
            else if (n == 2)
            {
               
                int temp = num;
                int rev = 0;
                while (temp > 0)
                {
                    int dig = temp % 10;
                    rev = rev * 10 + dig;
                    temp /= 10;
                }
                Console.WriteLine(rev);

            }
            else if (n == 3)
            {
                
                int temp = num;
                int rev = 0;
                while (temp > 0)
                {
                    int dig = temp % 10;
                    rev = rev * 10 + dig;
                    temp /= 10;
                }
                if (num == rev)
                {
                    Console.WriteLine("pali");
                }
                else
                {
                    Console.WriteLine("not");
                }
            }
            else if (n == 4)

            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("not");
                }

            }
            else
            {
                Console.WriteLine("wromng entry try again");
            }
        }
    }
}
