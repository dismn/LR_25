using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LR_25
{
    
    public partial class Form1 : Form
    {
        //підключення до БД в СУБД MySQL
        private static readonly string DB_CONNECTION_STRING = "server=127.0.0.1;port=3306;database=computergames;user=root;password=12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING))
                {
                    connection.Open();
                    LoadData(connection);
                    MessageBox.Show("До бази даних успішно підключено");
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING))
                {
                    connection.Open();
                    InsertData(connection);
                    LoadData(connection);
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                AppendText("Error: " + ex.Message);
            }
        }

        private void AppendText(string text)
        {
            richTextBox1.AppendText(text + Environment.NewLine);
        }

        private void InsertData(MySqlConnection connection)
        {
            string insertQuery = "INSERT INTO game (game_id, game_name, graduation_year, developer, genre, platform) VALUES (@game_id, @game_name, @graduation_year, @developer, @genre, @platform)";
            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@game_id", int.Parse(textBox1.Text));
                command.Parameters.AddWithValue("@game_name", gamenametextbox.Text);
                command.Parameters.AddWithValue("@graduation_year", int.Parse(graduationyeartextbox.Text));
                command.Parameters.AddWithValue("@developer", developertextbox.Text);
                command.Parameters.AddWithValue("@genre", genretextbox.Text);
                command.Parameters.AddWithValue("@platform", platformtextbox.Text);
                command.ExecuteNonQuery();
            }


            AppendText("Дані внесено до бази");
        }

        private void GenerateReports(MySqlConnection connection)
        {
            // отримання звіту за критерієм "жанр"
            string genreReportQuery = "SELECT genre, COUNT(*) AS count FROM game GROUP BY genre";
            using (MySqlCommand command = new MySqlCommand(genreReportQuery, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                AppendText("Звіт за жанрами:");
               
                while (reader.Read())
                {
                    string genre = reader.GetString("genre");
                    int count = reader.GetInt32("count");
                    AppendText($"{genre}: {count}");
                }
            }

            // отримання звіту за критерієм "Рік випуску"
            string yearReportQuery = "SELECT graduation_year, COUNT(*) AS count FROM game GROUP BY graduation_year";
            using (MySqlCommand command = new MySqlCommand(yearReportQuery, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                AppendText("\nЗвіт за роком випуску:");
                while (reader.Read())
                {
                    int year = reader.GetInt32("graduation_year");
                    int count = reader.GetInt32("count");
                    AppendText($"{year}: {count}");
                }
            }
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING))
                {
                    connection.Open();
                    GenerateReports(connection);
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                AppendText("Error: " + ex.Message);
            }
        }
        
        // метод для відображення БД
        private void LoadData(MySqlConnection connection)
        {
            string query = "SELECT * FROM game";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void graduationyeartextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // кнопка "пошук за критерієм"
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = searchtextbox.Text;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING))
                {
                    connection.Open();

                    string searchQuery = "SELECT * FROM game WHERE game_name = @searchValue";
                    using (MySqlCommand command = new MySqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchValue", searchValue);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                    }

                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // метод пошуку за назвою гри 
        private void SearchByValue(string searchValue)
        {
            string searchQuery = "SELECT * FROM game WHERE game_name = @searchValue OR genre = @searchValue OR graduation_year = @searchValue OR developer = @searchValue OR platform = @searchValue ";

            using (MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING))
            using (MySqlCommand command = new MySqlCommand(searchQuery, connection))
            {
                command.Parameters.AddWithValue("@searchValue", searchValue);

                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                { 
                    while (reader.Read())
                    {
                     
                        string gameName = reader.GetString("game_name");
                        string genre = reader.GetString("genre");
                        int graduationYear = reader.GetInt32("graduation_year");
                        string developer = reader.GetString("developer");
                        string platform = reader.GetString("platfoem");


                        
                        string result = string.Format("Назва гри: {0}, Жанр: {1}, Рік випуску: {2}, Розробник: {3}, Платформа: {4}", gameName, genre, graduationYear, developer, platform);
                        richTextBox1.AppendText(result + Environment.NewLine);
                    }
                }
            }
        }
    }
}
