using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Синглтон для управління базою даних продуктів
    /// Гарантує, що існує лише один екземпляр FoodDatabaseManager
    /// </summary>
    public sealed class FoodDatabaseManagerSingleton
    {
        private static FoodDatabaseManagerSingleton _instance;
        private static readonly object _lock = new object();
        
        private readonly string jsonFilePath = "FoodDataBase.json";
        public List<FoodItem> FoodDatabase { get; private set; }

        private FoodDatabaseManagerSingleton()
        {
            LoadFoodDatabase();
        }

        /// <summary>
        /// Отримує єдиний екземпляр FoodDatabaseManagerSingleton
        /// </summary>
        public static FoodDatabaseManagerSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new FoodDatabaseManagerSingleton();
                        }
                    }
                }
                return _instance;
            }
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
