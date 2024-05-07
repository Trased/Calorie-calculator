/**************************************************************************
 *                                                                        *
 *  File:        UserData.cs                                              *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Implements a singleton class for storing user data       *
 *               and password hashing.                                    *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System.Security.Cryptography;
using System.Text;

namespace DBMgr
{
    /// <summary>
    /// Singleton class for storing user data and password hashing.
    /// </summary>
    public class UserData
    {
        private static UserData _instance;

        private int _age;
        private int _height;
        private double _weight;
        private string _name;
        private int _id;
        private string _gender;

        /// <summary>
        /// Private default class constructor required for Singleton
        /// </summary>
        private UserData()
        {
            this._age = 0;
            this._height = 0;
            this._weight = 0;
            this._name = "";
            this._id = 0;
            this._gender = "";
        }

        /// <summary>
        /// Singleton instance accessor.
        /// </summary>
        public static UserData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserData();
                }
                return _instance;
            }
        }

        /// <summary>
        /// User's age.
        /// </summary>
        public int Age { get { return _age; } set { _age = value; } }

        /// <summary>
        /// User's height.
        /// </summary>
        public int Height { get { return _height; } set { _height = value; } }

        /// <summary>
        /// User's weight.
        /// </summary>
        public double Weight { get { return _weight; } set { _weight = value; } }

        /// <summary>
        /// User's name.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// User's unique identifier.
        /// </summary>
        public int Id { get { return _id; } set { _id = value; } }

        /// <summary>
        /// User's gender.
        /// </summary>
        public string Gender { get { return _gender; } set { _gender = value; } }

        /// <summary>
        /// Calculates SHA256 hash of the input string.
        /// </summary>
        /// <param name="input">String to be hashed.</param>
        /// <returns>Hashed string.</returns>
        public string CalculatePasswordSHA(string input)
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

        /// <summary>
        /// Initializes user data upon login.
        /// </summary>
        /// <param name="age">User's age.</param>
        /// <param name="height">User's height.</param>
        /// <param name="weight">User's weight.</param>
        /// <param name="name">User's name.</param>
        /// <param name="gender">User's gender.</param>
        public void InitializeUserDataOnLogIn(int age, int height, double weight, string name, string gender)
        {
            this._age = age;
            this._height = height;
            this._weight = weight;
            this._gender = gender;
            this._name = name;
        }
    }
}
