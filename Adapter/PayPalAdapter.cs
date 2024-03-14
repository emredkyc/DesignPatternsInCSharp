public class PayPalAdapter : IPaymentGateway
{
    private readonly PayPal _payPal;

    public PayPalAdapter(PayPal payPal)
    {
        _payPal = payPal;
    }

    public void ProcessPayment(string merchantId, decimal amount)
    {
        _payPal.SendPayment(amount); // Translate and forward the call
    }
}