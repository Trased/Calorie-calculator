using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT.Strategy
{
    class CalorieIntakeManager : ICalorieIntake
    {
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 0;
        }
    }

    class FemaleCalorieIntake : ICalorieIntake
    {
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 0;
        }
    }
}
