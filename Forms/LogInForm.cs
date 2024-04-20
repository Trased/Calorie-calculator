using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=calorie_calculator.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string username = usernameBox.Text;
                string password = FormManager.Instance.CalculateSHA256(passwordBox.Text);

                string query = "SELECT id, COUNT(*) as count FROM Person WHERE username = @username AND password = @password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && Convert.ToInt32(reader["count"]) > 0)
                        {
                            FormManager.Instance.CurrentUserID = Convert.ToInt32(reader["id"]);
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogInForm();
            FormManager.Instance.ShowRegistrationForm();
        }

        public void ResetForm()
        {
            this.usernameBox.Text = "";
            this.passwordBox.Text = "";
        }
    }
}
