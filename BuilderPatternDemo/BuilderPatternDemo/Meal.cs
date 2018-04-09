using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class Meal
    {
        private readonly List<IItem> Items = new List<IItem>();

        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (var item in Items)
            {
                cost += item.Price();
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine("   Item: " + item.Name() +" "+ item.Price());
            }
        }

    }
}
