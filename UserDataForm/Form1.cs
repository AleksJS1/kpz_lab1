using ClassLibrary;
using Calculator;
namespace UserDataForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set; }
        public double ActivityLevel { get; private set; }
        public double dailyCalories { get; private set; }
        public FoodDatabaseManager foodManager { get; private set; }
        public Form1()
        {
            InitializeComponent();
            InitializeActivityLevels();
        }


        private void InitializeActivityLevels()
        {
            cmbActivityLevel.Items.Add(new ActivityLevel("Сидячий спосіб життя", 1.2));
            cmbActivityLevel.Items.Add(new ActivityLevel("Легка активність (1-3 тренування/тиждень)", 1.375));
            cmbActivityLevel.Items.Add(new ActivityLevel("Помірна активність (3-5 тренувань/тиждень)", 1.55));
            cmbActivityLevel.Items.Add(new ActivityLevel("Висока активність (6-7 тренувань/тиждень)", 1.725));
            cmbActivityLevel.Items.Add(new ActivityLevel("Дуже висока активність (важка фізична робота)", 1.9));
            cmbActivityLevel.SelectedIndex = 0;
        }


        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                string gender = radioButtonMale.Checked ? "Чоловік" : "Жінка";
                double weight = double.Parse(textBoxWeight.Text);
                double height = double.Parse(textBoxHeight.Text);
                int age = int.Parse(txtAge.Text);
                double activityLevel = ((ActivityLevel)cmbActivityLevel.SelectedItem).Value;

                double dailyCalories = CalculateDailyCalories(gender, weight, height, age, activityLevel);
                this.Hide();
                FoodDatabaseManager foodManager = new FoodDatabaseManager();
                CalorieCalc calorieCalculator = new CalorieCalc(Weight, Height, Gender, Age, ActivityLevel, dailyCalories, foodManager);
                calorieCalculator.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public double CalculateDailyCalories(string gender, double weight, double height, int age, double activityLevel)
        {
            double bmr;

            if (gender == "Чоловік")
            {
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else if (gender == "Жінка")
            {
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
            }
            else
            {
                throw new ArgumentException("Невірно вказана стать");
            }

            return bmr * activityLevel;
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
 