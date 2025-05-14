using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Meal
    {
        public List<(FoodItem, double)> Items { get; private set; }

        public Meal()
        {
            Items = new List<(FoodItem, double)>();
        }

        public void AddFoodItem(FoodItem item, double weightInGrams)
        {
            Items.Add((item, weightInGrams));
        }

        public double CalculateTotalCalories()
        {
            double total = 0;
            foreach (var (food, weight) in Items)
            {
                total += (food.CaloriesPer100g * weight) / 100;
            }
            return total;
        }
    }
}
