using AngleSharp.Io;
using CW1_Web_Browser;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;


namespace functionalityTests.Tests.Tests
{
    public class HttpServiceTests
    {
        [Fact]
        public async Task FetchHtmlContent_validURL()
        {
            string validURL = "www.facebook.com";
            HttpService httpService = new HttpService();
            string titleMatchPattern = @"<title[^>]*>\s*(.*?)\s*</title>";
            Regex regexObj = new Regex(titleMatchPattern, RegexOptions.IgnoreCase);
            string expectedTitle = "Facebook – log in or sign up";
            
            RestResponse response = await HttpService.FetchHtmlContentAsync(validURL);
            Match regexMatch = regexObj.Match(response.Content);
            string actualTitle = regexMatch.Groups[1].Value;

            Assert.NotNull(response);
            Assert.True(response.IsSuccessful);
            Assert.Equal(actualTitle, expectedTitle);

        }

        [Fact]
        public async Task FetchHtmlContent_InvalidURL_Error400()
        {
            string URL400 = "http://status.savanttools.com/?code=400%20Bad%20Request";
            HttpService httpService = new HttpService();
            
            
            RestResponse response = await HttpService.FetchHtmlContentAsync(URL400);

            Assert.NotNull(response);
            Assert.Equal(400, (int)response.StatusCode);
        }

        [Fact]
        public async Task FetchHtmlContent_InvalidURL_Error403()
        {
            string URL403 = "http://status.savanttools.com/?code=403%20Forbidden";
            HttpService httpService = new HttpService();


            RestResponse response = await HttpService.FetchHtmlContentAsync(URL403);

            Assert.NotNull(response);
            Assert.Equal(403, (int)response.StatusCode);
        }

        [Fact]
        public async Task FetchHtmlContent_InvalidURL_Error404()
        {
            string URL404 = "http://status.savanttools.com/?code=404%20Not%20Found";
            HttpService httpService = new HttpService();


            RestResponse response = await HttpService.FetchHtmlContentAsync(URL404);

            Assert.NotNull(response);
            Assert.Equal(404, (int)response.StatusCode);
        }
    }
}
