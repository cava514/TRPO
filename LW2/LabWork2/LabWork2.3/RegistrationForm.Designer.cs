namespace LabWork2._3
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
            loginTextBox = new TextBox();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            passwordDublicateTextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            registrationButton = new Button();
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
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 27);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(100, 23);
            loginTextBox.TabIndex = 1;
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
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 71);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Подтверждение";
            // 
            // passwordDublicateTextBox
            // 
            passwordDublicateTextBox.Location = new Point(12, 115);
            passwordDublicateTextBox.Name = "passwordDublicateTextBox";
            passwordDublicateTextBox.Size = new Size(100, 23);
            passwordDublicateTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 159);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 7;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(37, 188);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(75, 23);
            registrationButton.TabIndex = 8;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += this.registrationButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationButton);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(passwordDublicateTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label label3;
        private TextBox passwordDublicateTextBox;
        private Label label4;
        private TextBox emailTextBox;
        private Button registrationButton;
    }
}
