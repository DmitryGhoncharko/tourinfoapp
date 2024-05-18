using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class AdminForm : Form
    {
        private readonly Database database;

        public AdminForm(Database db)
        {
            InitializeComponent();
            database = db;
            LoadTours();
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


        private void addTourButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string title = titleTextBox.Text;
                string description = descriptionTextBox.Text;
                decimal price = decimal.Parse(priceTextBox.Text);
                string weather = weatherTextBox.Text;
                string transport = transportTextBox.Text;
                string events = eventsTextBox.Text;

                database.OpenConnection();
                string query = "INSERT INTO Tours (Title, Description, Price, Weather, Transport, Events) VALUES (@title, @description, @price, @weather, @transport, @events)";
                MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@weather", weather);
                cmd.Parameters.AddWithValue("@transport", transport);
                cmd.Parameters.AddWithValue("@events", events);

                cmd.ExecuteNonQuery();
                database.CloseConnection();

                MessageBox.Show("Тур добавлен успешно");
                LoadTours();
            }
        }


        private void updateTourButton_Click(object sender, EventArgs e)
        {
            if (toursListBox.SelectedItem != null && ValidateInput())
            {
                string selectedTour = toursListBox.SelectedItem.ToString();
                int tourId = int.Parse(selectedTour.Split(':')[0]);
                string title = titleTextBox.Text;
                string description = descriptionTextBox.Text;
                decimal price = decimal.Parse(priceTextBox.Text);
                string weather = weatherTextBox.Text;
                string transport = transportTextBox.Text;
                string events = eventsTextBox.Text;

                database.OpenConnection();
                string query = "UPDATE Tours SET Title=@title, Description=@description, Price=@price, Weather=@weather, Transport=@transport, Events=@events WHERE TourId=@tourId";
                MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@weather", weather);
                cmd.Parameters.AddWithValue("@transport", transport);
                cmd.Parameters.AddWithValue("@events", events);
                cmd.Parameters.AddWithValue("@tourId", tourId);

                cmd.ExecuteNonQuery();
                database.CloseConnection();

                MessageBox.Show("Тур обновлен успешно");
                LoadTours();
            }
        }


        private void deleteTourButton_Click(object sender, EventArgs e)
        {
            if (toursListBox.SelectedItem != null)
            {
                var selectedTour = toursListBox.SelectedItem.ToString();
                var tourId = int.Parse(selectedTour.Split(':')[0]);

                database.OpenConnection();
                var query = "DELETE FROM Tours WHERE TourId = @tourId";
                var cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@tourId", tourId);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Тур удален");
                    LoadTours();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1451)
                        MessageBox.Show("Невозможно удалить тур, так как он добавлен в избранное у пользователей.");
                    else
                        MessageBox.Show($"Ошибка при удалении тура: {ex.Message}");
                }
                finally
                {
                    database.CloseConnection();
                }
            }
        }

        private void toursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toursListBox.SelectedItem != null)
            {
                string selectedTour = toursListBox.SelectedItem.ToString();
                int tourId = int.Parse(selectedTour.Split(':')[0]);

                database.OpenConnection();
                string query = "SELECT * FROM Tours WHERE TourId = @tourId";
                MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@tourId", tourId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    titleTextBox.Text = reader.GetString("Title");
                    descriptionTextBox.Text = reader.GetString("Description");
                    priceTextBox.Text = reader.GetDecimal("Price").ToString();
                    weatherTextBox.Text = reader.GetString("Weather");
                    transportTextBox.Text = reader.GetString("Transport");
                    eventsTextBox.Text = reader.GetString("Events");
                }

                reader.Close();
                database.CloseConnection();
            }
        }



        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text) || string.IsNullOrEmpty(weatherTextBox.Text) || string.IsNullOrEmpty(transportTextBox.Text) || string.IsNullOrEmpty(eventsTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return false;
            }

            if (!decimal.TryParse(priceTextBox.Text, out _))
            {
                MessageBox.Show("Пожалуйста, введите корректную цену.");
                return false;
            }

            return true;
        }

    }
}