/**************************************************************************
 *                                                                        *
 *  File:        CalorieIntakeCalculator.cs                               *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Implement a calculator using the strategy pattern        *
 *               for calculating recommended calorie intake.              *
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
    class CalorieIntakeCalculator
    {
        private ICalorieIntake _strategy;

        /// <summary>
        /// Constructor for CalorieIntakeCalculator class.
        /// </summary>
        /// <param name="strategy">Strategy for calculating recommended calorie intake.</param>
        public CalorieIntakeCalculator(ICalorieIntake strategy)
        {
            this._strategy = strategy;
        }
        /// <summary>
        /// Calculates the recommended calorie intake based on provided parameters.
        /// </summary>
        /// <param name="age">Age of the individual.</param>
        /// <param name="height">Height of the individual.</param>
        /// <param name="weight">Weight of the individual.</param>
        /// <returns>The recommended calorie intake.</returns>
        public double CalculateRecommendedCalorie(int age, int height, double weight)
        {
            return _strategy.CalculateRecommendedCalorieIntake(age, height, weight);
        }
    }
}
