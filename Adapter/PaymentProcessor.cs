public class PaymentProcessor
{
    public void ProcessPayment(IPaymentGateway paymentGateway, string merchantId, decimal amount)
    {
        paymentGateway.ProcessPayment(merchantId, amount);
    }
}