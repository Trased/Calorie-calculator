/**************************************************************************
 *                                                                        *
 *  File:        LogInForm.cs                                             *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines the login form of the application.               *
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
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DBMgr;
namespace IpProiect
{
    public partial class LogInForm : Form
    {
        /// <summary>
        /// Initializes the LogInForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
            this.KeyDown += logInForm_KeyDown;
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
        /// Handles the click event of the logInButton to initiate the login process using the entered credentials.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.GetDbManager.LogIn(usernameBox.Text, passwordBox.Text);
        }

        /// <summary>
        /// Handles the click event of the registerButton to hide the LogInForm and show the RegistrationForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogInForm();
            FormManager.Instance.ShowRegistrationForm();
        }

        /// <summary>
        /// Resets the content of the username and password fields in the form.
        /// </summary>
        public void ResetForm()
        {
            this.usernameBox.Text = "";
            this.passwordBox.Text = "";
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
        /// Event handler for the KeyDown event of the LogInForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void logInForm_KeyDown(object sender, KeyEventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
