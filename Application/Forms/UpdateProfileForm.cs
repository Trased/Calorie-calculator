/**************************************************************************
 *                                                                        *
 *  File:        UpdateProfileForm.cs                                     *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines a form for updating user profile information.    *
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
using DBMgr;
namespace IP_PROJECT
{
    public partial class UpdateProfileForm : Form
    {
        /// <summary>
        /// Initializes the UpdateProfileForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public UpdateProfileForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
            this.KeyDown += UpdateProfileForm_KeyDown;
            DatabaseManager.Instance.OnUpdateProfileSuccess += HandleUpdateProfileSuccess;
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
            this.ageBox.Value = 1;
            this.currentHeightBox.Value = 1;
            this.currentWeightBox.Value = 1;
            this.passwordBox.Text = "";
            this.newPassword0Box.Text = "";
            this.newPassword1Box.Text = "";
        }

        /// <summary>
        /// Handles the click event of the backToMainMenuButton to hide the UpdateProfileForm and show the MainForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideUpdateProfileForm();
            FormManager.Instance.ShowMainForm();
        }

        /// <summary>
        /// Handles the click event of the updateProfileButton to update the user's profile information.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void updateProfileButton_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrWhiteSpace(newPassword0Box.Text))
            {
                if (newPassword0Box.Text != newPassword1Box.Text)
                {
                    MessageBox.Show("New passwords do not match.")          ;
                    return;
                }
                FormManager.Instance.GetDbManager.CheckPassword(passwordBox.Text, newPassword0Box.Text);

                passwordBox.Text = "";
                newPassword0Box.Text = "";
                newPassword1Box.Text = "";
            }

            if (!string.IsNullOrWhiteSpace(ageBox.Text))
            {
                if (!(!int.TryParse(ageBox.Text, out int age) || age <= 1))
                {
                    FormManager.Instance.GetDbManager.UpdateProfileField("age", age);
                    MessageBox.Show("Age updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentWeightBox.Text))
            {
                if (!(!double.TryParse(currentWeightBox.Text, out double weight) || weight <= 1.0))
                {
                    FormManager.Instance.GetDbManager.UpdateProfileField("weight", weight);
                    MessageBox.Show("Weight updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentHeightBox.Text))
            {
                if (!(!int.TryParse(currentHeightBox.Text, out int height) || height <= 1))
                {
                    FormManager.Instance.GetDbManager.UpdateProfileField("height", height);
                    MessageBox.Show("Height updated successfully!");
                }
            }
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
        /// Event handler for the KeyDown event of the UpdateProfileForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void UpdateProfileForm_KeyDown(object sender, KeyEventArgs e)
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
        private void HandleUpdateProfileSuccess(object sender, EventArgs e)
        {
            FormManager.Instance.HideUpdateProfileForm();
            FormManager.Instance.ShowMainForm();
        }
    }
}
