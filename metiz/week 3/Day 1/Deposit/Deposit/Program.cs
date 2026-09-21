namespace Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine($"Current Balance: {account.GetBalance()}");
        }
    }

    public class BankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            _balance -= amount;
            Console.WriteLine($"Withdrew: {amount}");
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
