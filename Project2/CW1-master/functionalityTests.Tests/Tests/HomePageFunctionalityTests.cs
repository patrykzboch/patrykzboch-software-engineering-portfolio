using CW1_Web_Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace functionalityTests.Tests.Tests
{
    public class HomePageFunctionalityTests
    {

        private HomePageFunctionality _homePageFunctionality;
        private string testFilePath;

        public HomePageFunctionalityTests()
        {
            testFilePath = "userHomePageTest.txt";
            _homePageFunctionality = new HomePageFunctionality(testFilePath);
            CleanFile();  // Ensure test file is cleaned before each test run
        }

        private void CleanFile()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), testFilePath);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [Fact]
        public void SetHomePageUrl_ValidUrl_ShouldSetHomePageUrl()
        {
            // Arrange
            string url = "www.facebook.com";

            // Act
            _homePageFunctionality.SetHomePageUrl(url);

            // Assert
            Assert.Equal(url, _homePageFunctionality.GetHomePageUrl());
        }

        [Fact]
        public void WriteHomePageToFile()
        {
            // Arrange
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), testFilePath);
            string url = "google.com";

            // Act
            _homePageFunctionality.WriteHomePageToFile(url);

            // Assert
            string fileContent = File.ReadAllText(filePath);
            Assert.Equal(url, fileContent);
            Assert.True(File.Exists(filePath));
        }

        [Fact]
        public void ReadHomePageFromFile()
        {
            // Arrange
            string url = "www.google.com";
            _homePageFunctionality.WriteHomePageToFile(url);

            // Act
            string result = _homePageFunctionality.ReadHomePageFromFile();

            // Assert
            Assert.Equal(url, result);
        }
    }
}
