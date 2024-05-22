/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines the main form of the application.                *
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

namespace IpProiect
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the MainForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
            this.KeyDown += MainFormKeyDown;
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
        /// Handles the click event of the logFoodButton to hide the MainForm and show the LogFoodForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void LogFoodButtonClick(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowLogFoodForm();
        }

        /// <summary>
        /// Handles the click event of the viewHistoryButton to hide the MainForm and show the ViewHistoryForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void ViewHistoryButtonClick(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowViewHistoryForm();
        }

        /// <summary>
        /// Handles the click event of the updateProfileButton to hide the MainForm and show the UpdateProfileForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void UpdateProfileButtonClick(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowUpdateProfileForm();
        }

        /// <summary>
        /// Handles the click event of the logOutButton to hide the MainForm and show the LogInForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void LogOutButtonClick(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowLogInForm();
        }

        /// <summary>
        /// Event handler for the Click event of the exitToolStripMenuItem.
        /// Terminates the application when the exitToolStripMenuItem is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the EventArgs class that contains event data.</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the KeyDown event of the MainForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void MainFormKeyDown(object sender, KeyEventArgs e)
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
        private void DocumentationToolStripMenuItemClick(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "calorie_calculator_documentation.chm");
        }
    }
}
