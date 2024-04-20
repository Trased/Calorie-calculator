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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logFoodButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowLogFoodForm();
        }

        private void viewHistoryButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowViewHistoryForm();
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowUpdateProfileForm();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideMainForm();
            FormManager.Instance.ShowLogInForm();
        }
    }
}
