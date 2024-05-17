using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Database database;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=212.113.123.162;database=turinfouser;user=turinfo;password=turinfouser;";
            database = new Database(connectionString);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(database);
            loginForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(database);
            registerForm.Show();
        }
    }
}