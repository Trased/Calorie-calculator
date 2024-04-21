using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT.Strategy
{
    interface ICalorieIntake
    {
        double CalculateRecommendedCalorieIntake(int age, int height, double weight);
    }
}
