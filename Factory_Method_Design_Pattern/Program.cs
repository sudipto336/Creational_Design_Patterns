namespace Factory_Method_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new PlatinumFactory().CreateCreditCard();
            Console.WriteLine($"Credit card limit: {card.GetCreditLimit()}");
            Console.WriteLine($"Credit annual charge: {card.GetAnnualCharge()}"); 
        }
    }
}
