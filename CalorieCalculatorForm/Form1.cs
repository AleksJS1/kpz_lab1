using ClassLibrary; 
namespace CalorieCalculatorForm
{
    public class CalorieCalculator : Form
    {
        private Label labelCalorieNorm;

       

       

        private void InitializeComponent()
        {
            calorieNorm = new Label();
            SuspendLayout();
            // 
            // calorieNorm
            // 
            calorieNorm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calorieNorm.AutoSize = true;
            calorieNorm.Font = new Font("Arial", 12F);
            calorieNorm.Location = new Point(12, 52);
            calorieNorm.Name = "calorieNorm";
            calorieNorm.Size = new Size(489, 23);
            calorieNorm.TabIndex = 0;
            calorieNorm.Text = "Ваша денна норма калорій, щоб підтримувати вагу: ";
            // 
            // CalorieCalculator
            // 
            ClientSize = new Size(550, 135);
            Controls.Add(calorieNorm);
            MaximumSize = new Size(568, 182);
            MinimumSize = new Size(568, 182);
            Name = "CalorieCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label calorieNorm;
    }
}

