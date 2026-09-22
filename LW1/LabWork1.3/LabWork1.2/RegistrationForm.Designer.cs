namespace LabWork1._2
{
    partial class RegistrationForm
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
            RegistrationLoginTextBox = new TextBox();
            label2 = new Label();
            RegistrationPasswordTextBox = new TextBox();
            RegistrationButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // RegistrationLoginTextBox
            // 
            RegistrationLoginTextBox.Location = new Point(12, 27);
            RegistrationLoginTextBox.Name = "RegistrationLoginTextBox";
            RegistrationLoginTextBox.Size = new Size(100, 23);
            RegistrationLoginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // RegistrationPasswordTextBox
            // 
            RegistrationPasswordTextBox.Location = new Point(12, 71);
            RegistrationPasswordTextBox.Name = "RegistrationPasswordTextBox";
            RegistrationPasswordTextBox.Size = new Size(100, 23);
            RegistrationPasswordTextBox.TabIndex = 3;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(12, 115);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(123, 23);
            RegistrationButton.TabIndex = 4;
            RegistrationButton.Text = "Регистрироваться";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Авторизованы";
            label3.Click += label3_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(RegistrationButton);
            Controls.Add(RegistrationPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(RegistrationLoginTextBox);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RegistrationLoginTextBox;
        private Label label2;
        private TextBox RegistrationPasswordTextBox;
        private Button RegistrationButton;
        private Label label3;
    }
}
