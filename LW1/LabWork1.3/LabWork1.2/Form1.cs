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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<User?> users = new List<User?>();
            // чтение данных
            using (FileStream fs = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                User? user = JsonSerializer.Deserialize<User>(fs);
                users.Add(user);
            }
            UsersListView.Items.Clear();
            UsersListView.Items.AddRange();
        }
    }
}
