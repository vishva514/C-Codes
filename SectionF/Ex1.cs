using System;
public class InsufficientFundsException : Exception
{

    public double Requested { get; }
    public double Available { get; }

    public InsufficientFundsException(double requested, double available)
        : base($"Insufficient funds: requested {requested}, available {available}.")
    {
        Requested = requested;
        Available = available;
    }

    public InsufficientFundsException() { }
    public InsufficientFundsException(string message) : base(message) { }
    public InsufficientFundsException(string message, Exception inner) : base(message, inner) { }
}

public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0) throw new ArgumentException("Initial balance cannot be negative.", nameof(initialBalance));
        balance = initialBalance;
    }

    public double Balance => balance;

    public void Deposit(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Withdraw amount must be positive.", nameof(amount));

        if (amount > balance)
        {
            throw new InsufficientFundsException(amount, balance);
        }

        balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = null;

        try
        {
            account = new BankAccount(100);   
            Console.WriteLine($"Starting balance: {account.Balance}");
            account.Withdraw(150);

            Console.WriteLine("Withdrawal successful.");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Custom exception caught:");
            Console.WriteLine("  Message : " + ex.Message);
            Console.WriteLine($"  Requested: {ex.Requested}, Available: {ex.Available}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Argument error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        { 
            Console.WriteLine("Finally: cleaning up resources (closing connections, releasing locks, etc.).");

            if (account != null)
            {
                Console.WriteLine($"Final balance: {account.Balance}");
            }
        }

        Console.WriteLine("Program continues after try/catch/finally.");
    }
}
