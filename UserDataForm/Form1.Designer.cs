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
            cmbActivityLevel = new ComboBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(239, 18);
            label1.TabIndex = 0;
            label1.Text = "Вітаємо в калькуляторі калорій ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(43, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 2;
            label3.Text = "Вага (кг)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(216, 140);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 3;
            label4.Text = "Зріст (см)";
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.DarkOliveGreen;
            buttonSend.Font = new Font("Arial", 12F);
            buttonSend.ForeColor = SystemColors.ButtonHighlight;
            buttonSend.Location = new Point(133, 292);
            buttonSend.Margin = new Padding(3, 2, 3, 2);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(131, 40);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Відправити ";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click_1;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Arial", 12F);
            radioButtonMale.Location = new Point(43, 77);
            radioButtonMale.Margin = new Padding(3, 2, 3, 2);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(82, 22);
            radioButtonMale.TabIndex = 5;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Чоловік";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Arial", 12F);
            radioButtonFemale.Location = new Point(43, 106);
            radioButtonFemale.Margin = new Padding(3, 2, 3, 2);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(68, 22);
            radioButtonFemale.TabIndex = 6;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Жінка";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(43, 158);
            textBoxWeight.Margin = new Padding(3, 2, 3, 2);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(110, 23);
            textBoxWeight.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(216, 158);
            textBoxHeight.Margin = new Padding(3, 2, 3, 2);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(110, 23);
            textBoxHeight.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(345, 18);
            label2.TabIndex = 1;
            label2.Text = "Введіть свої параметри для подальшої роботи";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial", 12F);
            CloseButton.Location = new Point(414, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(19, 18);
            CloseButton.TabIndex = 9;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(203, 227);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(185, 23);
            cmbActivityLevel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.Location = new Point(203, 208);
            label5.Name = "label5";
            label5.Size = new Size(185, 16);
            label5.TabIndex = 11;
            label5.Text = "Виберіть рівень активності";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(43, 227);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(110, 23);
            txtAge.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.Location = new Point(43, 209);
            label6.Name = "label6";
            label6.Size = new Size(25, 16);
            label6.TabIndex = 13;
            label6.Text = "Вік";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(444, 375);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(cmbActivityLevel);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox cmbActivityLevel;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
    }
}
