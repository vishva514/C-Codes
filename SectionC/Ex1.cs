using System;
class Bank
{
    private double balance;


    public Bank(double initial)
    {
        if (initial >= 0)
        {
            balance += initial;
        }
        else balance = 0;

    }
    public void withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("the amount is not available in yout account");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"the balance {balance}");
        }
    }
}

class Tasks
{
    public static void Main()
    {
        Bank demo = new Bank(2000);
        demo.withdraw(500);
    }
}
