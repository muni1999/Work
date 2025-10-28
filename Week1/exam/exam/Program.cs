namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" 1 fact");
            Console.WriteLine("2 pa;in");
            Console.WriteLine("3 rev");
            Console.WriteLine("4 even");
            double n = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                long fact = 1;
                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);

            }
            else if (n == 2)
            {
                int reversed = 0;
                int temp = num;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    reversed = reversed * 10 + digit;
                    temp = temp / 10;
                }
                Console.WriteLine(reversed);



            }
            else if (n == 3)
            {
                int reversed = 0;
                int temp = num;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    reversed = reversed * 10 + digit;
                    temp = temp / 10;
                }

                if (reversed == num)
                {
                    Console.WriteLine("ame");
                }
                else
                {
                    Console.WriteLine("not");
                }


            }
            else if (n == 4)
            {
                if (n % 2 == 0)
                {
                    Console.Write("even");
                }
                else
                {
                    Console.WriteLine("not");


                }

            }
        }
    }mbox,k
}
