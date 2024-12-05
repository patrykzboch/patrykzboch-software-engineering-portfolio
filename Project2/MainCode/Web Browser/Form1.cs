using System.IO;
using System.Text.RegularExpressions;

namespace CW1_Web_Browser
{
    public partial class WebBrowser : Form
    {
        public string lastVisitedURL;
        private string homePageUrl;
        private readonly HttpService httpService;
        private readonly HomePageFunctionality _homePageFunctionality;
        private readonly FavouritesFunctionality _favouritesFunctionality;
        private readonly HistoryFunctionality _historyFunctionality;
        readonly Dictionary<string, string> userFavourites;


        public WebBrowser()
        {
            InitializeComponent();
            lastVisitedURL = string.Empty;
            httpService = new HttpService();
            _homePageFunctionality = new HomePageFunctionality();
            
            _historyFunctionality = new HistoryFunctionality(this);
            _favouritesFunctionality = new FavouritesFunctionality(httpService, this);
            homePageUrl = _homePageFunctionality.ReadHomePageFromFile();
            userFavourites = [];
            InitializeHomePage();
            _favouritesFunctionality.ReadFavouritesFromFile(favouritesListPanel);
            closeFavouriteList.Width = 180;
            closeHistoryButton.Width = 180;
            _historyFunctionality.ReadHistoryFromFile(historyPanel);

        }

        // Method to disply the HTML content
        // Takes in the url that we want to browse and a bool to know whether we want to add the url to the history or not
        public async Task FetchAndDisplayHttpResponse(string URL, bool addToHistory)
        {

            try
            {

                // Asynchronously fetch the HTML content from the provided URL using the method from the httpService class
                var response = await HttpService.FetchHtmlContentAsync(URL);

                // Check if the response given back is a successfull HTTP request
                if (response.IsSuccessful)
                {
                    // Display the HTML content in the htmlContentBox

                    // Show the HTTP status code and its description in the statusCodeLabel
                    htmlContentBox.Text = response.Content;
                    statusCodeLabel.Text = $"{(int)response.StatusCode} {response.StatusCode}";
                    statusCodeLabel.Visible = true;

                    // Check if the response content is not empty
                    if (!string.IsNullOrEmpty(response.Content))
                    {
                        // Store the last visited URL
                        lastVisitedURL = URL;

                        // Update the search box with the current URL
                        searchBox.Text = URL;

                        // Pattern to be matched by the regex to find the title tag within the html
                        // <title[^>]*> matches the opening title tag, allowing for any attributes (if present) e.g. "id = "
                        // \s* : matches zero to many occurences of whitespace after the first title tag
                        // (.*?) captures the title text between the title tags
                        // \s* matches zero or more occurences of whitespaces before the closing title tag
                        // Finally </title> matches the closing title tag completing the regex
                        string titleMatchPattern = @"<title[^>]*>\s*(.*?)\s*</title>";

                        // Creates a regex object using the pattern titleMatchPattern
                        Regex regexObj = new(titleMatchPattern, RegexOptions.IgnoreCase);

                        // Applies the regex object with the regular expresssion to the html content to find the match
                        Match regexMatch = regexObj.Match(response.Content);

                        // If the title tag has been found within the html
                        if (regexMatch.Success == true)
                        {
                            // Extracts the title captured in the () before
                            // Sets the title label to the captured title and makes it visible
                            string extractedTitle = regexMatch.Groups[1].Value;
                            pageTitleLabel.Text = extractedTitle;
                            pageTitleLabel.Visible = true;
                        }
                        else
                        {
                            // If  the title is not found then just hide it
                            pageTitleLabel.Visible = false;
                        }

                        // Case where we want the page we navigate to be added to the history
                        if (addToHistory)
                        {
                            // Call the method within history functionality class to add the history logic
                            _historyFunctionality.AddToHistory(historyPanel, URL);
                        }
                    }

                }

                else
                {
                    // If the response is not valid then show the error code in the html box and show the status code label
                    htmlContentBox.Text = $"{(int)response.StatusCode} {response.StatusCode}";
                    statusCodeLabel.Text = $"{(int)response.StatusCode} {response.StatusCode}";
                    statusCodeLabel.Visible = true;
                    pageTitleLabel.Visible = false;
                }
            }
            // Catch any other exception
            catch (Exception ex)
            {
                htmlContentBox.Text = $"Error fetching the HTML from the URL: {ex.Message}";
            }

        }

