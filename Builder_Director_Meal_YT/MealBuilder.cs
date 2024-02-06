using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Director_Meal
{
    internal abstract class MealBuilder
    {
        public abstract void AddBiryani();
        public abstract void AddBread();
        public abstract void AddColdDrink();
        public abstract void AddCurry();
        public abstract Meal BuildMeal();
    }
}
