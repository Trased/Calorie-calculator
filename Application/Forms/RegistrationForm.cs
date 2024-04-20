using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IP_PROJECT
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }
        public void ResetForm()
        {
            this.genderBox.Text = string.Empty;
            this.firstNameBox.Text = string.Empty;
            this.lastNameBox.Text = string.Empty;
            this.ageBox.Text = "1";
            this.currentHeightBox.Text = "1";
            this.currentWeightBox.Text = "1.0";
            this.usernameBox.Text = string.Empty;
            this.passwordBox.Text = string.Empty;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logInButtton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideRegistrationForm();
            FormManager.Instance.ShowLogInForm();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text) || !IsOnlyLetters(firstNameBox.Text))
            {
                MessageBox.Show("Please enter a valid first name (only letters).");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameBox.Text) || !IsOnlyLetters(lastNameBox.Text))
            {
                MessageBox.Show("Please enter a valid last name (only letters).");
                return;
            }

            int age;
            if (!int.TryParse(ageBox.Text, out age) || age <= 0 || age == 1)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string gender = genderBox.Text;
            if (string.IsNullOrWhiteSpace(gender) || (gender != "Male" && gender != "Female" && gender != "Other"))
            {
                MessageBox.Show("Please select a valid gender (Male, Female, or Other).");
                return;
            }

            double weight;
            if (!double.TryParse(currentWeightBox.Text, out weight) || weight <= 0 || weight == 1.0)
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }

            int height;
            if (!int.TryParse(currentHeightBox.Text, out height) || height <= 0 || height == 1)
            {
                MessageBox.Show("Please enter a valid height.");
                return;
            }

            if (string.IsNullOrWhiteSpace(usernameBox.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (IsUsernameTaken(usernameBox.Text))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            InsertDataIntoDatabase(firstNameBox.Text, lastNameBox.Text, age, gender, height, weight, usernameBox.Text, passwordBox.Text);

            MessageBox.Show("Registration successful!");
            FormManager.Instance.HideRegistrationForm();
            FormManager.Instance.ShowLogInForm();
        }

        private bool IsOnlyLetters(string str)
        {
            return str.All(char.IsLetter);
        }

        private bool IsUsernameTaken(string username)
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";
            bool isTaken = false;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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

        private void InsertDataIntoDatabase(string firstName, string lastName, int age, string gender, int height, double weight, string username, string password)
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string actualGender = "";
                switch (gender)
                {
                    case "Male":
                        actualGender = "M";
                        break;
                    case "Female":
                        actualGender = "F";
                        break;
                    case "Other":
                        actualGender = "O";
                        break;

                }
                string insertPersonDataQuery = "INSERT INTO PersonData (first_name, last_name, age, gender, height) VALUES (@firstName, @lastName, @age, @gender, @height)";
                using (SQLiteCommand command = new SQLiteCommand(insertPersonDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", actualGender);
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
                    command.Parameters.AddWithValue("@password", FormManager.Instance.CalculateSHA256(password));
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
