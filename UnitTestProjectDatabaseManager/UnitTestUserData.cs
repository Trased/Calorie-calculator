using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using DBMgr;

namespace UnitTestProjectDBManager
{
    [TestClass]
    public class UserDataTests
    {
        [TestMethod]
        public void UserDataInstanceIsSingleton()
        {
            // Arrange
            var instance1 = UserData.Instance;
            var instance2 = UserData.Instance;

            // Assert
            Assert.AreSame(instance1, instance2, "Instances are not the same.");
        }

        [TestMethod]
        public void UserDataPropertiesCanBeSetAndGet()
        {
            // Arrange
            var userData = UserData.Instance;

            // Act
            userData.Age = 30;
            userData.Height = 180;
            userData.Weight = 75.5;
            userData.Name = "John";
            userData.Id = 123;
            userData.Gender = "Male";

            // Assert
            Assert.AreEqual(30, userData.Age);
            Assert.AreEqual(180, userData.Height);
            Assert.AreEqual(75.5, userData.Weight);
            Assert.AreEqual("John", userData.Name);
            Assert.AreEqual(123, userData.Id);
            Assert.AreEqual("Male", userData.Gender);
        }

        [TestMethod]
        public void CalculatePasswordSHAReturnsCorrectHash()
        {
            // Arrange
            var userData = UserData.Instance;
            string input = "password123";
            string expectedHash = CalculateSHA256Hash(input);

            // Act
            string hashedPassword = userData.CalculatePasswordSHA(input);

            // Assert
            Assert.AreEqual(expectedHash, hashedPassword);
        }

        [TestMethod]
        public void InitializeUserDataOnLogInSetsUserDataCorrectly()
        {
            // Arrange
            var userData = UserData.Instance;

            // Act
            userData.InitializeUserDataOnLogIn(25, 170, 65.2, "Alice", "Female");

            // Assert
            Assert.AreEqual(25, userData.Age);
            Assert.AreEqual(170, userData.Height);
            Assert.AreEqual(65.2, userData.Weight);
            Assert.AreEqual("Alice", userData.Name);
            Assert.AreEqual("Female", userData.Gender);
        }

        private string CalculateSHA256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
