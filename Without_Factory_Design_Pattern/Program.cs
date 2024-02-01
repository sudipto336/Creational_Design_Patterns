namespace Without_Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter card name: ");
            string cardType = Console.ReadLine();

            CreditCard card;

            if(cardType.Equals("MoneyBack"))
            {
                card = new MoneyBack();
            } else if (cardType.Equals("Platinum"))
            {
                card = new Platinum();
            } else
            {
                card = new Titanium();
            }

            Console.WriteLine($"Card annual charge: {card.GetAnnualCharge()}");
            Console.WriteLine($"Card credit limit: {card.GetCreditLimit()}");
        }
    }
}
