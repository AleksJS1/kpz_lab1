using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FoodDatabaseManager
    {
        private readonly string jsonFilePath = "FoodDataBase.json";
        public List<FoodItem> FoodDatabase { get; private set; }

        public FoodDatabaseManager()
        {
            LoadFoodDatabase();
        }

        private void LoadFoodDatabase()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    FoodDatabase = JsonSerializer.Deserialize<List<FoodItem>>(jsonString) ?? new List<FoodItem>();
                }
                else
                {
                    FoodDatabase = new List<FoodItem>
                    {
                        new FoodItem("Яблуко", 52),
                        new FoodItem("Банан", 96),
                        new FoodItem("Куряче філе", 165),
                        new FoodItem("Рис", 130),
                        new FoodItem("Молоко", 42)
                    };

                    SaveFoodDatabase();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка завантаження бази продуктів: {ex.Message}");
            }
        }

        public void SaveFoodDatabase()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(FoodDatabase, options);
                File.WriteAllText(jsonFilePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при збереженні бази даних: {ex.Message}");
            }
        }

        public void AddFoodItem(FoodItem food)
        {
            if (FoodDatabase.Any(f => f.Name.Equals(food.Name, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Цей продукт вже є в базі даних!");

            FoodDatabase.Add(food);
            SaveFoodDatabase();
        }
    }
}
