namespace Calculator
{
    partial class CalorieCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFood = new ComboBox();
            buttonAdd = new Button();
            label = new Label();
            labelTotalCalories = new Label();
            textBoxWeight = new TextBox();
            listBoxItems = new ListBox();
            calorieNorm = new Label();
            label1 = new Label();
            CloseButton = new Label();
            SuspendLayout();
            // 
            // comboBoxFood
            // 
            comboBoxFood.FormattingEnabled = true;
            comboBoxFood.Location = new Point(30, 79);
            comboBoxFood.Name = "comboBoxFood";
            comboBoxFood.Size = new Size(151, 28);
            comboBoxFood.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkOliveGreen;
            buttonAdd.Font = new Font("Arial", 12F);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(30, 216);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(195, 54);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Розрахувати";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial", 12F);
            label.Location = new Point(30, 53);
            label.Name = "label";
            label.Size = new Size(174, 23);
            label.TabIndex = 2;
            label.Text = "Виберіть продукт ";
            // 
            // labelTotalCalories
            // 
            labelTotalCalories.AutoSize = true;
            labelTotalCalories.Font = new Font("Arial", 12F);
            labelTotalCalories.Location = new Point(324, 189);
            labelTotalCalories.Name = "labelTotalCalories";
            labelTotalCalories.Size = new Size(251, 23);
            labelTotalCalories.TabIndex = 3;
            labelTotalCalories.Text = "Загальна кількість калорій";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Arial", 10F);
            textBoxWeight.Location = new Point(30, 155);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(174, 27);
            textBoxWeight.TabIndex = 4;
            // 
            // listBoxItems
            // 
            listBoxItems.Font = new Font("Arial", 10F);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 19;
            listBoxItems.Location = new Point(324, 36);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(150, 99);
            listBoxItems.TabIndex = 5;
            // 
            // calorieNorm
            // 
            calorieNorm.AutoSize = true;
            calorieNorm.Font = new Font("Arial", 12F);
            calorieNorm.Location = new Point(324, 268);
            calorieNorm.Name = "calorieNorm";
            calorieNorm.Size = new Size(202, 23);
            calorieNorm.TabIndex = 6;
            calorieNorm.Text = "Ваша добова норма:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(30, 129);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 7;
            label1.Text = "Кількість (грамм.)";
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial", 12F);
            CloseButton.Location = new Point(690, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(23, 23);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // CalorieCalc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(725, 400);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Controls.Add(calorieNorm);
            Controls.Add(listBoxItems);
            Controls.Add(textBoxWeight);
            Controls.Add(labelTotalCalories);
            Controls.Add(label);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxFood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalorieCalc";
            Text = "Калькулятор калорій ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFood;
        private Button buttonAdd;
        private Label label;
        private Label labelTotalCalories;
        private TextBox textBoxWeight;
        private ListBox listBoxItems;
        private Label calorieNorm;
        private Label label1;
        private Label CloseButton;
    }
}
