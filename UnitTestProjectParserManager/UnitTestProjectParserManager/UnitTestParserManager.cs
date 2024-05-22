using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserMgr;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectParserManager
{
    public class StubHttpMessageHandler : HttpMessageHandler
    {
        private readonly Dictionary<string, HttpResponseMessage> _responses = new Dictionary<string, HttpResponseMessage>();

        public StubHttpMessageHandler(Dictionary<string, HttpResponseMessage> responses)
        {
            foreach (var kvp in responses)
            {
                _responses.Add(kvp.Key, kvp.Value);
            }
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string key = request.RequestUri.ToString();
            if (_responses.ContainsKey(key))
            {
                return Task.FromResult(_responses[key]);
            }
            else
            {
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
        }
    }

    [TestClass]
    public class ParserManagerTests
    {
        [TestMethod]
        public void ParseDoubleValidInputReturnsParsedValue()
        {
            // Arrange
            var parserManager = ParserManager.Instance;
            string input = "166.2 calories";
            double expected = 166.2;

            // Act
            double result = parserManager.ParseDouble(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseDoubleInvalidInputThrowsArgumentException()
        {
            // Arrange
            var parserManager = ParserManager.Instance;
            string input = "Invalid value";

            // Act
            double result = parserManager.ParseDouble(input);

            // Assert
            // Expected exception
        }
        [TestMethod]

        public async Task ParseSearchValidQueryReturnsFormattedResults()
        {
            // Arrange
            string query = "apple";

            // Act
            List<string> results = await ParserManager.Instance.ParseSearch(query);
            
            // Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public async Task ParseSearchInvalidQueryReturnsEmptyList()
        {
            // Arrange
            string query = "";

            // Act
            List<string> results = await ParserManager.Instance.ParseSearch(query);

            // Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count == 0);
        }

        [TestMethod]

        public async Task ParseSearchValidQueryReturnsCorrectProperties()
        {
            // Arrange
            string query = "apple";

            // Act
            List<string> results = await ParserManager.Instance.ParseSearch(query);

            // Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(results[0].Contains(":") && results[0].Contains("calories") && results[0].Contains("g serving size") && results[0].Contains("g fat") && results[0].Contains("g protein") && results[0].Contains("g carbohydrates"));
        }
    }
}
