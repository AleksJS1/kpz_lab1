using ClassLibrary;
using Calculator;
namespace UserDataForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public Gender Gender { get; private set; }
        public int Age { get; private set; }
        public double ActivityLevel { get; private set; }
        public double dailyCalories { get; private set; }
        public Form1()
        {
            InitializeComponent();
            InitializeActivityLevels();
        }


        private void InitializeActivityLevels()
        {
            cmbActivityLevel.Items.Add(new ActivityLevel("������� ����� �����", 1.2));
            cmbActivityLevel.Items.Add(new ActivityLevel("����� ���������� (1-3 ����������/�������)", 1.375));
            cmbActivityLevel.Items.Add(new ActivityLevel("������ ���������� (3-5 ���������/�������)", 1.55));
            cmbActivityLevel.Items.Add(new ActivityLevel("������ ���������� (6-7 ���������/�������)", 1.725));
            cmbActivityLevel.Items.Add(new ActivityLevel("���� ������ ���������� (����� ������� ������)", 1.9));
            cmbActivityLevel.SelectedIndex = 0;
        }


        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                Gender gender = radioButtonMale.Checked ? Gender.Male : Gender.Female;
                double weight = double.Parse(textBoxWeight.Text);
                double height = double.Parse(textBoxHeight.Text);
                int age = int.Parse(txtAge.Text);
                double activityLevel = ((ActivityLevel)cmbActivityLevel.SelectedItem).Value;

                double dailyCalories = CalculateDailyCalories(gender, weight, height, age, activityLevel);
                this.Hide();
                CalorieCalc calorieCalculator = new CalorieCalc(weight, height, gender, age, activityLevel, dailyCalories);
                calorieCalculator.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public double CalculateDailyCalories(Gender gender, double weight, double height, int age, double activityLevel)
        {
            double bmr;

            if (gender == Gender.Male)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else if (gender == Gender.Female)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
            }
            else
            {
                throw new ArgumentException("Invalid gender");
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
 