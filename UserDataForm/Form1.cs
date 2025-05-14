using CalorieCalculatorForm;
using Calculator;
namespace UserDataForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public string Gender { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxWeight.Text, out double weight) &&
          double.TryParse(textBoxHeight.Text, out double height) &&
          (radioButtonMale.Checked || radioButtonFemale.Checked))
            {
                Weight = weight;
                Height = height;
                Gender = radioButtonMale.Checked ? "Чоловік" : "Жінка";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            CalorieCalc calorieCalculator = new CalorieCalc(Weight, Height, Gender);
            calorieCalculator.Show();
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
 