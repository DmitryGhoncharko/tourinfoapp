using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly Database database;

        public Form1()
        {
            InitializeComponent();
            var connectionString = "server=212.113.123.162;database=turinfouser;user=turinfo;password=turinfouser;";
            database = new Database(connectionString);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(database);
            loginForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(database);
            registerForm.Show();
        }
    }
}