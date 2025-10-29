namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chosse option");
            Console.WriteLine(" 1.factorial");
            Console.WriteLine("2 .reverse");
            Console.WriteLine(" 3. Palindrome");
            Console.WriteLine(" 4 .odd or even");
            int n = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Number");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                long fact = 1;
                for (int i = 1; i <= m; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);
            }
            else if (n == 2)
            {
                int temp = m;
                int rev = 0;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    rev = rev * 10 + digit;
                    temp = temp / 10;
                }
                Console.WriteLine(rev);
            }
            else if (n == 3)
            {
                int temp = m;
                int rev = 0;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    rev = rev * 10 + digit;
                    temp = temp / 10;
                }
                Console.WriteLine(rev);
                if (m == rev)
                {
                    Console.WriteLine("Same");
                }
                else
                {
                    Console.WriteLine("not");

                }
            }
            else if (n == 4)
            {
                if (m%2 == 0)
                {
                    Console.WriteLine("even");

                }
                else {
                    Console.WriteLine("Odd");

                }
            }
            else {
                Console.WriteLine("Error try it again");
                    }

        }
    }
}
