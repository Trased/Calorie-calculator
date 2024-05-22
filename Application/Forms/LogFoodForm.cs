/**************************************************************************
 *                                                                        *
 *  File:        LogFoodForm.cs                                           *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines the form for logging food intake in the          *
 *               application.                                             *
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using Strategy;
using ParserMgr;
using DBMgr;
namespace IpProiect
{
    public partial class LogFoodForm : Form
    {
        /// <summary>
        /// Initializes the LogFoodForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public LogFoodForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;

            this.KeyDown += LogFoodFormKeyDown;
            DatabaseManager.Instance.OnLoginSuccess += HandleLoginSuccess;
            DatabaseManager.Instance.OnMessageBox += HandleMessageBox;
            ParserManager.Instance.OnMessageBox += HandleMessageBox;
        }

        /// <summary>
        /// Displays the current date and calculates and displays the recommended calorie intake based on user data.
        /// </summary>
        public void ShowInitialData()
        {
            currentDateDisplayLabel.Text = DateTime.Now.Date.ToShortDateString();
            currentDateDisplayLabel.Refresh();
            ICalorieIntake strategy = null;
            if (UserData.Instance.Gender == "M")
            {
                strategy = new MaleCalorieIntake();
            }
            else if (UserData.Instance.Gender == "F")
            {
                strategy = new FemaleCalorieIntake();
            }
            CalorieIntakeCalculator calculator = new CalorieIntakeCalculator(strategy);
            calorieIntakeDisplayLabel.Text = calculator.CalculateRecommendedCalorie(
                UserData.Instance.Age,
                UserData.Instance.Height,
                UserData.Instance.Weight)
                .ToString();
            calorieIntakeDisplayLabel.Refresh();
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
        /// Handles the click event of the backToMainMenuButton to hide the LogFoodForm and show the MainForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogFoodForm();
            FormManager.Instance.ShowMainForm();
        }

        /// <summary>
        /// Handles the click event of the searchButton to initiate a food search using the entered query.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(foodSearchBox.Text))
            {
                try
                {
                    List<string> formattedResults = await ParserManager.Instance.ParseSearch(foodSearchBox.Text);
                    searchOutputBox.Items.Clear();
                    searchOutputBox.Items.AddRange(formattedResults.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the click event of the proceedButton to save the selected food item to the database.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void proceedButton_Click(object sender, EventArgs e)
        {
            if(searchOutputBox.SelectedIndex != -1)
            {
                string selectedItem = searchOutputBox.SelectedItem.ToString();
                string[] parts = selectedItem.Split(':');
                if(parts.Length >= 2)
                {
                    string name = parts[0].Trim();
                    string[] nutritionParts = parts[1].Split(',');
                    double calories = ParserManager.Instance.ParseDouble(nutritionParts[0]);
                    double servingSize = ParserManager.Instance.ParseDouble(nutritionParts[1]);
                    double fat = ParserManager.Instance.ParseDouble(nutritionParts[2]);
                    double protein = ParserManager.Instance.ParseDouble(nutritionParts[3]);
                    double carbo = ParserManager.Instance.ParseDouble(nutritionParts[4]);
                    if(FormManager.Instance.GetDbManager.SaveFoodToDatabase(dateTimeInput.Value, name, calories,  servingSize, fat, protein, carbo))
                    {
                        MessageBox.Show("Food has been saved in the database!");
                    }
                    else
                    {
                        MessageBox.Show("There was an error while saving the food to the database");
                    }
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
        /// Event handler for the KeyDown event of the LogFoodForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void logFoodForm_KeyDown(object sender, KeyEventArgs e)
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

        private void HandleLoginSuccess(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogInForm();
            FormManager.Instance.ShowMainForm();
        }
        private void HandleMessageBox(object sender, string message)
        {
            MessageBox.Show(message);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
