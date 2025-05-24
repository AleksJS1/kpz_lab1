using ClassLibrary;
using Calculator;
namespace addFoodMenu
{
    public partial class addFood : Form
    {
        private FoodDatabaseManager foodDatabaseManager;
        private CalorieCalc calorieCalc;

        public addFood(CalorieCalc calorieCalc)
        {
            InitializeComponent();
            foodDatabaseManager = new FoodDatabaseManager();
            this.calorieCalc = calorieCalc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxNewFoodName.Text.Trim();
                if (double.TryParse(textBoxNewFoodCalories.Text, out double calories))
                {
                    foodDatabaseManager.AddFoodItem(new FoodItem(name, calories));
                    calorieCalc.InitializeFoodComboBox();
                    textBoxNewFoodName.Clear();
                    
                    textBoxNewFoodCalories.Clear();
                    MessageBox.Show("Продукт додано до бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть коректні дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
