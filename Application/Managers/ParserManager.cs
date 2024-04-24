using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public class ParserManager
    {
        private static ParserManager _instance;

        private const string _apiKey = "E5qITUdOAIXGzxL6FPc1tA==4XBr61cs4m6nWiCu";
        private const string _apiUrl = "https://api.api-ninjas.com/v1/nutrition";


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

        public double ParseDouble(string part)
        {
            // Example: " 166.2 calories"
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

        public  async Task<List<string>> ParseSearch(string query)
        {
            string fullUrl = $"{_apiUrl}?query={query}";
            List<string> formattedResults = new List<string>();

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
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
                return formattedResults;
            }
        }
    }
}
