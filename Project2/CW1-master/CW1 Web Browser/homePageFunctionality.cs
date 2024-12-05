using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_Web_Browser
{
    // Class responsible for the home page functionality
    public class HomePageFunctionality(string fileName = "userHomePage.txt")
    {
        // Default URL for the homepage
        private string homePageUrl = "https://www.hw.ac.uk/";

        // File path used to store the home page url
        readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

        // Method to set a homepage URL
        public void SetHomePageUrl(string url)
        {
            // Check if the url is not null or whitespace
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("URL cannot be empty.");

            // If the url is valid then set it to the home page url
            homePageUrl = url;
        }

        // Method to return the current home page url
        public string GetHomePageUrl()
        {
            return homePageUrl;
        }

        // Method to read the home page url from file
        public string ReadHomePageFromFile()
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the url and set it to the home page url
                homePageUrl = File.ReadAllText(filePath);
                return homePageUrl;
            }
            // If file does not exits means new user so just use default url for the home page
            return "https://www.hw.ac.uk/";
        }

        // Writes the homepage url to file
        public void WriteHomePageToFile(string homePageUrl)
        {
           // Writes the latest home page url to the file for later retrieval
           File.WriteAllText(filePath, homePageUrl);
        }

    }
}
