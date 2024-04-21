using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            DatabaseManager.Instance.LogIn(usernameBox.Text, passwordBox.Text);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            FormManager.Instance.HideLogInForm();
            FormManager.Instance.ShowRegistrationForm();
        }

        public void ResetForm()
        {
            this.usernameBox.Text = "";
            this.passwordBox.Text = "";
        }
    }
}
