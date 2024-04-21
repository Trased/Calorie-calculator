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

namespace IP_PROJECT
{
    public partial class UpdateProfileForm : Form
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ResetForm()
        {
            this.ageBox.Value = 1;
            this.currentHeightBox.Value = 1;
            this.currentWeightBox.Value = 1;
            this.passwordBox.Text = "";
            this.newPassword0Box.Text = "";
            this.newPassword1Box.Text = "";
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideUpdateProfileForm();
            FormManager.Instance.ShowMainForm();
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrWhiteSpace(newPassword0Box.Text))
            {
                if (newPassword0Box.Text != newPassword1Box.Text)
                {
                    MessageBox.Show("New passwords do not match.")          ;
                    return;
                }
                DatabaseManager.Instance.CheckPassword(passwordBox.Text, newPassword0Box.Text);

                passwordBox.Text = "";
                newPassword0Box.Text = "";
                newPassword1Box.Text = "";
            }

            if (!string.IsNullOrWhiteSpace(ageBox.Text))
            {
                if (!(!int.TryParse(ageBox.Text, out int age) || age <= 1))
                {
                    DatabaseManager.Instance.UpdateProfileField("age", age);
                    MessageBox.Show("Age updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentWeightBox.Text))
            {
                if (!(!double.TryParse(currentWeightBox.Text, out double weight) || weight <= 1.0))
                {
                    DatabaseManager.Instance.UpdateProfileField("weight", weight);
                    MessageBox.Show("Weight updated successfully!");
                }
            }

            if (!string.IsNullOrWhiteSpace(currentHeightBox.Text))
            {
                if (!(!int.TryParse(currentHeightBox.Text, out int height) || height <= 1))
                {
                    DatabaseManager.Instance.UpdateProfileField("height", height);
                    MessageBox.Show("Height updated successfully!");
                }
            }
        }
    }
}
