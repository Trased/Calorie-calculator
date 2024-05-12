using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMgr
{
    public interface IDatabaseManager
    {
        void SetCredentials();
        void LogIn(string username, string password);
        void Register(string firstName, string lastName, int age, string gender, int height, double weight, string username, string password);
        bool IsUsernameTaken(string username);
        void UpdateProfileField(string field, object value);
        void UpdatePassowrd(SQLiteConnection connection, string password);
        void CheckPassword(string insertedCurrentPassword, string insertedNewPassword);
        bool SaveFoodToDatabase(DateTime date, string name, double calories, double servingSize, double fat, double protein, double carbo);
        List<(DateTime, double)> GetWeightHistory();
        Dictionary<DateTime, double> GetCaloriesConsumedPerDay();

    }
}
