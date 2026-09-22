using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace LabWork1._2
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            using (FileStream fs = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                User? user = JsonSerializer.Deserialize<User>(fs);
                if(user.Login == AuthorizationLoginTextBox.Text && user.Password == AuthorizationPasswordTextBox.Text)
                {
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("", "Ошибка");
                }
            }
        }
    }
}
