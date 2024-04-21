using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance;
        
        private string _connectionString = "Data Source=calorie_calculator.db;Version=3;";

        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

        public void LogIn(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string actualPassword = UserData.Instance.CalculatePasswordSHA(password);

                string query = "SELECT id, COUNT(*) as count FROM Person WHERE username = @username AND password = @password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", actualPassword);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && Convert.ToInt32(reader["count"]) > 0)
                        {
                            UserData.Instance.Id = Convert.ToInt32(reader["id"]);
                            FormManager.Instance.HideLogInForm();
                            FormManager.Instance.ShowMainForm();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
            }
        }

        public void Register(string firstName, string lastName, int age, string gender, int height, double weight, string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string insertPersonDataQuery = "INSERT INTO PersonData (first_name, last_name, age, gender, height) VALUES (@firstName, @lastName, @age, @gender, @height)";
                using (SQLiteCommand command = new SQLiteCommand(insertPersonDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender[0].ToString());
                    command.Parameters.AddWithValue("@height", height);
                    command.ExecuteNonQuery();
                }

                string insertWeightQuery = "INSERT INTO Weight (date, weight) VALUES (@date, @weight)";
                using (SQLiteCommand command = new SQLiteCommand(insertWeightQuery, connection))
                {
                    command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@weight", weight);
                    command.ExecuteNonQuery();
                }

                string insertPersonQuery = "INSERT INTO Person (username, password) VALUES (@username, @password)";
                using (SQLiteCommand command = new SQLiteCommand(insertPersonQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", UserData.Instance.CalculatePasswordSHA(password));
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsUsernameTaken(string username)
        {
            bool isTaken = false;
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Person WHERE username = @username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        isTaken = true;
                    }
                }
            }
            return isTaken;
        }

        public void UpdateProfileField(string field, object value)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                if (field == "weight")
                {
                    string query = "INSERT INTO Weight (id, date, weight) VALUES (@personId, @date, @weight)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personId", UserData.Instance.Id);
                        command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@weight", value);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Weight entry inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to insert weight entry.");
                        }
                    }
                }
                else
                {
                    string updateQuery = $"UPDATE PersonData SET {field} = @value WHERE id = @userId";

                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@value", value);
                        command.Parameters.AddWithValue("@userId", UserData.Instance.Id);

                        command.ExecuteNonQuery();
                    }
                }
                FormManager.Instance.HideUpdateProfileForm();
                FormManager.Instance.ShowMainForm();
            }
        }
        
        public void UpdatePassowrd(SQLiteConnection connection, string password)
        {
            string query = "UPDATE Person SET password = @newPassword WHERE id = @id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@newPassword", password);
                command.Parameters.AddWithValue("@id", UserData.Instance.Id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Password updated successfully.");
                    FormManager.Instance.HideUpdateProfileForm();
                    FormManager.Instance.ShowMainForm();
                }
                else
                {
                    Console.WriteLine("No rows were affected. The provided ID may not exist.");
                }
            }
        }
        
        public void CheckPassword(string insertedCurrentPassword, string insertedNewPassword)
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT password FROM Person WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", UserData.Instance.Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if ((reader.Read()) && (insertedCurrentPassword != ""))
                        {
                            string currentPassword = reader["password"].ToString();
                            if (currentPassword != UserData.Instance.CalculatePasswordSHA(insertedCurrentPassword))
                            {
                                MessageBox.Show("Incorrect current password!");
                            }
                            else
                            {
                                string hashedPassword = UserData.Instance.CalculatePasswordSHA(insertedNewPassword);
                                UpdatePassowrd(connection, hashedPassword);
                                MessageBox.Show("Password updated Succesfully!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect current password!");
                        }
                    }
                }
            }
        }
    }
}
