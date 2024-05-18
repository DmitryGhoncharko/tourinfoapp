using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public class Database
    {
        private readonly MySqlConnection connection;

        public Database(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}