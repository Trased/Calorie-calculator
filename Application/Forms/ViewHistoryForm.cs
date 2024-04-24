using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public partial class ViewHistoryForm : Form
    {
        public ViewHistoryForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideViewHistoryForm();
            FormManager.Instance.ShowMainForm();
        }

        private void calorieHistoryButton_Click(object sender, EventArgs e)
        {
            Dictionary<DateTime, double> caloriesPerDay = DatabaseManager.Instance.GetCaloriesConsumedPerDay();

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

        private void weightHistoryButton_Click(object sender, EventArgs e)
        {
            List<(DateTime, double)> weightHistory = DatabaseManager.Instance.GetWeightHistory();
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

        public void ResetForm()
        {
            progressChart.Series.Clear();
        }
    }
}
