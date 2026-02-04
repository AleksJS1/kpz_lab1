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
        private FoodDatabaseManagerSingleton foodDatabaseManager;
        private Meal currentMeal;
        private double dailyCalorieNorm;

        public CalorieCalc()
        {
            InitializeComponent();
            foodDatabaseManager = FoodDatabaseManagerSingleton.Instance;
            currentMeal = new Meal();
            InitializeFoodComboBox();

        }

        public void InitializeFoodComboBox()
        {
            Food�omboBox.Items.Clear();
            foreach (var food in foodDatabaseManager.FoodDatabase)
            {
                Food�omboBox.Items.Add(food);
            }

            if (Food�omboBox.Items.Count > 0)
                Food�omboBox.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Food�omboBox.SelectedItem is FoodItem selectedFood &&
                double.TryParse(textBoxWeight.Text, out double weight) && weight > 0)
            {
                currentMeal.AddFoodItem(selectedFood, weight);
                listBoxItems.Items.Add($"{selectedFood.Name} - {weight}�");
                labelTotalCalories.Text = $"�������� ������� ������: {currentMeal.CalculateTotalCalories():F2} ����";
                textBoxWeight.Clear();
            }
            else
            {
                MessageBox.Show("���� �����, ������ �������� ���� ��������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public CalorieCalc(double weight, double height, Gender gender, int age, double activityLevel, double dailyCalories)
        {
            InitializeComponent();
            foodDatabaseManager = FoodDatabaseManagerSingleton.Instance;
            currentMeal = new Meal();
            this.dailyCalorieNorm = dailyCalories;
            calorieNorm.Text = $"Норма днів: {dailyCalorieNorm:F0} ккал";
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