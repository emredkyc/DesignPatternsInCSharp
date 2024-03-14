public interface IPaymentGateway
{
    void ProcessPayment(string merchantId, decimal amount);
}
