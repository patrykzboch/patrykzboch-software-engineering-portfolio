
namespace CW1_Web_Browser
{
    public class FavouritesFunctionality(HttpService httpService, WebBrowser webBrowser)
    {

        // Path to the file where user favourites will be saved
        readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userFavourites.txt");

        // Instance of the WebBrowser to display the fetched URLs
        private readonly WebBrowser browser = webBrowser;

        // Dictionary to hold the user's favourite URLs
        public Dictionary<string, string> UserFavourites { get; private set; } = [];

        // Validates if the provided URL is reachable
        public static async Task<bool> ValidateURL(string url)
        {
            try
            {
                // Fetch the HTML content from the URL
                var response = await HttpService.FetchHtmlContentAsync(url);

                // Return true if the response was successfull
                return response.IsSuccessful;
            }
            catch
            {
                // Return false if an exception occurs
                return false;
            }
        }

        // Adds a new favourite URL with a name
        public async Task<bool> AddFavourite(string name, string url)
        {
            // Check if the name in the text box is empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if the the favourite with this name already exists
            if (UserFavourites.ContainsKey(name))
            {
                MessageBox.Show("A favorite with this name already exists. Please enter a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate the URL
            if (!await ValidateURL(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Add the favorite to the dictionary if the name and URL are valid
            UserFavourites.Add(name, url);

            // Return true if the addition of the new favourite was successfull
            return true;
        }

        // Edits an existing favourite's name 
        public bool EditFavourite(string oldName, string newName)
        {

            // Check if the old name exists
            if (UserFavourites.TryGetValue(oldName, out string? value))
            {
                // Get the url associated with the url
                string url = value;

                // Remove the old favourite and add the new one with the previously saved url
                UserFavourites.Remove(oldName);
                UserFavourites.Add(newName, url);

                // Return true if the editing was successfull
                return true;
            }

            // Else let the user know that the favourite does not exit
            else
            {
                MessageBox.Show("The favorite with the old name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Saves the current favourites to a file
        public void SaveFavouritesToFile()
        {
            // Initialise the list to hold the favourites
            List<string> keyValList = [];

            // Loop through each entry and add them to the list
            // The pairs will be every two lines 
            // i.e. line 1 = favourite1 , line 2 = favourite1URL
            foreach (var entry in UserFavourites)
            {
                keyValList.Add(entry.Key);
                keyValList.Add(entry.Value);
            }

            // Write all key-value pairs to the file
            File.WriteAllLines(filePath, keyValList);
        }

        // Reads the favourites from the file and adds them to the GUI
        public void ReadFavouritesFromFile(Panel favouritesListPanel)
        {
            // Checks if the file exists
            if (File.Exists(filePath))
            {
                // Open the file for reading
                using StreamReader reader = new(filePath);
                string name, url;

                // Read the file until we extract all key-value pairs from the file
                while ((name = reader.ReadLine()) != null && (url = reader.ReadLine()) != null)
                {
                    // Add the favourite to the dictionary
                    UserFavourites.Add(name, url);

                    // Create a new button with necessary properties
                    Button button = new()
                    {
                        Width = 180,
                        Height = 35,
                        Text = name,
                        Tag = url
                    };

                    // Add the button to the favouritesListPanel
                    favouritesListPanel.Controls.Add(button);

                    // Add a click event for each button
                    button.Click += async (s, args) =>
                    {
                        // Hide the favourites list
                        favouritesListPanel.Visible = false;
                        await browser.FetchAndDisplayHttpResponse(button.Tag.ToString(), true);
                    };

                }
            }

        }

        // Removes a favourite by its name and updates the GUI
        public bool RemoveFavourite(string name, Panel favouritesListPanel)
        {
            // Check if the favourite name exists
            if (!UserFavourites.ContainsKey(name))
            {
                // Let the user know that such favourite does not exist
                MessageBox.Show("The favourite with the specified name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Favourite that we want to remove exists
            else
            {
                // Remove it from the dictionary
                UserFavourites.Remove(name);

                // Loop through each button in the favouritesListPanel until we find the button we want to remove
                foreach (Control buttonControl in favouritesListPanel.Controls)
                {
                    // We found the button
                    if (buttonControl.Text == name)
                    {
                        // Remove the button from the controls
                        favouritesListPanel.Controls.Remove(buttonControl);

                        // Exit the loop after removing the button
                        break; 
                    }
                }

                // Return true if removal was successfull
                return true;
            }
        }

    }
}
