namespace UserDataForm
{
    partial class Form1
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSend = new Button();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            textBoxWeight = new TextBox();
            textBoxHeight = new TextBox();
            label2 = new Label();
            CloseButton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(301, 23);
            label1.TabIndex = 0;
            label1.Text = "Вітаємо в калькуляторі калорій ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(49, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 2;
            label3.Text = "Вага (кг)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(49, 263);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 3;
            label4.Text = "Зріст (см)";
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.DarkOliveGreen;
            buttonSend.Font = new Font("Arial", 12F);
            buttonSend.ForeColor = SystemColors.ButtonHighlight;
            buttonSend.Location = new Point(266, 273);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(150, 53);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Відправити ";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click_1;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Arial", 12F);
            radioButtonMale.Location = new Point(49, 103);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(101, 27);
            radioButtonMale.TabIndex = 5;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Чоловік";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Arial", 12F);
            radioButtonFemale.Location = new Point(49, 142);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(83, 27);
            radioButtonFemale.TabIndex = 6;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Жінка";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(49, 210);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(125, 27);
            textBoxWeight.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(49, 286);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 27);
            textBoxHeight.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(49, 58);
            label2.Name = "label2";
            label2.Size = new Size(441, 23);
            label2.TabIndex = 1;
            label2.Text = "Введіть свої параметри для подальшої роботи";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial", 12F);
            CloseButton.Location = new Point(510, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(23, 23);
            CloseButton.TabIndex = 9;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(545, 411);
            Controls.Add(CloseButton);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWeight);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(buttonSend);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Калькулятор калорій ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSend;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private TextBox textBoxWeight;
        private TextBox textBoxHeight;
        private Label CloseButton;
    }
}
