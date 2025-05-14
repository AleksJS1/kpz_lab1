using System;
using ClassLibrary;
namespace Calculator
{
    public partial class CalorieCalc : Form
    {
        private List<FoodItem> foodDatabase;
        private Meal currentMeal;
        public CalorieCalc()
        {
            InitializeComponent();
            InitializeFoodDatabase();
            currentMeal = new Meal();
        }
        private void InitializeFoodDatabase()
        {
            foodDatabase = new List<FoodItem>
    {
        new FoodItem("Яблуко", 52),
        new FoodItem("Банан", 96),
        new FoodItem("Куряче філе", 165),
        new FoodItem("Рис", 130),
        new FoodItem("Молоко", 42),
    };
            foreach (var food in foodDatabase)
            {
                comboBoxFood.Items.Add(food);
            }

            if (comboBoxFood.Items.Count > 0)
            {
                comboBoxFood.SelectedIndex = 0;
            }
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
                MessageBox.Show("Будь ласка, введіть коректну вагу продукту!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public CalorieCalc(double weight, double height, string gender)
        {
            InitializeComponent();
            InitializeFoodDatabase();
            currentMeal = new Meal();
            calorieNorm.Text = $"Ваша добова норма: {CalculateDailyCalories(weight, height, gender):F2} ккал";
        }
        private double CalculateDailyCalories(double weight, double height, string gender)
        {
            return (gender == "Чоловік")
                ? 10 * weight + 6.25 * height - 5 * 25 + 5
                : 10 * weight + 6.25 * height - 5 * 25 - 161;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }
    }
}
