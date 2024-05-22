/**************************************************************************
 *                                                                        *
 *  File:        ViewHistoryForm.cs                                       *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines a form for viewing user history,                 *
 *               including calorie consumption and weight tracking.       *
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
using DBMgr;
namespace IpProiect
{
    public partial class ViewHistoryForm : Form
    {
        /// <summary>
        /// Initializes the ViewHistoryForm and attaches a FormClosing event handler to close the application.
        /// </summary>
        public ViewHistoryForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
            this.KeyDown += viewHistoryForm_KeyDown;
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
        /// Handles the click event of the backToMainMenuButton to hide the ViewHistoryForm and show the MainForm.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideViewHistoryForm();
            FormManager.Instance.ShowMainForm();
        }

        /// <summary>
        /// Handles the click event of the calorieHistoryButton to display calorie consumption history.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void calorieHistoryButton_Click(object sender, EventArgs e)
        {
            Dictionary<DateTime, double> caloriesPerDay = FormManager.Instance.GetDbManager.GetCaloriesConsumedPerDay();

            progressChart.Series.Clear();

            progressChart.Series.Add("Calories");
            progressChart.Series["Calories"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Add data points to the series
            foreach (var dataPoint in caloriesPerDay)
            {
                progressChart.Series["Calories"].Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            progressChart.ChartAreas[0].AxisX.Title = "Date";
            progressChart.ChartAreas[0].AxisY.Title = "Total Calories Consumed";

            double minCalories = Math.Floor(caloriesPerDay.Min(cp => cp.Value) / 100) * 100; // Round down to nearest 100
            double maxCalories = Math.Ceiling(caloriesPerDay.Max(cp => cp.Value) / 100) * 100; // Round up to nearest 100
            progressChart.ChartAreas[0].AxisY.Minimum = minCalories;
            progressChart.ChartAreas[0].AxisY.Maximum = maxCalories;
        }

        /// <summary>
        /// Handles the click event of the weightHistoryButton to display weight tracking history.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void weightHistoryButton_Click(object sender, EventArgs e)
        {
            List<(DateTime, double)> weightHistory = FormManager.Instance.GetDbManager.GetWeightHistory();
            progressChart.Series.Clear();

            progressChart.Series.Add("Weight");
            progressChart.Series["Weight"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (var dataPoint in weightHistory)
            {
                progressChart.Series["Weight"].Points.AddXY(dataPoint.Item1, dataPoint.Item2);
            }

            progressChart.ChartAreas[0].AxisX.Title = "Date";
            progressChart.ChartAreas[0].AxisY.Title = "Weight (kg)";

            double minWeight = Math.Floor(weightHistory.Min(wp => wp.Item2) / 10) * 10; // Round down to nearest 10
            double maxWeight = Math.Ceiling(weightHistory.Max(wp => wp.Item2) / 10) * 10; // Round up to nearest 10
            progressChart.ChartAreas[0].AxisY.Minimum = minWeight;
            progressChart.ChartAreas[0].AxisY.Maximum = maxWeight;
        }

        /// <summary>
        /// Resets the form by clearing the chart series.
        /// </summary>
        public void ResetForm()
        {
            progressChart.Series.Clear();
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
        /// Event handler for the KeyDown event of the ViewHistoryForm.
        /// Detects keyboard input and checks if the CTRL+X combination is pressed.
        /// Terminates the application if CTRL+X is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An instance of the KeyEventArgs class that contains event data, including the keys that were pressed.</param>
        private void viewHistoryForm_KeyDown(object sender, KeyEventArgs e)
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
