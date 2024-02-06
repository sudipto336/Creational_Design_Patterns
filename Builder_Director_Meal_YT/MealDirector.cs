using Builder_Director_Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Meal_YT
{
    internal class MealDirector
    {
        private readonly MealBuilder _builder;

        public MealDirector(MealBuilder builder)
        {
            _builder = builder;
        }

        public Meal PrepareMeal()
        {
            _builder.AddBiryani();
            _builder.AddBread();
            _builder.AddColdDrink();
            _builder.AddCurry();
            return _builder.BuildMeal();
        }

    }
}
