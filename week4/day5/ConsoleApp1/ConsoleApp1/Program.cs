using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Account
{
    public string AccountNumber { get; set; }
    public string Name { get; set; }
    public double Balance { get; private set; }

    public Account() { }

    public Account(string number, string name, double balance)
    {
        AccountNumber = number;
        Name = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (Balance < amount)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }
}


public class BankSystem
{
    private const string FilePath = "accounts.json";
    private List<Account> accounts = new List<Account>();

    public BankSystem()
    {
        LoadAccounts();
    }

    
    public void CreateAccount(string accNo, string name, double initialBalance)
    {
        accounts.Add(new Account(accNo, name, initialBalance));
        SaveAccounts();
    }

    private Account GetAccount(string accNo)
    {
        var acc = accounts.Find(a => a.AccountNumber == accNo);
        if (acc == null)
            throw new Exception("Account not found.");
        return acc;
    }

    // Deposit
    public void Deposit(string accNo, double amount)
    {
        var acc = GetAccount(accNo);
        acc.Deposit(amount);
        SaveAccounts();
    }

    // Withdraw
    public void Withdraw(string accNo, double amount)
    {
        var acc = GetAccount(accNo);
        acc.Withdraw(amount);
        SaveAccounts();
    }

    // Transfer
    public void Transfer(string fromAcc, string toAcc, double amount)
    {
        if (fromAcc == toAcc)
            throw new Exception("Cannot transfer to the same account.");

        var sender = GetAccount(fromAcc);
        var receiver = GetAccount(toAcc);

        sender.Withdraw(amount);
        receiver.Deposit(amount);

        SaveAccounts();
    }

    
    private void SaveAccounts()
    {
        var json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    
    private void LoadAccounts()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            accounts = JsonSerializer.Deserialize<List<Account>>(json);
        }
    }


    public void DisplayAccounts()
    {
        foreach (var a in accounts)
        {
            Console.WriteLine($"{a.AccountNumber} - {a.Name} - Balance: {a.Balance}");
        }
    }
}


public class Program
{
    public static void Main()
    {
        var bank = new BankSystem();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- BANK SYSTEM ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. View Accounts");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");

            try
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Acc No: ");
                        string acc = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        double bal = double.Parse(Console.ReadLine());
                        bank.CreateAccount(acc, name, bal);
                        Console.WriteLine("Account created!");
                        break;

                    case 2:
                        Console.Write("Enter Acc No: ");
                        bank.Deposit(Console.ReadLine(), double.Parse(Console.ReadLine()));
                        Console.WriteLine("Deposit successful!");
                        break;

                    case 3:
                        Console.Write("Enter Acc No: ");
                        bank.Withdraw(Console.ReadLine(), double.Parse(Console.ReadLine()));
                        Console.WriteLine("Withdraw successful!");
                        break;

                    case 4:
                        Console.Write("From Acc: ");
                        string from = Console.ReadLine();
                        Console.Write("To Acc: ");
                        string to = Console.ReadLine();
                        Console.Write("Amount: ");
                        double amt = double.Parse(Console.ReadLine());
                        bank.Transfer(from, to, amt);
                        Console.WriteLine("Transfer successful!");
                        break;

                    case 5:
                        bank.DisplayAccounts();
                        break;

                    case 6:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error: {ex.Message}");
            }
        }
    }
}

