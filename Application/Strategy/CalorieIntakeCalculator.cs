using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT.Strategy
{
    class CalorieIntakeCalculator
    {
        private ICalorieIntake _strategy;

        public CalorieIntakeCalculator(ICalorieIntake strategy)
        {
            this._strategy = strategy;
        }

        public double CalculateRecommendedCalorie(int age, int height, double weight)
        {
            return _strategy.CalculateRecommendedCalorieIntake(age, height, weight);
        }
    }
}
