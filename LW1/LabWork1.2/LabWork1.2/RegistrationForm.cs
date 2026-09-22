using System.Text.Json;

namespace LabWork1._2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            using (FileStream fs = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                User? user = JsonSerializer.Deserialize<User>(fs);
                if (user.Login != RegistrationLoginTextBox.Text && user.Password != RegistrationPasswordTextBox.Text && RegistrationLoginTextBox.Text.Length != 0 && RegistrationPasswordTextBox.Text.Length != 0)
                {
                    user = new User(RegistrationLoginTextBox.Text, RegistrationPasswordTextBox.Text);
                    JsonSerializer.Serialize<User>(fs, user);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("", "Ошибка");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }
    }
}
