using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        private Database database;

        public LoginForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            database.OpenConnection();
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader.GetString("Role");
                int userId = reader.GetInt32("UserId");

                reader.Close();
                database.CloseConnection();

                if (role == "admin")
                {
                    AdminForm adminForm = new AdminForm(database);
                    adminForm.Show();
                }
                else
                {
                    ClientForm clientForm = new ClientForm(userId, database);
                    clientForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
                reader.Close();
                database.CloseConnection();
            }
        }

      
    }

}