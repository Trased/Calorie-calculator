using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT
{
    public class UserData
    {
        private static UserData _instance;

        private int _age = 0;
        private int _height = 0;
        private double _weight = 0;
        private string _name = "";
        private int _id = 0;
        private string _gender = "";

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

        public int Age { get { return _age; } set { _age = value; } }
        public int Height{ get { return _height; } set {  _height = value; } }
        public double Weight { get { return _weight; } set { _weight = value; } } 
        public string Name { get { return _name;} set { _name = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }

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

        public void InitializeUserDataOnLogIn()
        {

        }
    }
}
