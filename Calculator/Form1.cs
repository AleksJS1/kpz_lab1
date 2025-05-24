using System;
using System.Text.Json;
using System.IO;
using ClassLibrary;
using addFoodMenu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calculator
{
    public partial class CalorieCalc : Form
    {
        private FoodDatabaseManager foodDatabaseManager;
        private Meal currentMeal;
        private double dailyCalorieNorm;

        public CalorieCalc()
        {
            InitializeComponent();
            foodDatabaseManager = new FoodDatabaseManager();
            currentMeal = new Meal();
            InitializeFoodComboBox();

        }

        public void InitializeFoodComboBox()
        {
            FoodСomboBox.Items.Clear();
            foreach (var food in foodDatabaseManager.FoodDatabase)
            {
                FoodСomboBox.Items.Add(food);
            }

            if (FoodСomboBox.Items.Count > 0)
                FoodСomboBox.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (FoodСomboBox.SelectedItem is FoodItem selectedFood &&
                double.TryParse(textBoxWeight.Text, out double weight) && weight > 0)
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



        public CalorieCalc(double weight, double height, string gender, int age, double activityLevel, double dailyCalories, FoodDatabaseManager foodManager)
        {
            InitializeComponent();
            foodDatabaseManager = foodManager;
            currentMeal = new Meal();
            this.dailyCalorieNorm = dailyCalories;
            calorieNorm.Text = $"Денна норма: {dailyCalorieNorm:F0} ккал";
            InitializeFoodComboBox();
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

        private void linkToAddProduct_Click(object sender, EventArgs e)
        {
            addFood addFoodItem = new addFood(this);
            addFoodItem.Show();
        }

        private void linkToAddProduct_MouseEnter(object sender, EventArgs e)
        {
            linkToAddProduct.ForeColor = Color.White;
        }

        private void linkToAddProduct_MouseLeave(object sender, EventArgs e)
        {
            linkToAddProduct.ForeColor = Color.Black;
        }
    }
}