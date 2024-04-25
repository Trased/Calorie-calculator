/**************************************************************************
 *                                                                        *
 *  File:        FormManager.cs                                           *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Manages the display of various forms in the              *
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
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IP_PROJECT
{
    /// <summary>
    /// Singleton class for managing form display.
    /// </summary>
    public class FormManager
    {
        private static FormManager _instance;

        private LogInForm _logInForm;
        private MainForm _mainForm;
        private RegistrationForm _registrationForm;
        private UpdateProfileForm _updateProfileForm;
        private ViewHistoryForm _viewHistoryForm;
        private LogFoodForm _logFoodForm;

        /// <summary>
        /// Initializes forms and shows the login form.
        /// </summary>
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

        /// <summary>
        /// Singleton instance accessor.
        /// </summary>
        public static FormManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormManager();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Retrieves the login form to start the application.
        /// </summary>
        /// <returns>Login form instance.</returns>
        public LogInForm StartApplication()
        {
            return _logInForm;
        }

        /// <summary>
        /// Shows the login form.
        /// </summary>
        public void ShowLogInForm()
        {
            _logInForm.ResetForm();
            _logInForm.Show();
        }

        /// <summary>
        /// Hides the login form.
        /// </summary>
        public void HideLogInForm()
        {
            _logInForm.Hide();
        }

        /// <summary>
        /// Shows the main form.
        /// </summary>
        public void ShowMainForm()
        {
            _mainForm.Show();
        }

        /// <summary>
        /// Hides the main form.
        /// </summary>
        public void HideMainForm()
        {
            _mainForm.Hide();
        }

        /// <summary>
        /// Shows the registration form and resets it.
        /// </summary>
        public void ShowRegistrationForm()
        {
            _registrationForm.ResetForm();
            _registrationForm.Show();      
        }

        /// <summary>
        /// Hides the registration form.
        /// </summary>
        public void HideRegistrationForm()
        {
            _registrationForm.Hide();
        }

        /// <summary>
        /// Shows the update profile form and resets it.
        /// </summary>
        public void ShowUpdateProfileForm()
        {
            _updateProfileForm.ResetForm();
            _updateProfileForm.Show();
        }

        /// <summary>
        /// Hides the update profile form.
        /// </summary>
        public void HideUpdateProfileForm()
        {
            _updateProfileForm.Hide();
        }

        /// <summary>
        /// Shows the view history form and resets it.
        /// </summary>
        public void ShowViewHistoryForm()
        {
            _viewHistoryForm.ResetForm();
            _viewHistoryForm.Show();
        }

        /// <summary>
        /// Hides the view history form.
        /// </summary>
        public void HideViewHistoryForm()
        {
            _viewHistoryForm.Hide();
        }

        /// <summary>
        /// Shows the log food form and initializes it with initial data.
        /// </summary>
        public void ShowLogFoodForm()
        {
            _logFoodForm.Show();
            _logFoodForm.ShowInitialData();
        }

        /// <summary>
        /// Hides the log food form.
        /// </summary>
        public void HideLogFoodForm()
        {
            _logFoodForm.Hide();
        }
    }
}
