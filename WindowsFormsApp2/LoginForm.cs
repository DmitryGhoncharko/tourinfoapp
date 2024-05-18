using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        private readonly Database database;

        public LoginForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            database.OpenConnection();
            var query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
            var cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var role = reader.GetString("Role");
                var userId = reader.GetInt32("UserId");

                reader.Close();
                database.CloseConnection();

                if (role == "admin")
                {
                    var adminForm = new AdminForm(database);
                    adminForm.Show();
                }
                else
                {
                    var clientForm = new ClientForm(userId, database);
                    clientForm.Show();
                }

                Hide();
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