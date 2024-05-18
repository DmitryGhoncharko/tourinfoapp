using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        private readonly Database database;

        public RegisterForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            database.OpenConnection();
            var query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, 'client')";
            var cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}