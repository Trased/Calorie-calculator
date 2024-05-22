/**************************************************************************
 *                                                                        *
 *  File:        DatabaseManager.cs                                       *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Implement database operations for user                   *
 *               authentication and data management.                      *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DBMgr
{
    /// <summary>
    /// Singleton class for database operations
    /// </summary>
    public class DatabaseManager : IDatabaseManager
    {
        private static DatabaseManager _instance;
        private const string _connectionString = "Data Source=calorie_calculator.db;Version=3;";

        public event EventHandler<EventArgs> OnLoginSuccess;
        public event EventHandler<EventArgs> OnUpdateProfileSuccess;
        public event EventHandler<string> OnMessageBox;

        /// <summary>
        /// Private default class constructor required for Singleton
        /// </summary>
        private DatabaseManager() { }
        /// <summary>
        /// Singleton instance accessor.
        /// </summary>
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

        /// <summary>
        /// Sets user credentials from the database upon login.
        /// </summary>
        public void SetCredentials()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"SELECT pd.first_name || ' ' || pd.last_name as name, pd.age as age, pd.gender as gender, pd.height as height, w.weight as weight
                                 FROM PersonData pd, Weight w
                                 WHERE pd.id = @id AND pd.id = w.id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", UserData.Instance.Id);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserData.Instance.InitializeUserDataOnLogIn(
                                Convert.ToInt32(reader["age"]),
                                Convert.ToInt32(reader["height"]),
                                Convert.ToInt32(reader["weight"]),
                                Convert.ToString(reader["name"]),
                                Convert.ToString(reader["gender"])
                                );
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Authenticates user login credentials against the database.
        /// </summary>
        /// <param name="username">Username input.</param>
        /// <param name="password">Password input.</param>
        public void LogIn(string username, string password)
        {
            try
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
                                SetCredentials();
                                OnLoginSuccess?.Invoke(this, new EventArgs());
                            }
                            else
                            {
                                OnMessageBox?.Invoke(this, "Invalid username or password. Please try again.");
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Registers a new user and stores their information in the database.
        /// </summary>
        /// <param name="firstName">First name of the user.</param>
        /// <param name="lastName">Last name of the user.</param>
        /// <param name="age">Age of the user.</param>
        /// <param name="gender">Gender of the user.</param>
        /// <param name="height">Height of the user.</param>
        /// <param name="weight">Weight of the user.</param>
        /// <param name="username">Username chosen by the user.</param>
        /// <param name="password">Password chosen by the user.</param>
        public void Register(string firstName, string lastName, int age, string gender, int height, double weight, string username, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string insertPersonQuery = "INSERT INTO Person (username, password) VALUES (@username, @password)";
                    using (SQLiteCommand command = new SQLiteCommand(insertPersonQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", UserData.Instance.CalculatePasswordSHA(password));
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    int personID = 0;
                    string getPersonID = "SELECT id FROM Person WHERE username = @username";
                    using (SQLiteCommand command = new SQLiteCommand(getPersonID, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                personID = Convert.ToInt32(reader["id"]);
                            }
                        }
                    }

                    string insertPersonDataQuery = "INSERT INTO PersonData (id, first_name, last_name, age, gender, height) VALUES (@id, @firstName, @lastName, @age, @gender, @height)";
                    using (SQLiteCommand command = new SQLiteCommand(insertPersonDataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@gender", gender[0].ToString());
                        command.Parameters.AddWithValue("@height", height);
                        command.ExecuteNonQuery();
                    }

                    string insertWeightQuery = "INSERT INTO Weight (id, date, weight) VALUES (@id, @date, @weight)";
                    using (SQLiteCommand command = new SQLiteCommand(insertWeightQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);
                        command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@weight", weight);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Checks if a username is already taken in the database.
        /// </summary>
        /// <param name="username">Username to check.</param>
        /// <returns>True if the username is already taken, false otherwise.</returns>
        public bool IsUsernameTaken(string username)
        {
            bool isTaken = false;
            try
            {
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
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
            return isTaken;
        }

        /// <summary>
        /// Updates a specific field in the user's profile.
        /// </summary>
        /// <param name="field">Field to update.</param>
        /// <param name="value">New value for the field.</param>
        public void UpdateProfileField(string field, object value)
        {
            try
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
                    OnUpdateProfileSuccess?.Invoke(this, new EventArgs());
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Updates the user's password in the database.
        /// </summary>
        /// <param name="connection">SQLiteConnection object.</param>
        /// <param name="password">New password.</param>
        public void UpdatePassowrd(SQLiteConnection connection, string password)
        {
            try
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
                        OnUpdateProfileSuccess?.Invoke(this, new EventArgs());
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. The provided ID may not exist.");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Checks if the current password matches the one stored in the database.
        /// </summary>
        /// <param name="insertedCurrentPassword">Current password input.</param>
        /// <param name="insertedNewPassword">New password input.</param>
        public void CheckPassword(string insertedCurrentPassword, string insertedNewPassword)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
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
                                    OnMessageBox?.Invoke(this, "Incorrect current password!");
                                }
                                else
                                {
                                    string hashedPassword = UserData.Instance.CalculatePasswordSHA(insertedNewPassword);
                                    UpdatePassowrd(connection, hashedPassword);
                                    OnMessageBox?.Invoke(this, "Password updated succesfully!");
                                }
                            }
                            else
                            {
                                OnMessageBox?.Invoke(this, "Incorrect current password!");
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Saves food intake data to the database.
        /// </summary>
        /// <param name="date">Date of food intake.</param>
        /// <param name="name">Name of the food.</param>
        /// <param name="calories">Calories consumed.</param>
        /// <param name="servingSize">Serving size of the food.</param>
        /// <param name="fat">Fat content of the food.</param>
        /// <param name="protein">Protein content of the food.</param>
        /// <param name="carbo">Carbohydrate content of the food.</param>
        /// <returns>True if saving successful, false otherwise.</returns>
        public bool SaveFoodToDatabase(DateTime date, string name, double calories, double servingSize, double fat, double protein, double carbo)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    string query = @"INSERT INTO Logs (id, date, calories, serving_size, food_name, protein, carbo, fat) 
                     VALUES (@id, @date, @calories, @serving_size, @food_name, @protein, @carbo, @fat) ";

                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", UserData.Instance.Id);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@calories", calories);
                        command.Parameters.AddWithValue("@serving_size", servingSize);
                        command.Parameters.AddWithValue("@food_name", name);
                        command.Parameters.AddWithValue("@protein", protein);
                        command.Parameters.AddWithValue("@carbo", carbo);
                        command.Parameters.AddWithValue("@fat", fat);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retrieves weight history data from the database.
        /// </summary>
        /// <returns>List of tuples containing date and weight.</returns>
        public List<(DateTime, double)> GetWeightHistory()
        {
            List<(DateTime, double)> weightHistory = new List<(DateTime, double)>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    string query = @"SELECT date, weight FROM Weight WHERE id = @userId ORDER BY date";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", UserData.Instance.Id);

                        connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime date = reader.GetDateTime(0);
                                double weight = reader.GetDouble(1);
                                weightHistory.Add((date, weight));
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
            return weightHistory;
        }

        /// <summary>
        /// Retrieves daily calorie consumption data from the database.
        /// </summary>
        /// <returns>Dictionary with date as key and total calories consumed as value.</returns>
        public Dictionary<DateTime, double> GetCaloriesConsumedPerDay()
        {
            Dictionary<DateTime, double> caloriesPerDay = new Dictionary<DateTime, double>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    string query = @"SELECT date, SUM(calories) AS totalCalories
                         FROM Logs
                         WHERE id = @userId
                         GROUP BY date
                         ORDER BY date";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", UserData.Instance.Id);

                        connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime date = reader.GetDateTime(0);
                                double totalCalories = reader.GetDouble(1);
                                caloriesPerDay[date] = totalCalories;
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle SQLite exceptions
                OnMessageBox?.Invoke(this, "SQLite Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                OnMessageBox?.Invoke(this, "An error occurred: " + ex.Message);
            }
            return caloriesPerDay;
        }
    }
}
