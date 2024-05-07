using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy;

namespace UnitTestProjectStrategy
{
    [TestClass]
    public class CalorieIntakeCalculatorTests
    {
        [TestMethod]
        public void CalculateRecommendedCalorie_ForMale_ReturnsCorrectValue()
        {
            // Arrange
            var calculator = new CalorieIntakeCalculator(new MaleCalorieIntake());
            int age = 30;
            int height = 180; // in cm
            double weight = 80; // in kg
            double expectedCalorieIntake = 13.397 * weight + 4.799 * height - 5.677 * age + 88.362;

            // Act
            double calculatedCalorieIntake = calculator.CalculateRecommendedCalorie(age, height, weight);

            // Assert
            Assert.AreEqual(expectedCalorieIntake, calculatedCalorieIntake, 0.001);
        }

        [TestMethod]
        public void CalculateRecommendedCalorie_ForFemale_ReturnsCorrectValue()
        {
            // Arrange
            var calculator = new CalorieIntakeCalculator(new FemaleCalorieIntake());
            int age = 30;
            int height = 160; // in cm
            double weight = 60; // in kg
            double expectedCalorieIntake = 9.247 * weight + 3.098 * height - 4.33 * age + 447.593;

            // Act
            double calculatedCalorieIntake = calculator.CalculateRecommendedCalorie(age, height, weight);

            // Assert
            Assert.AreEqual(expectedCalorieIntake, calculatedCalorieIntake, 0.001);
        }
    }

    [TestClass]
    public class MaleCalorieIntakeTests
    {
        [TestMethod]
        public void CalculateRecommendedCalorieIntake_ReturnsCorrectValue()
        {
            // Arrange
            var maleCalorieIntake = new MaleCalorieIntake();
            int age = 30;
            int height = 180; // in cm
            double weight = 80; // in kg
            double expectedCalorieIntake = 13.397 * weight + 4.799 * height - 5.677 * age + 88.362;

            // Act
            double calculatedCalorieIntake = maleCalorieIntake.CalculateRecommendedCalorieIntake(age, height, weight);

            // Assert
            Assert.AreEqual(expectedCalorieIntake, calculatedCalorieIntake, 0.001);
        }
    }

    [TestClass]
    public class FemaleCalorieIntakeTests
    {
        [TestMethod]
        public void CalculateRecommendedCalorieIntake_ReturnsCorrectValue()
        {
            // Arrange
            var femaleCalorieIntake = new FemaleCalorieIntake();
            int age = 30;
            int height = 160; // in cm
            double weight = 60; // in kg
            double expectedCalorieIntake = 9.247 * weight + 3.098 * height - 4.33 * age + 447.593;

            // Act
            double calculatedCalorieIntake = femaleCalorieIntake.CalculateRecommendedCalorieIntake(age, height, weight);

            // Assert
            Assert.AreEqual(expectedCalorieIntake, calculatedCalorieIntake, 0.001);
        }
    }
}
