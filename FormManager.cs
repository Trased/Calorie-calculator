using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public class FormManager
    {
        private static FormManager instance;

        private LogInForm _logInForm;
        private MainForm _mainForm;
        private RegistrationForm _registrationForm;
        private UpdateProfileForm _updateProfileForm;
        private ViewHistoryForm _viewHistoryForm;
        private LogFoodForm _logFoodForm;

        private FormManager()
        {
            _logInForm = new LogInForm();
            _mainForm = new MainForm();
            _registrationForm = new RegistrationForm();
            _updateProfileForm = new UpdateProfileForm();   
            _viewHistoryForm = new ViewHistoryForm();
            _logFoodForm = new LogFoodForm();
            ShowLogInForm();
        }

        public static FormManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormManager();
                }
                return instance;
            }
        }

        public LogInForm StartApplication()
        {
            return _logInForm;
        }

        public void ShowLogInForm()
        {
            _logInForm.Show();
        }

        public void HideLogInForm()
        {
            _logInForm.Hide();
        }

        public void ShowMainForm()
        {
            _mainForm.Show();
        }

        public void HideMainForm()
        {
            _mainForm.Hide();
        }
        public void ShowRegistrationForm()
        {
            _registrationForm.ResetForm();
            _registrationForm.Show();      
        }
        
        public void HideRegistrationForm()
        {
            _registrationForm.Hide();
        }

        public void ShowUpdateProfileForm()
        {
            _updateProfileForm.Show();
        }
        public void HideUpdateProfileForm()
        {
            _updateProfileForm.Hide();
        }

        public void ShowViewHistoryForm()
        {
            _viewHistoryForm.Show();
        }
        public void HideViewHistoryForm()
        {
            _viewHistoryForm.Hide();
        }

        public void ShowLogFoodForm()
        {
            _logFoodForm.Show();
        }
        public void HideLogFoodForm()
        {
            _logFoodForm.Hide();
        }

        public string CalculateSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
