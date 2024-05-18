using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class ClientForm : Form
    {
        private readonly Database database;
        private readonly int userId;

        public ClientForm(int userId, Database db)
        {
            InitializeComponent();
            this.userId = userId;
            database = db;
            LoadTours();
            LoadFavorites();
        }

        private void LoadTours()
        {
            toursListBox.Items.Clear();
            database.OpenConnection();
            var query = "SELECT * FROM Tours";
            var cmd = new MySqlCommand(query, database.GetConnection());
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var tourInfo =
                    $"{reader.GetInt32("TourId")}: {reader.GetString("Title")} - {reader.GetDecimal("Price")} рублей\nПогода: {reader.GetString("Weather")}\nТранспорт: {reader.GetString("Transport")}\nМероприятия: {reader.GetString("Events")}";
                toursListBox.Items.Add(tourInfo);
            }

            reader.Close();
            database.CloseConnection();
        }

        private void LoadFavorites()
        {
            favoritesListBox.Items.Clear();
            database.OpenConnection();
            var query =
                "SELECT Tours.* FROM Favorites JOIN Tours ON Favorites.TourId = Tours.TourId WHERE Favorites.UserId = @userId";
            var cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@userId", userId);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var favoriteInfo =
                    $"{reader.GetInt32("TourId")}: {reader.GetString("Title")} - {reader.GetDecimal("Price")} рублей\nПогода: {reader.GetString("Weather")}\nТранспорт: {reader.GetString("Transport")}\nМероприятия: {reader.GetString("Events")}";
                favoritesListBox.Items.Add(favoriteInfo);
            }

            reader.Close();
            database.CloseConnection();
        }

        private void addFavoriteButton_Click(object sender, EventArgs e)
        {
            if (toursListBox.SelectedItem != null)
            {
                var selectedTour = toursListBox.SelectedItem.ToString();
                var tourId = int.Parse(selectedTour.Split(':')[0]);

                database.OpenConnection();

                var checkQuery = "SELECT COUNT(*) FROM Favorites WHERE UserId = @userId AND TourId = @tourId";
                var checkCmd = new MySqlCommand(checkQuery, database.GetConnection());
                checkCmd.Parameters.AddWithValue("@userId", userId);
                checkCmd.Parameters.AddWithValue("@tourId", tourId);

                var count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Тур уже добавлен в избранное");
                    database.CloseConnection();
                    return;
                }

                var query = "INSERT INTO Favorites (UserId, TourId) VALUES (@userId, @tourId)";
                var cmd = new MySqlCommand(query, database.GetConnection());
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
                var selectedFavorite = favoritesListBox.SelectedItem.ToString();
                var tourId = int.Parse(selectedFavorite.Split(':')[0]);

                database.OpenConnection();
                var query = "DELETE FROM Favorites WHERE UserId = @userId AND TourId = @tourId";
                var cmd = new MySqlCommand(query, database.GetConnection());
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
