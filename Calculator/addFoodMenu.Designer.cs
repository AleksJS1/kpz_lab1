namespace addFoodMenu
{
    partial class addFood
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
            textBoxNewFoodName = new TextBox();
            textBoxNewFoodCalories = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxNewFoodName
            // 
            textBoxNewFoodName.Location = new Point(29, 60);
            textBoxNewFoodName.Name = "textBoxNewFoodName";
            textBoxNewFoodName.Size = new Size(179, 27);
            textBoxNewFoodName.TabIndex = 0;
            // 
            // textBoxNewFoodCalories
            // 
            textBoxNewFoodCalories.Location = new Point(250, 60);
            textBoxNewFoodCalories.Name = "textBoxNewFoodCalories";
            textBoxNewFoodCalories.Size = new Size(102, 27);
            textBoxNewFoodCalories.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Arial", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(29, 109);
            button1.Name = "button1";
            button1.Size = new Size(131, 41);
            button1.TabIndex = 2;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 3;
            label1.Text = "Продукт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(250, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 4;
            label2.Text = "Калорії";
            // 
            // addFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(393, 195);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxNewFoodCalories);
            Controls.Add(textBoxNewFoodName);
            Name = "addFood";
            Text = "Додати продукт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewFoodName;
        private TextBox textBoxNewFoodCalories;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
