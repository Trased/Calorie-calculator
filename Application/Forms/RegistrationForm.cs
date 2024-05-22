/**************************************************************************
 *                                                                        *
 *  File:        RegistrationForm.cs                                      *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines a form for user registration.                    *
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
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DBMgr;
namespace IpProiect
{
    public partial class RegistrationForm : Form
    {
        /// <summary>
        /// Initializes the RegistrationForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
            this.KeyDown += registrationForm_KeyDown;
        }

        /// <summary>
        /// Closes the application when the form is closing.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">FormClosing event arguments.</param>
        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Resets the form by clearing input fields.
        /// </summary>
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

        /// <summary>
        /// Handles the click event of the logInButtton to hide the RegistrationForm and show the LogInForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void logInButtton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideRegistrationForm();
            FormManager.Instance.ShowLogInForm();
        }

        /// <summary>
        /// Handles the click event of the registerButton to register a new user.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
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

            if (FormManager.Instance.GetDbManager.IsUsernameTaken(usernameBox.Text))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            FormManager.Instance.GetDbManager.Register(firstNameBox.Text, lastNameBox.Text, age, gender, height, weight, usernameBox.Text, passwordBox.Text);

            MessageBox.Show("Registration successful!");
            FormManager.Instance.HideRegistrationForm();
            FormManager.Instance.ShowLogInForm();
        }

        /// <summary>
        /// Validates whether a string contains only letters.
        /// </summary>
        /// <param name="str">String to validate.</param>
        /// <returns>True if the string contains only letters; otherwise, false.</returns>
        private bool IsOnlyLetters(string str)
        {
            return str.All(char.IsLetter);
        }

        /// <summary>
        /// Event handler for the Click event of the exitToolStripMenuItem.
        /// Terminates the application when the exitToolStripMenuItem is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the EventArgs class that contains event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the KeyDown event of the RegistrationForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void registrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if CTRL+X combination is pressed
            if (e.Control && e.KeyCode == Keys.X)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Event handler for the Click event of the documentationToolStripMenuItem.
        /// Displays the documentation for the calorie calculator application.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the EventArgs class that contains event data.</param>
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "calorie_calculator_documentation.chm");
        }
    }
}
