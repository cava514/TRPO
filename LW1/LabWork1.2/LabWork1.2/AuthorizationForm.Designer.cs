namespace LabWork1._2
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AuthorizationButton = new Button();
            AuthorizationLoginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AuthorizationPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // AuthorizationButton
            // 
            AuthorizationButton.Location = new Point(12, 100);
            AuthorizationButton.Name = "AuthorizationButton";
            AuthorizationButton.Size = new Size(113, 23);
            AuthorizationButton.TabIndex = 0;
            AuthorizationButton.Text = "Авторизоваться";
            AuthorizationButton.UseVisualStyleBackColor = true;
            AuthorizationButton.Click += AuthorizationButton_Click;
            // 
            // AuthorizationLoginTextBox
            // 
            AuthorizationLoginTextBox.Location = new Point(12, 27);
            AuthorizationLoginTextBox.Name = "AuthorizationLoginTextBox";
            AuthorizationLoginTextBox.Size = new Size(100, 23);
            AuthorizationLoginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // AuthorizationPasswordTextBox
            // 
            AuthorizationPasswordTextBox.Location = new Point(12, 71);
            AuthorizationPasswordTextBox.Name = "AuthorizationPasswordTextBox";
            AuthorizationPasswordTextBox.Size = new Size(100, 23);
            AuthorizationPasswordTextBox.TabIndex = 4;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AuthorizationPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AuthorizationLoginTextBox);
            Controls.Add(AuthorizationButton);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AuthorizationButton;
        private TextBox AuthorizationLoginTextBox;
        private Label label1;
        private Label label2;
        private TextBox AuthorizationPasswordTextBox;
    }
}