/**************************************************************************
 *                                                                        *
 *  File:        ParserManager.cs                                         *
 *  Copyright:   (c) 2024, Gisca Valentin                                 *
 *  E-mail:      v.gisca2710@gmail.com                                    *
 *  Website:     https://github.com/Trased/Calorie-calculator             *
 *  Description: Defines a class for managing parsing operations,         *
 *               including parsing double values and parsing nutrition    *
 *               search results from an API.                              *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParserMgr
{
    /// <summary>
    /// Singleton class for managing parsing operations.
    /// </summary>
    public class ParserManager
    {
        private static ParserManager _instance;

        private const string _apiKey = "E5qITUdOAIXGzxL6FPc1tA==4XBr61cs4m6nWiCu";
        private const string _apiUrl = "https://api.api-ninjas.com/v1/nutrition";

        public event EventHandler<string> OnMessageBox;
        /// <summary>
        /// Private default class constructor required for Singleton
        /// </summary>
        private ParserManager() { }
        /// <summary>
        /// Singleton instance accessor.
        /// </summary>
        public static ParserManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ParserManager();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Parses a string to a double value, extracting the numeric part.
        /// </summary>
        /// <param name="part">String to parse.</param>
        /// <returns>Parsed double value.</returns>
        public double ParseDouble(string part)
        {
            // Example: " 166.2 calories" or "116 g protein"
            string[] splitPart = part.Trim().Split(' '); // Split by space
            if (splitPart.Length > 1)
            {
                double value;
                if (double.TryParse(splitPart[0], out value))
                {
                    return value;
                }
            }
            throw new ArgumentException("Invalid value format: " + part);
        }

        /// <summary>
        /// Parses a search query and retrieves nutrition information from an external API.
        /// </summary>
        /// <param name="query">Search query.</param>
        /// <returns>List of formatted nutrition results.</returns>
        public async Task<List<string>> ParseSearch(string query)
        {
            string fullUrl = $"{_apiUrl}?query={query}";
            List<string> formattedResults = new List<string>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Api-Key", _apiKey);

                    HttpResponseMessage response = await client.GetAsync(fullUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<Nutrition> nutritionList = JsonConvert.DeserializeObject<List<Nutrition>>(responseBody);
                        foreach (Nutrition nutrition in nutritionList)
                        {
                            string formattedResult = $"{nutrition.Name}: {nutrition.Calories} calories, {nutrition.Serving_size_g} g serving size, {nutrition.Fat_total_g} g fat, {nutrition.Protein_g} g protein, {nutrition.Carbohydrates_total_g} g carbohydrates";
                            formattedResults.Add(formattedResult);
                        }
                    }
                    else
                    {
                        OnMessageBox?.Invoke(this, $"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                   
                }
            }
            catch(HttpRequestException ex)
            {
                OnMessageBox?.Invoke(this, ex.Message);
            }
            return formattedResults;
        }
    }
}
