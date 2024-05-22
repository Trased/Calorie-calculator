using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserMgr;

namespace UnitTestProjectParserManager
{
    [TestClass]
    public class UnitTestNutrition
    {
        [TestMethod]
        public void NutritionNameSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            string expectedName = "Apple";

            // Act
            nutrition.Name = expectedName;

            // Assert
            Assert.AreEqual(expectedName, nutrition.Name);
        }

        [TestMethod]
        public void NutritionCaloriesSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            double expectedCalories = 100.5;

            // Act
            nutrition.Calories = expectedCalories;

            // Assert
            Assert.AreEqual(expectedCalories, nutrition.Calories);
        }

        [TestMethod]
        public void NutritionServingSizeSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            double expectedServingSize = 150;

            // Act
            nutrition.ServingSizeG = expectedServingSize;

            // Assert
            Assert.AreEqual(expectedServingSize, nutrition.ServingSizeG);
        }

        [TestMethod]
        public void NutritionFatTotalSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            double expectedFatTotal = 10.2;

            // Act
            nutrition.FatG = expectedFatTotal;

            // Assert
            Assert.AreEqual(expectedFatTotal, nutrition.FatG);
        }

        [TestMethod]
        public void NutritionProteinSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            double expectedProtein = 25.3;

            // Act
            nutrition.ProteinG = expectedProtein;

            // Assert
            Assert.AreEqual(expectedProtein, nutrition.ProteinG);
        }

        [TestMethod]
        public void NutritionCarbohydratesTotalSetCorrectly()
        {
            // Arrange
            var nutrition = new Nutrition();
            double expectedCarbohydratesTotal = 30.7;

            // Act
            nutrition.CarbohydratesG = expectedCarbohydratesTotal;

            // Assert
            Assert.AreEqual(expectedCarbohydratesTotal, nutrition.CarbohydratesG);
        }
    }
}
