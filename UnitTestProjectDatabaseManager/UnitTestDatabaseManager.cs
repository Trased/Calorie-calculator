using DBMgr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDatabaseManager
{
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

    }
        //// TO COMPLETE ALL THE TEST CASES FOR DATABASE MANAGER!
}
