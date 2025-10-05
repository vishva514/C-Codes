using System;
public interface IPaymentStrategy
{
    void Pay(double amount);
}
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

public class BankTransferPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Bank Transfer.");
    }
}
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;
    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void Checkout(double amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("No payment method selected!");
        }
        else
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
class Program
{
    static void Main()
    {
        PaymentContext context = new PaymentContext();
        context.SetPaymentStrategy(new CreditCardPayment());
        context.Checkout(2500);
        context.SetPaymentStrategy(new PayPalPayment());
        context.Checkout(1500);
        context.SetPaymentStrategy(new BankTransferPayment());
        context.Checkout(5000);
    }
}
