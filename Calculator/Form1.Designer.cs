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
            buttonSolve = new Button();
            label = new Label();
            labelTotalCalories = new Label();
            textBoxWeight = new TextBox();
            listBoxItems = new ListBox();
            calorieNorm = new Label();
            label1 = new Label();
            CloseButton = new Label();
            FoodСomboBox = new ComboBox();
            linkToAddProduct = new Label();
            SuspendLayout();
            // 
            // buttonSolve
            // 
            buttonSolve.BackColor = Color.DarkOliveGreen;
            buttonSolve.Font = new Font("Arial", 12F);
            buttonSolve.ForeColor = SystemColors.ButtonFace;
            buttonSolve.Location = new Point(293, 283);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(251, 64);
            buttonSolve.TabIndex = 1;
            buttonSolve.Text = "Розрахувати";
            buttonSolve.UseVisualStyleBackColor = false;
            buttonSolve.Click += buttonAdd_Click;
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
            labelTotalCalories.Location = new Point(293, 197);
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
            listBoxItems.Location = new Point(268, 34);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(371, 137);
            listBoxItems.TabIndex = 5;
            // 
            // calorieNorm
            // 
            calorieNorm.AutoSize = true;
            calorieNorm.Font = new Font("Arial", 12F);
            calorieNorm.Location = new Point(293, 241);
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
            CloseButton.Location = new Point(718, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(23, 23);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // FoodСomboBox
            // 
            FoodСomboBox.FormattingEnabled = true;
            FoodСomboBox.Location = new Point(30, 88);
            FoodСomboBox.Name = "FoodСomboBox";
            FoodСomboBox.Size = new Size(151, 28);
            FoodСomboBox.TabIndex = 13;
            // 
            // linkToAddProduct
            // 
            linkToAddProduct.AutoSize = true;
            linkToAddProduct.Cursor = Cursors.Hand;
            linkToAddProduct.Font = new Font("Arial", 12F);
            linkToAddProduct.Location = new Point(32, 270);
            linkToAddProduct.Name = "linkToAddProduct";
            linkToAddProduct.Size = new Size(196, 23);
            linkToAddProduct.TabIndex = 14;
            linkToAddProduct.Text = "Додати свій продукт";
            linkToAddProduct.Click += linkToAddProduct_Click;
            linkToAddProduct.MouseEnter += linkToAddProduct_MouseEnter;
            linkToAddProduct.MouseLeave += linkToAddProduct_MouseLeave;
            // 
            // CalorieCalc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(753, 453);
            Controls.Add(linkToAddProduct);
            Controls.Add(FoodСomboBox);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Controls.Add(calorieNorm);
            Controls.Add(listBoxItems);
            Controls.Add(textBoxWeight);
            Controls.Add(labelTotalCalories);
            Controls.Add(label);
            Controls.Add(buttonSolve);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalorieCalc";
            Text = "Калькулятор калорій ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSolve;
        private Label label;
        private Label labelTotalCalories;
        private TextBox textBoxWeight;
        private ListBox listBoxItems;
        private Label calorieNorm;
        private Label label1;
        private Label CloseButton;
        private ComboBox FoodСomboBox;
        private Label linkToAddProduct;
    }
}
