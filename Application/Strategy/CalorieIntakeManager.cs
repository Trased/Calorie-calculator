/**************************************************************************
 *                                                                        *
 *  File:        CalorieIntakeManager.cs                                  *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defining classes implementing the strategy pattern       *
 *  for calculating recommended calorie intake based on gender.           *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_PROJECT.Strategy
{
    class MaleCalorieIntake : ICalorieIntake
    {
        /// <summary>
        /// Calculate recommended calorie intake for men using Revised Harris-Benedict Equation
        /// </summary>
        /// <param name="age">Age of the individual.</param>
        /// <param name="height">Height of the individual.</param>
        /// <param name="weight">Weight of the individual.</param>
        /// <returns>The recommended calorie intake.</returns>
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 13.397 * weight + 4.799 * height - 5.677 * age + 88.362;
        }
    }

    class FemaleCalorieIntake : ICalorieIntake
    {
        /// <summary>
        /// Calculate recommended calorie intake for women using Revised Harris-Benedict Equation
        /// </summary>
        /// <param name="age">Age of the individual.</param>
        /// <param name="height">Height of the individual.</param>
        /// <param name="weight">Weight of the individual.</param>
        /// <returns>The recommended calorie intake.</returns>
        public double CalculateRecommendedCalorieIntake(int age, int height, double weight)
        {
            return 9.247 * weight + 3.098 * height - 4.33 * age + 447.593;
        }
    }
}
