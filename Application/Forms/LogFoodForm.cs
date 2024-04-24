using IP_PROJECT.Strategy;
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

namespace IP_PROJECT
{
    public partial class LogFoodForm : Form
    {
        public LogFoodForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

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

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogFoodForm();
            FormManager.Instance.ShowMainForm();
        }

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
                    if(DatabaseManager.Instance.SaveFoodToDatabase(dateTimeInput.Value, name, calories,  servingSize, fat, protein, carbo))
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
    }
}
