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

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if (string.IsNullOrWhiteSpace(gender) || (gender != "Male" && gender != "Female"))
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

            if (DatabaseManager.Instance.IsUsernameTaken(usernameBox.Text))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            DatabaseManager.Instance.Register(firstNameBox.Text, lastNameBox.Text, age, gender, height, weight, usernameBox.Text, passwordBox.Text);

            MessageBox.Show("Registration successful!");
            FormManager.Instance.HideRegistrationForm();
            FormManager.Instance.ShowLogInForm();
        }

        private bool IsOnlyLetters(string str)
        {
            return str.All(char.IsLetter);
        }
    }
}
