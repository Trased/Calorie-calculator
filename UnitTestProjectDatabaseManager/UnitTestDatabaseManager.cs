using DBMgr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace UnitTestProjectDatabaseManager
{
    [TestClass]
    public class UnitTestDatabaseManager
    {
        [TestMethod]
        public void DatabaseManager_Instance_IsSingleton()
        {
            // Arrange
            var instance1 = DatabaseManager.Instance;
            var instance2 = DatabaseManager.Instance;

            // Assert
            Assert.AreSame(instance1, instance2, "Instances are not the same.");
        }
        [TestMethod]
        public void SetCredentialsTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.SetCredentials());

            // Act
            mock.Object.SetCredentials();

            // Assert
            mock.Verify(x => x.SetCredentials(), Times.Once);
        }

        [TestMethod]
        public void LogInTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.LogIn("username", "password"));

            // Act
            mock.Object.LogIn("username", "password");

            // Assert
            mock.Verify(x => x.LogIn("username", "password"), Times.Once);
        }

        [TestMethod]
        public void LogIn_Throws_SQLiteException_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.LogIn(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new SQLiteException("Test SQLite Exception"));

            // Act & Assert
            Assert.ThrowsException<SQLiteException>(() => mock.Object.LogIn("username", "password"));
        }

        [TestMethod]
        public void LogIn_Throws_Other_Exception_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.LogIn(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception("Test Exception"));

            // Act & Assert
            Assert.ThrowsException<Exception>(() => mock.Object.LogIn("username", "password"));
        }

        [TestMethod]
        public void RegisterTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.Register("John", "Doe", 30, "Male", 180, 75.5, "johndoe", "password"));

            // Act
            mock.Object.Register("John", "Doe", 30, "Male", 180, 75.5, "johndoe", "password");

            // Assert
            mock.Verify(x => x.Register("John", "Doe", 30, "Male", 180, 75.5, "johndoe", "password"), Times.Once);
        }
        [TestMethod]
        public void Register_Throws_SQLiteException_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.Register(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<double>(), It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new SQLiteException("Test SQLite Exception"));

            // Act & Assert
            Assert.ThrowsException<SQLiteException>(() => mock.Object.Register("John", "Doe", 30, "Male", 180, 75.5, "johndoe", "password"));
        }

        [TestMethod]
        public void Register_Throws_Other_Exception_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.Register(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<double>(), It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception("Test Exception"));

            // Act & Assert
            Assert.ThrowsException<Exception>(() => mock.Object.Register("John", "Doe", 30, "Male", 180, 75.5, "johndoe", "password"));
        }

        [TestMethod]
        public void IsUsernameTakenTest_ReturnFalse()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.IsUsernameTaken("username")).Returns(false);

            // Act
            bool isTaken = mock.Object.IsUsernameTaken("username");

            // Assert
            Assert.IsFalse(isTaken);
        }

        [TestMethod]
        public void IsUsernameTakenTest_ReturnTrue()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.IsUsernameTaken("username")).Returns(true);

            // Act
            bool isTaken = mock.Object.IsUsernameTaken("username");

            // Assert
            Assert.IsTrue(isTaken);
        }

        [TestMethod]
        public void IsUsernameTaken_Throws_SQLiteException_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.IsUsernameTaken(It.IsAny<string>()))
                .Throws(new SQLiteException("Test SQLite Exception"));

            // Act & Assert
            Assert.ThrowsException<SQLiteException>(() => mock.Object.IsUsernameTaken("username"));
        }

        [TestMethod]
        public void IsUsernameTaken_Throws_Other_Exception_Test()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.IsUsernameTaken(It.IsAny<string>()))
                .Throws(new Exception("Test Exception"));

            // Act & Assert
            Assert.ThrowsException<Exception>(() => mock.Object.IsUsernameTaken("username"));
        }

        [TestMethod]
        public void UpdateProfileFieldTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.UpdateProfileField("field", "value"));

            // Act
            mock.Object.UpdateProfileField("field", "value");

            // Assert
            mock.Verify(x => x.UpdateProfileField("field", "value"), Times.Once);
        }

        [TestMethod]
        public void CheckPasswordTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.CheckPassword("currentPassword", "newPassword"));

            // Act
            mock.Object.CheckPassword("currentPassword", "newPassword");

            // Assert
            mock.Verify(x => x.CheckPassword("currentPassword", "newPassword"), Times.Once);
        }

        [TestMethod]
        public void GetWeightHistoryTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.GetWeightHistory()).Returns(new List<(DateTime, double)>());

            // Act
            var result = mock.Object.GetWeightHistory();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetCaloriesConsumedPerDayTest()
        {
            // Arrange
            var mock = new Mock<IDatabaseManager>();
            mock.Setup(x => x.GetCaloriesConsumedPerDay()).Returns(new Dictionary<DateTime, double>());

            // Act
            var result = mock.Object.GetCaloriesConsumedPerDay();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

    }
}
