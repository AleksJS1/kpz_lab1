namespace ClassLibrary
{
    public class FoodItem
    {
        public string Name { get; set; }
        public double CaloriesPer100g { get; set; }

        public FoodItem(string name, double caloriesPer100g)
        {
            Name = name;
            CaloriesPer100g = caloriesPer100g;
        }

        public override string ToString()
        {
            return $"{Name} ({CaloriesPer100g} ккал/100г)";
        }
    }

}
