/* In this example, the PayPalAdapter and StripeAdapter classes adapt the 
 * interfaces of the PayPal and Stripe payment services, respectively, 
 * to the IPaymentGateway interface expected by your application. 
 * This allows your application to support multiple payment gateways seamlessly, 
 * facilitating easy integration and expansion with minimal changes to the core application code. */

IPaymentGateway paypalGateway = new PayPalAdapter(new PayPal());
IPaymentGateway stripeGateway = new StripeAdapter(new Stripe());

PaymentProcessor processor = new PaymentProcessor();

// Process payment through PayPal
processor.ProcessPayment(paypalGateway, "merchant123", 100.00m);

// Process payment through Stripe
processor.ProcessPayment(stripeGateway, "merchant456", 200.00m);