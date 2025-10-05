using System;
public class OldPaymentGateway
{
    public void MakePayment(string customer, double amount)
    {
        Console.WriteLine($"[Old Gateway] Customer: {customer}, Amount: {amount}");
    }
}
public interface INewPaymentProcessor
{
    void ProcessPayment(string customer, double amount);
}
public class PaymentAdapter : INewPaymentProcessor
{
    private OldPaymentGateway _oldGateway;

    public PaymentAdapter(OldPaymentGateway oldGateway)
    {
        _oldGateway = oldGateway;
    }

    public void ProcessPayment(string customer, double amount)
    {
        _oldGateway.MakePayment(customer, amount);
    }
}
class Program
{
    static void Main()
    {
        OldPaymentGateway oldGateway = new OldPaymentGateway();
        INewPaymentProcessor paymentProcessor = new PaymentAdapter(oldGateway);
        paymentProcessor.ProcessPayment("Alice", 2500);
    }
}
