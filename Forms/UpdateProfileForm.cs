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

namespace IP_PROJECT
{
    public partial class UpdateProfileForm : Form
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ResetForm()
        {
            this.ageBox.Value = 1;
            this.currentHeightBox.Value = 1;
            this.currentWeightBox.Value = 1;
            this.passwordBox.Text = "";
            this.newPassword0Box.Text = "";
            this.newPassword1Box.Text = "";
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideUpdateProfileForm();
            FormManager.Instance.ShowMainForm();
        }

        private void UpdateProfileField(string field, object value)
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                if (field == "weight")
                {
                    string query = "INSERT INTO Weight (id, date, weight) VALUES (@personId, @date, @weight)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personId", FormManager.Instance.CurrentUserID);
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
                        command.Parameters.AddWithValue("@userId", FormManager.Instance.CurrentUserID);

                        command.ExecuteNonQuery();
                    }
                }
                FormManager.Instance.HideUpdateProfileForm();
                FormManager.Instance.ShowMainForm();
            }
        }
        private void UpdatePassowrd(SQLiteConnection connection)
        {
            string query = "UPDATE Person SET password = @newPassword WHERE id = @id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@newPassword", FormManager.Instance.CalculateSHA256(newPassword0Box.Text));
                command.Parameters.AddWithValue("@id", FormManager.Instance.CurrentUserID);

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
        private void CheckPassword()
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string password = FormManager.Instance.CalculateSHA256(passwordBox.Text);

                string query = "SELECT password FROM Person WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", FormManager.Instance.CurrentUserID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if ((reader.Read()) && (passwordBox.Text != ""))
                        {
                            string currentPassword = reader["password"].ToString();
                            string readedPassword= FormManager.Instance.CalculateSHA256(passwordBox.Text);
                            if (currentPassword != readedPassword)
                            {
                                MessageBox.Show("Incorrect current password!");
                            }
                            else
                            {
                                UpdatePassowrd(connection);
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

        private void updateProfileButton_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrWhiteSpace(newPassword0Box.Text))
            {
                if (newPassword0Box.Text != newPassword1Box.Text)
                {
                    MessageBox.Show("New passwords do not match.")          ;
                    return;
                }
                CheckPassword();

                passwordBox.Text = "";
                newPassword0Box.Text = "";
                newPassword1Box.Text = "";
            }

            if (!string.IsNullOrWhiteSpace(ageBox.Text))
            {
                if (!(!int.TryParse(ageBox.Text, out int age) || age <= 1))
                {
                    UpdateProfileField("age", age);
                    MessageBox.Show("Age updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentWeightBox.Text))
            {
                if (!(!double.TryParse(currentWeightBox.Text, out double weight) || weight <= 1.0))
                {
                    UpdateProfileField("weight", weight);
                    MessageBox.Show("Weight updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentHeightBox.Text))
            {
                if (!(!int.TryParse(currentHeightBox.Text, out int height) || height <= 1))
                {
                    UpdateProfileField("height", height);
                    MessageBox.Show("Height updated successfully!");
                }
            }
        }
    }
}
