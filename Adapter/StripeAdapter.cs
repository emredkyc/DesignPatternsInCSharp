public class StripeAdapter : IPaymentGateway
{
    private readonly Stripe _stripe;

    public StripeAdapter(Stripe stripe)
    {
        _stripe = stripe;
    }

    public void ProcessPayment(string merchantId, decimal amount)
    {
        _stripe.MakePayment(merchantId, amount); // Translate and forward the call
    }
}