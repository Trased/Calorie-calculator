/**************************************************************************
 *                                                                        *
 *  File:        ICalorieInstake.cs                                       *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Calorie calculator generic interface                     *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

namespace Strategy
{
    /// <summary>
    /// Calorie calculator Interface
    /// </summary>
    public interface ICalorieIntake
    {
        /// <summary>
        /// Generic function for recommended calorie calculation
        /// </summary>
        /// <param name="age">Age of the individual.</param>
        /// <param name="height">Height of the individual.</param>
        /// <param name="weight">Weight of the individual.</param>
        /// <returns>The recommended calorie intake.</returns>
        double CalculateRecommendedCalorieIntake(int age, int height, double weight);
    }
}
