namespace Factory_Design_Pattern_Payment_Gateway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select payment gateway (paytm, billdesk, razorpay)");

            string gatewayName = Console.ReadLine();

            try
            {
                PaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                paymentGateway.ProcessPayment(1000);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
