using Builder_Director_Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Meal_YT
{
    internal class NonVegMealBuilder : MealBuilder
    {
        Meal meal;

        public NonVegMealBuilder()
        {
            meal = new Meal();
        }

        public override void AddBiryani()
        {
            meal.Biryani = "Chicken";
        }

        public override void AddBread()
        {
            meal.Bread = "Naan";
        }

        public override void AddColdDrink()
        {
            meal.ColdDrink = "Sprite";
        }

        public override void AddCurry()
        {
            meal.Curry = "Fish";
        }

        public override Meal BuildMeal()
        {
            return meal;
        }
    }
}
