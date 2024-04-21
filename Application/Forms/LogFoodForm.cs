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

namespace IP_PROJECT
{
    public partial class LogFoodForm : Form
    {
        public LogFoodForm()
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
            FormManager.Instance.HideLogFoodForm();
            FormManager.Instance.ShowMainForm();
        }

        public  void ShowInitialData()
        {
            currentDateDisplayLabel.Text = DateTime.Now.Date.ToShortDateString();
            currentDateDisplayLabel.Refresh();
            ICalorieIntake strategy = null;
            if(UserData.Instance.Gender == "M")
            {
                strategy = new MaleCalorieIntake();
            }
            else if(UserData.Instance.Gender == "F")
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
    }
}