        // Event handler for the search button click
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            // Grab the url from the search box and call the FetchAndDisplayHttpResponse method on it and add it to history
            string url = searchBox.Text;
            await FetchAndDisplayHttpResponse(url, true);
        }

        // Event handler for the refresh button click event 
        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            // Hide the page title label as we're about to refresh the content
            pageTitleLabel.Visible = false;

            // Hide the status code label to clear previous status information
            statusCodeLabel.Visible = false;
            
            // Clear the HTML content box and the search box
            htmlContentBox.Text = String.Empty;
            searchBox.Text = String.Empty;

            // Create an instance of the RefreshPage class, passing the current context (this)
            RefreshPage refresh = new(this);

            // Call the refreshPageAsync() method 
            await refresh.RefreshPageAsync();
        }

        // Event handler for homeButton click
        private void HomeButton_Click(object sender, EventArgs e)
        {
            // If the homePagePanel is visible then you can click the home button again to close it
            if (homePagePanel.Visible)
            {
                homePagePanel.Visible = false;
            }

            // If its not opened then simply open it and bring it to the front
            else
            {
                homePagePanel.BringToFront();
                homePagePanel.Visible = true;
            }
        }

        // Async method to initialize the home page
        private async void InitializeHomePage()
        {
            // Get the home page url and call FetchAndDisplayHttpResponse() method on it
            string homePageUrl = _homePageFunctionality.GetHomePageUrl();
            await FetchAndDisplayHttpResponse(homePageUrl, false);
        }

        // Event handler for homePageButton
        private async void HomePageButton_Click(object sender, EventArgs e)
        {

            // Hide the homePagePanel,statusCodeLabel and the page title
            // Clear the html content box and the search box
            homePagePanel.Visible = false;
            statusCodeLabel.Visible = false;
            htmlContentBox.Text = string.Empty;
            searchBox.Text = string.Empty;
            pageTitleLabel.Visible = false;

            // Check if the current page we are on is not the current homePage
            // If the current webpage is not then call FetchAndDisplayHttpResponse() with the url and add the url to the history
            if (lastVisitedURL != _homePageFunctionality.GetHomePageUrl())
            {
                await FetchAndDisplayHttpResponse(_homePageFunctionality.GetHomePageUrl(), true);
            }

            // If we are already on the home page then call the FetchAndDisplayHttpResponse() but don't add the url to the history
            else
            {
                await FetchAndDisplayHttpResponse(_homePageFunctionality.GetHomePageUrl(), false);
            }
        }

        // Event handler for the set home button
        private void SetHomePageButton_Click(object sender, EventArgs e)
        {
            // Hide the home page panel, make the set home page panel visible and bring it to the front
            homePagePanel.Visible = false;
            setHomePagePanel.Visible = true;
            setHomePagePanel.BringToFront();
           
        }

        // Event handler for the set home button
        private async void SubmitSetHomeButton_Click(object sender, EventArgs e)
        {
            // Get the url of the page that the user wants to set their home page to
            string newUrl = setHomePagePanelBox.Text;

            try
            {
                // Get the HTTP response for the corresponding url
                var response = await HttpService.FetchHtmlContentAsync(newUrl);

                // If the reponse is successfull then it means it is valid and we can proceed
                if (response.IsSuccessStatusCode)
                {
                    // Update the homePage url to the new one entered by the user
                    homePageUrl = newUrl;
                    _homePageFunctionality.SetHomePageUrl(newUrl);

                    // Hide the panel and clear the text box within it
                    setHomePagePanel.Visible = false;
                    setHomePagePanelBox.Text = string.Empty;
                }
                
                // Url entered by the user is invalid
                else
                {
                    MessageBox.Show("The URL you entered is not reachable. Please enter a valid URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Catch any unexpecred exceptions
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the cancel set home page panel
        private void CancelSetHomePagePanel_Click(object sender, EventArgs e)
        {
            // Clear the text and hide the panel
            setHomePagePanelBox.Text = string.Empty;
            setHomePagePanel.Visible = false;

        }

        // Event handler for the favourite button click
        private void FavouriteButton_Click(object sender, EventArgs e)
        {
            // If the favourites panel is already opened then by clicking the star button you can close it back up
            if (favouritesPanel.Visible)
            {
                favouritesPanel.Visible = false;
            }

            // Make the favourites panel visible and bring it to the front
            else
            {
                favouritesPanel.Visible = true;
                favouritesPanel.BringToFront();
                favouritesNameBox.Text = string.Empty;
            }
        }

        // Event handler for the add button in the favourites
        private async void AddButtonFavourites_Click(object sender, EventArgs e)
        {
            // Retrieve the name and URL from the text input fields for the new favourite
            string name = favouritesNameBox.Text;
            string url = searchBox.Text;

            // Attempt to add the favourite using the favourites functionality and store success status
            bool isAdded = await _favouritesFunctionality.AddFavourite(name, url);

            if (isAdded)
            {
                // If added successfully, add the name and URL to the userFavourites dictionary
                userFavourites.Add(name, url);

                // Hide the favourites panel as the favourite has been successfully added
                favouritesPanel.Visible = false;

                // Create a new button with the favourite's name for display in the favourites list
                Button button = new()
                {
                    Text = name
                };
                favouritesListPanel.Controls.Add(button);

                // Store the URL in the button's Tag property for quick access
                button.Tag = url;
                button.Width = 180;
                button.Height = 35;

                // Event handler for when the new favourite button is clicked
                button.Click += async (s, args) =>
                {
                    // Hide the favourites list panel when a favourite is selected and clear the favourites name input box
                    favouritesListPanel.Visible = false;
                    favouritesNameBox.Text = string.Empty;

                    // Fetch and display the content of the URL associated with the favourite
                    await FetchAndDisplayHttpResponse(button.Tag.ToString(), true);
                };

                // Clear the favourites name input box after adding the favourite
                favouritesNameBox.Text = string.Empty;
            }
        }

        // Event handler for the Edit button for favourites
        private void EditFavouritesButton_Click(object sender, EventArgs e)
        {
            // Make the edit panel visible, bring it to the front and hide the favourites panel
            editPanel.Visible = true;
            editPanel.BringToFront();
            favouritesPanel.Visible = false;
        }

        // Event handler for the Edit panel submit button
        private void EditPanelSubmitButton_Click(object sender, EventArgs e)
        {
            // Get the old name and the new name we want to set the favourite to
            string oldName = oldNameBox.Text;
            string newName = newNameBox.Text;

            // Validate that both old and new names are entered
            if (String.IsNullOrEmpty(oldName) || String.IsNullOrEmpty(newName))
            {
                MessageBox.Show($"enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to edit the favourite name in the functionality layer and store success status
            bool isEdited = _favouritesFunctionality.EditFavourite(oldName, newName);

            if (isEdited)
            {
                // If edited successfully, clear the name input fields and hide the edit panel
                newNameBox.Text = string.Empty;
                oldNameBox.Text = string.Empty;
                editPanel.Visible = false;

                // Loop through each button in the favouritesListPanel until we find the one with the name we want to edit
                foreach (Control buttonControl in favouritesListPanel.Controls)
                {
                    // Check if we found the button
                    if (buttonControl.Text == oldName)
                    {
                        // Button found so change its name to the new name
                        buttonControl.Text = newName;
                        break;

                    }
                }
            }

        }

        // Event handler for the Edit panel cancel button
        private void EditPanelCancelPanel_Click(object sender, EventArgs e)
        {
            // Hide the edit panel and clear the input boxes
            editPanel.Visible = false;
            oldNameBox.Text = string.Empty;
            newNameBox.Text = string.Empty;
        }

        // Event handler for the remove favourite panel
        private void RemoveFavouriteButton_Click(object sender, EventArgs e)
        {
            // Hide the favourites panel and show the remove panel and bring it to the front
            favouritesPanel.Visible = false;
            removeFavouritePanel.Visible = true;
            removeFavouritePanel.BringToFront();
        }

        // Event handler for the remove favourite cancel button
        private void RemoveFavouritePanelButton_Click(object sender, EventArgs e)
        {
            // Clear the input box and hide the panel
            removeNameBox.Text = string.Empty;
            removeFavouritePanel.Visible = false;
        }

        // Event handler for the remove favourite panel submit button
        private void RemovePanelSubmitButton_Click(object sender, EventArgs e)
        {
            // Get the name to be removed
            string removeName = removeNameBox.Text;

            // Clear the input boxes and hide the panel
            removeNameBox.Text = string.Empty;
            removeFavouritePanel.Visible = false;

            // Call the removeFavourite() method to remove the favourite
            _favouritesFunctionality.RemoveFavourite(removeName, favouritesListPanel);
        }

        // Override the OnFormClosing to save the user data when the user closes the form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Write home page to file
            _homePageFunctionality.WriteHomePageToFile(homePageUrl);

            // Write fvourite to file
            _favouritesFunctionality.SaveFavouritesToFile();

            // Write the history to file
            _historyFunctionality.WriteHistoryToFile();

            // Close the form
            base.OnFormClosing(e);
        }

        // Event handler for the more button click
        private void MoreButton_Click(object sender, EventArgs e)
        {
            // If panel is already opened then close it up by clicking the more button again
            if (morePanel.Visible)
            {
                morePanel.Visible = false;
            }

            // If its not opened yet then show it and bring it to the front
            else
            {
                morePanel.Visible = true;
                morePanel.BringToFront();
            }
        }

        // Event handler for the favourites button in the more panel
        private void FavouriteMorePanelButton_Click(object sender, EventArgs e)
        {
            // Open the favourites list panel, bring it to the front and hide the more panel
            favouritesListPanel.Visible = true;
            favouritesListPanel.BringToFront();
            morePanel.Visible = false;
        }

        //Event handler for the cancel button within the favourites list panel
        private void CloseFavouriteList_Click(object sender, EventArgs e)
        {
            // Hide the panel
            favouritesListPanel.Visible = false;
            
        }

        // Event handler for the history button within the more panel
        private void HistoryMorePanelButton_Click(object sender, EventArgs e)
        {
            // Show the history panel and bring it to the front
            // Hide the more panel
            historyPanel.Visible = true;
            historyPanel.BringToFront();
            morePanel.Visible = false;
            
        }

        // Event handler for back button click event
        private async void BackButton_Click(object sender, EventArgs e)
        {
            // Check if there is a previous page in history
            if (_historyFunctionality.ReturnCounter() > 0)
            {
                // Move back in history and decrement counter
                _historyFunctionality.DecrementCounter();

                // Fetch and display the previous page from history without adding it again to history
                await FetchAndDisplayHttpResponse(_historyFunctionality.GetUrl(), false);
            }
        }

        private async void ForwardButton_Click(object sender, EventArgs e)
        {
            // Check if there is a next page in history that can be visited
            if (_historyFunctionality.ReturnCounter() < _historyFunctionality.GetHistorySize() - 1)
            {
                // Move up in history and increment counter
                _historyFunctionality.IncrementCounter();

                // Fetch and display the next page from history without adding it again to history
                await FetchAndDisplayHttpResponse(_historyFunctionality.GetUrl(), false);
            }
        }

        // Event handler for the Close History button click event
        private void CloseHistoryButton_Click(object sender, EventArgs e)
        {
            // Hide the history panel when the close button is clicked
            historyPanel.Visible = false;
        }

        // Event handler for the Bulk Downloadc button click event within the morePanel
        private void BulkDownloadMorePanelButton_Click(object sender, EventArgs e)
        {
            // Hide the more panel, make the bulkDownloadPanel visible and bring it to the front
            morePanel.Visible = false;
            bulkDownloadPanel.Visible = true;
            bulkDownloadPanel.BringToFront();
        }

        // Event handler for the Bulk Download "Cancel" button click event
        private void BulkDownloadCancelButton_Click(object sender, EventArgs e)
        {
            // Hide the bulk download panel and empty the input box
            bulkDownloadPanel.Visible = false;
            fileNameBox.Text = string.Empty;
        }

        // Event handler for submitting the bulk download
        private void SubmitBulk_Click(object sender, EventArgs e)
        {
            // Get the file name
            string fileName = fileNameBox.Text;

            // Get the file path to the users documents and the file name
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            // Clear the box
            fileNameBox.Text = string.Empty;


            // Check if the specified file exists in the documents directory
            if (File.Exists(filePath))
            {
                // Initiate the bulk download process with the specified file
                BulkDownloadFunctionality.BulkDownload(fileName,searchBox, htmlContentBox, bulkDownloadPanel,statusCodeLabel, pageTitleLabel);
            }

            // Show an error message if the file does not exist in the user's documents folder
            else
            {
                MessageBox.Show($"A file with this name does not exist in your documents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Event handler for the Default Bulk Download button click event
        private void DefaultDownloadButton_Click(object sender, EventArgs e)
        {
            // Define the default file path "bulk.txt" in the user's Documents folder
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bulk.txt");

            // Clear the input box
            fileNameBox.Text= string.Empty;

            // Check if the specified file exists in the documents directory
            if (File.Exists(filePath))
            {
                // Initiate the bulk download process with the specified file
                BulkDownloadFunctionality.BulkDownload("bulk.txt", searchBox, htmlContentBox, bulkDownloadPanel, statusCodeLabel, pageTitleLabel);
            }

            // Show an error message if the file does not exist in the user's documents folder
            else
            {
                MessageBox.Show($"A file with this name does not exist in your documents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
