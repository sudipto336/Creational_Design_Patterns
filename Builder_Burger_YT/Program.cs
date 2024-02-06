namespace Builder_Burger_YT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new Burger.BurgerBuilder().SetSize("large").SetSauce(true).SetLettuce(true).SetExtraCheese(false).SetOnion(true).SetMayonese(false).BuildBurger();
            string burgerSize = $"Burger size: {burger.Size}";
            string isSauceAdded = burger.Sauce ? "Sauce added in the burger" : "Sauce is not added in the burger";
            string isMayoneseAdded = burger.Mayonese ? "Mayonese added in the burger" : "Mayonese is not added in the burger";
            string isOnionAdded = burger.Onion ? "Onion added in the burger" : "Onion is not added in the burger";
            string isExtraCheeseAdded = burger.ExtraCheese ? "Extra cheese added in the burger" : "Extra cheese is not added in the burger";
            string isLettuceAdded = burger.Lettuce ? "Lettuce added in the burger" : "Lettuce is not added in the burger";
            Console.WriteLine($"{burgerSize}");
            Console.WriteLine($"{isSauceAdded}");
            Console.WriteLine($"{isMayoneseAdded}");
            Console.WriteLine($"{isOnionAdded}");
            Console.WriteLine($"{isExtraCheeseAdded}");
            Console.WriteLine($"{isLettuceAdded}");
        }
    }
}
