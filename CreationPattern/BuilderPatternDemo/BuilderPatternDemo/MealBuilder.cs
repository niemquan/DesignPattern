using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class MealBuilder
    {
        public Meal PrepareVegtableMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegtableBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareChickenMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
