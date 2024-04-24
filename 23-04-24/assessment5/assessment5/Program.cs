using System;

class PersonBankAccnt
{
    private static string bankName;

    private const double MinimumBalance = 1000;
    private const double RateOfInterest = 10;
    private const int PeriodicityMonths = 6;

    private double balance;

   

    public static void RenameBank(string newName)
    {
        bankName = newName;
    }

    public PersonBankAccnt(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (balance - amount >= MinimumBalance)
        {
            balance -= amount;
            Console.WriteLine($" Rs {amount} withdrawl form your A/C ********4566 \n Current balance: {balance} \n Ref:112234455 Not You? call 100002- {bankName} ");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit of Rs {amount} successful. Current balance: ${balance}");
    }

    public void AddInterest()
    {
        double interest = (balance * RateOfInterest * PeriodicityMonths) / (100 * 12);
        balance += interest;
        Console.WriteLine($" for {PeriodicityMonths} time Period { interest}  Interest added. Current balance: ${balance}");
    }

    public void AddInterest(int timePeriod)
    {
        double interest = (balance * RateOfInterest * timePeriod) / (100 * 12);
        balance += interest;
        Console.WriteLine($"for {timePeriod} Time period { interest} Interest added. Current balance: ${balance}");
    }



    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PersonBankAccnt account = new PersonBankAccnt(3000);

        Console.WriteLine("Enter the bank name:");

        string bankName = Console.ReadLine();

        PersonBankAccnt.RenameBank(bankName);

        Console.WriteLine(" Select Option \n 1 withdraw \n 2 Deposit \n 3 Add Intrest \n 4 Add Custom Intrest \n 5 check Balance \n -------------------");

        int operation = Convert.ToInt32(Console.ReadLine());
        if (operation == 1)
        {
            Console.Write("Enter amount to Withdraw : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(amt);

        }
        else if (operation == 2)
        {
            Console.Write("Enter amount to Deposit : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            account.Deposit(amt);
        }
        else if (operation == 3)
        {
            account.AddInterest();
        }
        else if(operation == 4)
        {
            Console.Write("Enter Time period :");
            int timPeriod = Convert.ToInt32(Console.ReadLine());
            account.AddInterest(timPeriod);
        }
        else if( operation == 5)
        {
            Console.WriteLine($"Current balance: ${account.GetBalance()}");

        }
        else
        {
            Console.WriteLine("Invalid option");
        }
        
    }
}


