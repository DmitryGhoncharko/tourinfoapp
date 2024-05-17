using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class ClientForm : Form
    {
        private int userId;
        private Database database;

        public ClientForm(int userId, Database db)
        {
            InitializeComponent();
            this.userId = userId;
            this.database = db;
            LoadTours();
            LoadFavorites();
        }

        private void LoadTours()
        {
            toursListBox.Items.Clear();
            database.OpenConnection();
            string query = "SELECT * FROM Tours";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tourInfo = $"{reader.GetInt32("TourId")}: {reader.GetString("Title")} - {reader.GetDecimal("Price")} рублей";
                toursListBox.Items.Add(tourInfo);
            }

            reader.Close();
            database.CloseConnection();
        }

        private void LoadFavorites()
        {
            favoritesListBox.Items.Clear();
            database.OpenConnection();
            string query = "SELECT Tours.* FROM Favorites JOIN Tours ON Favorites.TourId = Tours.TourId WHERE Favorites.UserId = @userId";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string favoriteInfo = $"{reader.GetInt32("TourId")}: {reader.GetString("Title")} - {reader.GetDecimal("Price")} рублей";
                favoritesListBox.Items.Add(favoriteInfo);
            }

            reader.Close();
            database.CloseConnection();
        }

        private void addFavoriteButton_Click(object sender, EventArgs e)
        {
            if (toursListBox.SelectedItem != null)
            {
                string selectedTour = toursListBox.SelectedItem.ToString();
                int tourId = int.Parse(selectedTour.Split(':')[0]);

                database.OpenConnection();
                
              
                string checkQuery = "SELECT COUNT(*) FROM Favorites WHERE UserId = @userId AND TourId = @tourId";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, database.GetConnection());
                checkCmd.Parameters.AddWithValue("@userId", userId);
                checkCmd.Parameters.AddWithValue("@tourId", tourId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Тур уже добавлен в избранное");
                    database.CloseConnection();
                    return;
                }

                
                string query = "INSERT INTO Favorites (UserId, TourId) VALUES (@userId, @tourId)";
                MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@tourId", tourId);

                cmd.ExecuteNonQuery();
                database.CloseConnection();

                MessageBox.Show("Добавлено в избранное");
                LoadFavorites();
            }
        }

        private void removeFavoriteButton_Click(object sender, EventArgs e)
        {
            if (favoritesListBox.SelectedItem != null)
            {
                string selectedFavorite = favoritesListBox.SelectedItem.ToString();
                int tourId = int.Parse(selectedFavorite.Split(':')[0]);

                database.OpenConnection();
                string query = "DELETE FROM Favorites WHERE UserId = @userId AND TourId = @tourId";
                MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@tourId", tourId);

                cmd.ExecuteNonQuery();
                database.CloseConnection();

                MessageBox.Show("Удалено из избранного");
                LoadFavorites();
            }
        }
    }
}
