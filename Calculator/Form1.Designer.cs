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
            buttonSolve = new Button();
            label = new Label();
            labelTotalCalories = new Label();
            textBoxWeight = new TextBox();
            listBoxItems = new ListBox();
            calorieNorm = new Label();
            label1 = new Label();
            CloseButton = new Label();
            buttonAddFood = new Button();
            textBoxNewFoodName = new TextBox();
            textBoxNewFoodCalories = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxFood
            // 
            comboBoxFood.FormattingEnabled = true;
            comboBoxFood.Location = new Point(26, 59);
            comboBoxFood.Margin = new Padding(3, 2, 3, 2);
            comboBoxFood.Name = "comboBoxFood";
            comboBoxFood.Size = new Size(133, 23);
            comboBoxFood.TabIndex = 0;
            // 
            // buttonSolve
            // 
            buttonSolve.BackColor = Color.DarkOliveGreen;
            buttonSolve.Font = new Font("Arial", 12F);
            buttonSolve.ForeColor = SystemColors.ButtonFace;
            buttonSolve.Location = new Point(297, 212);
            buttonSolve.Margin = new Padding(3, 2, 3, 2);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(171, 40);
            buttonSolve.TabIndex = 1;
            buttonSolve.Text = "Розрахувати";
            buttonSolve.UseVisualStyleBackColor = false;
            buttonSolve.Click += buttonAdd_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial", 12F);
            label.Location = new Point(26, 40);
            label.Name = "label";
            label.Size = new Size(138, 18);
            label.TabIndex = 2;
            label.Text = "Виберіть продукт ";
            // 
            // labelTotalCalories
            // 
            labelTotalCalories.AutoSize = true;
            labelTotalCalories.Font = new Font("Arial", 12F);
            labelTotalCalories.Location = new Point(297, 132);
            labelTotalCalories.Name = "labelTotalCalories";
            labelTotalCalories.Size = new Size(201, 18);
            labelTotalCalories.TabIndex = 3;
            labelTotalCalories.Text = "Загальна кількість калорій";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Arial", 10F);
            textBoxWeight.Location = new Point(26, 116);
            textBoxWeight.Margin = new Padding(3, 2, 3, 2);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(153, 23);
            textBoxWeight.TabIndex = 4;
            // 
            // listBoxItems
            // 
            listBoxItems.Font = new Font("Arial", 10F);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(297, 40);
            listBoxItems.Margin = new Padding(3, 2, 3, 2);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(132, 68);
            listBoxItems.TabIndex = 5;
            // 
            // calorieNorm
            // 
            calorieNorm.AutoSize = true;
            calorieNorm.Font = new Font("Arial", 12F);
            calorieNorm.Location = new Point(297, 169);
            calorieNorm.Name = "calorieNorm";
            calorieNorm.Size = new Size(160, 18);
            calorieNorm.TabIndex = 6;
            calorieNorm.Text = "Ваша добова норма:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(26, 97);
            label1.Name = "label1";
            label1.Size = new Size(137, 18);
            label1.TabIndex = 7;
            label1.Text = "Кількість (грамм.)";
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial", 12F);
            CloseButton.Location = new Point(525, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(19, 18);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // buttonAddFood
            // 
            buttonAddFood.BackColor = Color.DarkOliveGreen;
            buttonAddFood.Font = new Font("Arial", 12F);
            buttonAddFood.ForeColor = SystemColors.ButtonFace;
            buttonAddFood.Location = new Point(26, 212);
            buttonAddFood.Margin = new Padding(3, 2, 3, 2);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(140, 40);
            buttonAddFood.TabIndex = 9;
            buttonAddFood.Text = "Додати";
            buttonAddFood.UseVisualStyleBackColor = false;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // textBoxNewFoodName
            // 
            textBoxNewFoodName.Location = new Point(25, 169);
            textBoxNewFoodName.Name = "textBoxNewFoodName";
            textBoxNewFoodName.Size = new Size(100, 23);
            textBoxNewFoodName.TabIndex = 10;
            // 
            // textBoxNewFoodCalories
            // 
            textBoxNewFoodCalories.Location = new Point(143, 169);
            textBoxNewFoodCalories.Name = "textBoxNewFoodCalories";
            textBoxNewFoodCalories.Size = new Size(65, 23);
            textBoxNewFoodCalories.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(25, 148);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 12;
            label2.Text = "Продукт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(145, 148);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 13;
            label3.Text = "КК/100г";
            // 
            // CalorieCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(556, 300);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNewFoodCalories);
            Controls.Add(textBoxNewFoodName);
            Controls.Add(buttonAddFood);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Controls.Add(calorieNorm);
            Controls.Add(listBoxItems);
            Controls.Add(textBoxWeight);
            Controls.Add(labelTotalCalories);
            Controls.Add(label);
            Controls.Add(buttonSolve);
            Controls.Add(comboBoxFood);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CalorieCalc";
            Text = "Калькулятор калорій ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFood;
        private Button buttonSolve;
        private Label label;
        private Label labelTotalCalories;
        private TextBox textBoxWeight;
        private ListBox listBoxItems;
        private Label calorieNorm;
        private Label label1;
        private Label CloseButton;
        private Button buttonAddFood;
        private TextBox textBoxNewFoodName;
        private TextBox textBoxNewFoodCalories;
        private Label label2;
        private Label label3;
    }
}
