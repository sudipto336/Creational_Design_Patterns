using Builder_Director_Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Meal_YT
{
    internal class VegMealBuilder : MealBuilder
    {
        Meal meal;

        public VegMealBuilder()
        {
            meal = new Meal();
        }

        public override void AddBiryani()
        {
            meal.Biryani = "Veg";
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
            meal.Curry = "Mushroom";
        }

        public override Meal BuildMeal()
        {
            return meal;
        }
    }
}
