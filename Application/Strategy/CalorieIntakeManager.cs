using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT.Strategy
{
    class MaleCalorieIntake : ICalorieIntake
    {
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
        }
    }

    class FemaleCalorieIntake : ICalorieIntake
    {
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
        }
    }
}
