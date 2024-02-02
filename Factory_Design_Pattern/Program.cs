namespace Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter card name: ");
            string cardName = Console.ReadLine();

            CreditCard card = CrediCardFactory.GetCreditCard(cardName);
            Console.WriteLine($"Card annual charge: {card.GetAnnualCharge()}");
            Console.WriteLine($"Card credit limit: {card.GetCreditLimit()}");
        }
    }
}
