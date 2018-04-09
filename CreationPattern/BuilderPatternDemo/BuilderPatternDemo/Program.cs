using System;

namespace BuilderPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegtableMeal();
            Console.WriteLine("\n\nPrepare the vegtable meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total: "+vegMeal.GetCost());

            Meal chickenMeal = mealBuilder.PrepareChickenMeal();
            Console.WriteLine("\n\nPrepare the chicken meal");
            chickenMeal.ShowItems();
            Console.WriteLine("Total: " + chickenMeal.GetCost());
            Console.ReadKey();
        }
    }
}
