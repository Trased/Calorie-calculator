/**************************************************************************
 *                                                                        *
 *  File:        Nutrition.cs                                             *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines a class representing nutrition information       *
 *               for a food item.                                         *
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
using Newtonsoft.Json;

namespace ParserMgr
{
    public class Nutrition
    {
        /// <summary>
        /// Name of the food item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Calories per serving of the food item.
        /// </summary>
        [JsonProperty("calories")]
        public double Calories { get; set; }

        /// <summary>
        /// Serving size in grams of the food item.
        /// </summary>
        [JsonProperty("serving_size_g")]
        public double ServingSizeG { get; set; }

        /// <summary>
        /// Total fat content in grams of the food item.
        /// </summary>
        [JsonProperty("fat_total_g")]
        public double FatG { get; set; }

        /// <summary>
        /// Protein content in grams of the food item.
        /// </summary>
        [JsonProperty("protein_g")]
        public double ProteinG { get; set; }

        /// <summary>
        /// Total carbohydrates content in grams of the food item.
        /// </summary>
        [JsonProperty("carbohydrates_total_g")]
        public double CarbohydratesG { get; set; }
    }
}
