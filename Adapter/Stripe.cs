public class Stripe
{
    public void MakePayment(string merchantId, decimal amount)
    {
        Console.WriteLine($"Paying via Stripe: {amount}");
    }
}