using System;
using System.Text.Json;
using System.IO;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calculator
{
    public partial class CalorieCalc : Form
    {
        private List<FoodItem> foodDatabase;
        private Meal currentMeal;
        private double dailyCalorieNorm;
        public CalorieCalc()
        {
            InitializeComponent();
            InitializeFoodDatabase();
            currentMeal = new Meal();
        }
        private void InitializeFoodDatabase()
        {
            try
            {
                string jsonFilePath = "E:\\STUDY ZTU\\1course\\Курсове Проєктування\\CalculatorCalories\\foodDataBase.json";
                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath);

                    foodDatabase = JsonSerializer.Deserialize<List<FoodItem>>(jsonString);

                    comboBoxFood.Items.Clear();
                    foreach (var food in foodDatabase)
                    {
                        comboBoxFood.Items.Add(food);
                    }

                    if (comboBoxFood.Items.Count > 0)
                    {
                        comboBoxFood.SelectedIndex = 0;
                    }
                }
                else
                {
                    foodDatabase = new List<FoodItem>
            {
                new FoodItem("Яблуко", 52),
                new FoodItem("Банан", 96),
                new FoodItem("Куряче філе", 165),
                new FoodItem("Рис", 130),
                new FoodItem("Молоко", 42)
            };

                    SaveFoodDatabaseToJson();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження бази продуктів: {ex.Message}", "Помилка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveFoodDatabaseToJson()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                string jsonString = JsonSerializer.Serialize(foodDatabase, options);
                File.WriteAllText("foodDatabase.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні бази даних: {ex.Message}", "Помилка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CalorieCalc(double weight, double height, string gender, int age, double activityLevel, double dailyCalories)
        {
            InitializeComponent();
            InitializeFoodDatabase();
            currentMeal = new Meal();
            this.dailyCalorieNorm = dailyCalories;
            calorieNorm.Text = $"Денна норма: {dailyCalorieNorm:F0} ккал";
        }


        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxFood.SelectedItem is FoodItem selectedFood &&
        double.TryParse(textBoxWeight.Text, out double weight) &&
        weight > 0)
            {
                currentMeal.AddFoodItem(selectedFood, weight);
                listBoxItems.Items.Add($"{selectedFood.Name} - {weight}г");
                labelTotalCalories.Text = $"Загальна кількість калорій: {currentMeal.CalculateTotalCalories():F2} ккал";
                textBoxWeight.Clear();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректну вагу продукту!", "Помилка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddNewFoodToDatabase()
        {
            string name = textBoxNewFoodName.Text.Trim();
            if (double.TryParse(textBoxNewFoodCalories.Text, out double calories))
            {
                if (foodDatabase.Any(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Цей продукт вже є в базі даних!", "Попередження",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FoodItem newFood = new FoodItem(name, calories);

                foodDatabase.Add(newFood);
                comboBoxFood.Items.Add(newFood);
                comboBoxFood.SelectedItem = newFood;

                SaveFoodDatabaseToJson();

                textBoxNewFoodName.Clear();
                textBoxNewFoodCalories.Clear();

                MessageBox.Show("Продукт додано до бази даних", "",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість калорій!", "Помилка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNewFoodName.Text) &&
                   double.TryParse(textBoxNewFoodCalories.Text, out double calories))
            {
                if (foodDatabase.Any(f => f.Name.Equals(textBoxNewFoodName.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Цей продукт вже є в базі даних!", "",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FoodItem newFood = new FoodItem(textBoxNewFoodName.Text, calories);

                foodDatabase.Add(newFood);
                comboBoxFood.Items.Add(newFood);
                comboBoxFood.SelectedItem = newFood;

                SaveFoodDatabaseToJson();

                textBoxNewFoodName.Clear();
                textBoxNewFoodCalories.Clear();

                MessageBox.Show("Продукт додано до бази даних!", "",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні дані про продукт!", "Помилка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}