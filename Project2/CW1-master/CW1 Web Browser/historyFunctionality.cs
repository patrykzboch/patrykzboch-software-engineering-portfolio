using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1_Web_Browser
{
    public class HistoryFunctionality(WebBrowser webBrowser)
    {
        // List to store the user's browsing history
        private List<string> userHistory = [];

        // Counter to keep track of position in the history
        int counter = -1;

        // Instance of webBrowser 
        private readonly WebBrowser webBrowser = webBrowser;

        // Adds a URL to the browsing history and updates the history panel by adding a button to it
        public void AddToHistory(Panel historyPanel, string url)
        {

            // If the counter is not at the end of the history list and lets say we go to a new web page
            // I.e. facebook -> instagram -> google, then when we go back to instagram and go to a new  web page (hackerrank)
            // We will have the following in the history facebook -> instagram -> hackerrank
            // We want to discard any webpages after that which mimicks behaviour of how other browsers behave
            if (counter < userHistory.Count - 1)
            {
                userHistory = userHistory.Take(counter + 1).ToList();
            }

            // Add the url to the history list
            userHistory.Add(url);
            counter++;

            // Creates a button with the corresponding properties
            Button button = new()
            {
                Text = url,
                Width = 180,
                Height = 35
            };

            // Adds the button to the history panel
            historyPanel.Controls.Add(button);

            // Click event handler for button added to the panel
            button.Click += async (s, args) =>
            {
                // Hide the history panel
                historyPanel.Visible = false;

                // Fetch and Display the HTTP reponse when the button is clicked
                await webBrowser.FetchAndDisplayHttpResponse(button.Text, true);
            };


        }

        // Writes the history list to file
        public void WriteHistoryToFile()
        {

            // Get the file path for the file in user documents used to store browsing history
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userHistory.txt");

            // Create the file if it does not exist
            if (!File.Exists(filePath))
            {
                // Creates an empty file and closes it after 
                File.Create(filePath).Close();
            }

            // If file does exist already
            if (File.Exists(filePath))
            {
                // Write the history list to the file
                File.AppendAllLines(filePath, userHistory);
            }
        }

        // Reads user history from file
        public void ReadHistoryFromFile(Panel historyPanel)
        {
            // Get the file path for the file in user documents used to store browsing history
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userHistory.txt");

            // Checks if the file exists
            if (File.Exists(filePath))
            {
                // Opens file for browsing
                using StreamReader reader = new(filePath);
                string line;

                // Read the file until we reach the end of it
                while ((line = reader.ReadLine()) != null)
                {
                    // Create a button for each url read from the file
                    Button button = new()
                    {
                        Text = line,
                        Width = 180,
                        Height = 35
                    };
                    historyPanel.Controls.Add(button);

                    // Add the url to the userHistory
                    userHistory.Add(line);

                    // Adds an click event for the button
                    button.Click += async (s, args) =>
                    {
                        // Hide the history panel
                        historyPanel.Visible = false;

                        // Fetch and display the HTTP reponse
                        await webBrowser.FetchAndDisplayHttpResponse(button.Text, true);
                    };

                }

            }

        }

        // Method to increment the counter
        public void IncrementCounter()
        {
            counter++;
        }

        // Method to decrement the counter
        public void DecrementCounter()
        {
            counter--;
        }

        // Method to return the current counter amount
        public int ReturnCounter()
        {
            return counter;
        }

        // Method to get the url from the corresponding counter position in the history list
        public string GetUrl()
        {
            return userHistory[counter];
        }

        // Gets the size of history list
        public int GetHistorySize()
        {
            return userHistory.Count;
        }

    }
}