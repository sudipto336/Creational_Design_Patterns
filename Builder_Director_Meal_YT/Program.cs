using Builder_Director_Meal_YT;
using System;

namespace Builder_Director_Meal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meal meal = new MealDirector(new VegMealBuilder()).PrepareMeal();
            Console.WriteLine($"Biryani: {meal.Biryani}");
            Console.WriteLine($"Bread: {meal.Bread}");
            Console.WriteLine($"Cold Drink: {meal.ColdDrink}");
            Console.WriteLine($"Curry: {meal.Curry}");
            Console.WriteLine("================================================");
            Meal meal2 = new MealDirector(new NonVegMealBuilder()).PrepareMeal();
            Console.WriteLine($"Biryani: {meal2.Biryani}");
            Console.WriteLine($"Bread: {meal2.Bread}");
            Console.WriteLine($"Cold Drink: {meal2.ColdDrink}");
            Console.WriteLine($"Curry: {meal2.Curry}");
        }
    }
}
