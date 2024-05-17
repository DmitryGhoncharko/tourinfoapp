using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        private Database database;

        public RegisterForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            database.OpenConnection();
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, 'client')";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
                this.Close();
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